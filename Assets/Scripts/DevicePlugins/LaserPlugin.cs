/*
 * Copyright (c) 2020 LG Electronics Inc.
 *
 * SPDX-License-Identifier: MIT
 */

using UnityEngine;
using Stopwatch = System.Diagnostics.Stopwatch;

public class LaserPlugin : DevicePlugin
{
	private SensorDevices.Lidar lidar = null;

	protected override void OnAwake()
	{
		partName = DeviceHelper.GetPartName(gameObject);
		lidar = gameObject.GetComponent<SensorDevices.Lidar>();
	}

	protected override void OnStart()
	{
		var hashKey = MakeHashKey(partName);
		if (!RegisterTxDevice(hashKey))
		{
			Debug.LogError("Failed to register for LaserPlugin - " + hashKey);
		}

		AddThread(Sender);
	}

	private void Sender()
	{
		Stopwatch sw = new Stopwatch();
		while (true)
		{
			if (lidar == null)
			{
				continue;
			}

			var datastreamToSend = lidar.PopData();
			sw.Restart();
			Publish(datastreamToSend);
			sw.Stop();
			lidar.SetTransportTime((float)sw.Elapsed.TotalSeconds);
		}
	}
}