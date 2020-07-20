/*
 * Copyright (c) 2020 LG Electronics Inc.
 *
 * SPDX-License-Identifier: MIT
 */

using System.Threading;
using UnityEngine;
using Stopwatch = System.Diagnostics.Stopwatch;

public class RobotControl : DevicePlugin
{
	private MicomInput micomInput = null;
	private MicomSensor micomSensor = null;
	private SensorDevices.IMU imuSensor = null;

	private Motor motorLeft = null;
	private Motor motorRight = null;

	public float wheelRadius = 0.0f; // in mether
	public float divideWheelRadius = 0.0f;

	protected override void OnAwake()
	{
		micomInput = gameObject.AddComponent<MicomInput>();
		micomSensor = gameObject.AddComponent<MicomSensor>();

		imuSensor = gameObject.GetComponentInChildren<SensorDevices.IMU>();
	}

	protected override void OnStart()
	{
		const float MM2M = 0.001f;
		var updateRate = parameters.GetValue<float>("update_rate", 20);
		micomSensor.SetUpdateRate(updateRate);

		var kp = parameters.GetValue<float>("PID/kp");
		var ki = parameters.GetValue<float>("PID/ki");
		var kd = parameters.GetValue<float>("PID/kd");

		var pidControl = new PID(kp, ki, kd);

		var wheelBase = parameters.GetValue<float>("wheel/base") * MM2M;
		wheelRadius = parameters.GetValue<float>("wheel/radius") * MM2M;
		divideWheelRadius = 1.0f/wheelRadius; // for performacne.

		var wheelNameLeft = parameters.GetValue<string>("wheel/location[@type='left']");
		var wheelNameRight = parameters.GetValue<string>("wheel/location[@type='right']");

		var debugging = parameters.GetValue<bool>("debug", false);
		micomInput.EnableDebugging = debugging;

		var motorFriction = parameters.GetValue<float>("wheel/friction/motor", 0.1f); // Currently not used
		var brakeFriction = parameters.GetValue<float>("wheel/friction/brake", 0.1f); // Currently not used

		var modelList = GetComponentsInChildren<ModelPlugin>();
		foreach (var model in modelList)
		{
			// Debug.Log(model.name);
			if (model.name.Equals(wheelNameLeft))
			{
				var jointWheelLeft = model.GetComponentInChildren<HingeJoint>();
				motorLeft = new Motor("Left", jointWheelLeft, pidControl);

				var wheelLeftBody = jointWheelLeft.gameObject.GetComponent<Rigidbody>();

				// Debug.Log("joint Wheel Left found : " + jointWheelLeft.name);
				// Debug.Log("joint Wheel Left max angular velocity : " + jointWheelLeft.gameObject.GetComponent<Rigidbody>().maxAngularVelocity);
			}
			else if (model.name.Equals(wheelNameRight))
			{
				var jointWheelRight = model.GetComponentInChildren<HingeJoint>();
				motorRight = new Motor("Right", jointWheelRight, pidControl);

				var wheelRightBody = jointWheelRight.gameObject.GetComponent<Rigidbody>();

				// Debug.Log("joint Wheel Right found : " + jointWheelRight.name);
				// Debug.Log("joint Wheel Right max angular velocity : " + jointWheelRight.gameObject.GetComponent<Rigidbody>().maxAngularVelocity);
			}

			if (motorLeft != null && motorRight != null)
			{
				break;
			}
		}

		var txHashKey = MakeHashKey("MICOM", "_SENSOR");
		if (!RegisterTxDevice(txHashKey))
		{
			Debug.LogError("Failed to register for RobotControl TX- " + txHashKey);
		}

		var rxHashKey = MakeHashKey("MICOM", "_INPUT");
		if (!RegisterRxDevice(rxHashKey))
		{
			Debug.LogError("Failed to register for RobotControl RX- " + rxHashKey);
		}

		AddThread(Sender);
		AddThread(Receiver);
	}

	void FixedUpdate()
	{
		var localRotation = transform.rotation;
		if (imuSensor != null)
		{
			micomSensor.SetIMU(imuSensor);
			micomSensor.SetAccGyro(localRotation.eulerAngles);
			// Debug.LogFormat("{0} {1}", localRotation, imuSensor.GetOrientation());
		}

		float linearVelocityLeft = 0;
		float linearVelocityRight = 0;

		if (motorLeft != null)
		{
			var targetWheelVelocityLeft = micomInput.GetWheelVelocityLeft() * divideWheelRadius;
			motorLeft.SetVelocityTarget(targetWheelVelocityLeft);
			linearVelocityLeft = motorLeft.GetCurrentVelocity() * wheelRadius;
		}

		if (motorRight != null)
		{
			var targetWheelVelocityRight = micomInput.GetWheelVelocityRight() * divideWheelRadius;
			motorRight.SetVelocityTarget(targetWheelVelocityRight);
			linearVelocityRight = motorRight.GetCurrentVelocity() * wheelRadius;
		}

		// Debug.LogFormat("{0} {1}, {2} {3} | {4}", motorLeft.GetCurrentVelocity(), linearVelocityLeft, motorRight.GetCurrentVelocity(), linearVelocityRight,  wheelRadius);
		micomSensor.SetOdomData(linearVelocityLeft, linearVelocityRight);
	}

	private void Sender()
	{
		var sw = new Stopwatch();
		while (true)
		{
			if (micomSensor == null)
			{
				continue;
			}

			var datastreamToSend = micomSensor.PopData();
			sw.Restart();
			Publish(datastreamToSend);
			sw.Stop();

			micomSensor.SetTransportTime((float)sw.Elapsed.TotalSeconds);
		}
	}

	private void Receiver()
	{
		while (true)
		{
			if (micomInput == null)
			{
				continue;
			}

			var receivedData = Subscribe();
			micomInput.SetDataStream(receivedData);
			Thread.SpinWait(5);
		}
	}
}