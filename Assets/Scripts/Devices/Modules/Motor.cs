/*
 * Copyright (c) 2020 LG Electronics Inc.
 *
 * SPDX-License-Identifier: MIT
 */

using UnityEngine;

public class Motor
{
	private string name = string.Empty;
	private PID pidControl = null;
	private HingeJoint joint = null;
	private Rigidbody rigidBody = null;
	// private Rigidbody topRigidBody = null;

	public Motor(in string name, in HingeJoint targetJoint, in PID pid)
		: this(name, targetJoint)
	{
		SetPID(pid);
	}

	public Motor(in string name, in HingeJoint targetJoint)
		: this(targetJoint)
	{
		SetName(name);
	}

	public Motor(in HingeJoint targetJoint)
	{
		joint = targetJoint;
		rigidBody = joint.gameObject.GetComponent<Rigidbody>();

		// foreach (var modelPlugin in rigidBody.gameObject.GetComponentsInParent<ModelPlugin>())
		// {
		// 	if (modelPlugin.IsTopModel)
		// 	{
		// 		topRigidBody = modelPlugin.gameObject.GetComponent<Rigidbody>();
		// 		break;
		// 	}
		// }

		targetJoint.useMotor = true;
	}

	public Motor(in HingeJoint targetJoint, in PID pid)
		: this(targetJoint)
	{
		SetPID(pid);
	}

	public void SetName(in string value)
	{
		name = value;
	}

	public void SetPID(in PID pid)
	{
		pidControl = pid.Copy();
	}

	public float GetCurrentVelocity()
	{
		return (joint)? joint.velocity:0;
	}

	/// <summary>Set Target Velocity with PID control</summary>
	/// <remarks>degree per second</remarks>
	public void SetVelocityTarget(in float targetAngularVelocity)
	{
		if (joint == null)
		{
			return;
		}

		var motor = joint.motor;
		float currentVelocity = GetCurrentVelocity();
		float cmdForce = pidControl.Update(targetAngularVelocity, currentVelocity, Time.fixedDeltaTime);

		// Debug.LogFormat("{0} Motor ({1} | {2} => {3}) max({4})",
		// 	name, currentVelocity, targetAngularVelocity, cmdForce, rigidBody.maxAngularVelocity);

		// JointMotor.targetVelocity angular velocity in degrees per second.
		motor.targetVelocity = targetAngularVelocity;
		motor.force = Mathf.Round(cmdForce);

		if (targetAngularVelocity == 0)
		{
			pidControl.Reset();
		}

		// Should set the JointMotor value to update
		joint.motor = motor;
	}
}