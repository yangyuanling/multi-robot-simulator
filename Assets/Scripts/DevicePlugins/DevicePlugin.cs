/*
 * Copyright (c) 2020 LG Electronics Inc.
 *
 * SPDX-License-Identifier: MIT
 */

using System.Collections.Generic;
using System.Threading;
using System.IO;
using System;
using UnityEngine;
using System.Xml;

public interface IDevicePlugin
{
	void SetPluginParameters(in XmlNode node);
	void Reset();
}

public abstract class DevicePlugin : DeviceTransporter, IDevicePlugin
{
	public string modelName = String.Empty;
	public string partName = String.Empty;

	protected PluginParameters parameters;

	private BridgePortManager bridgePortManager = null;

	private List<Thread> threadList = null;

	protected abstract void OnAwake();
	protected abstract void OnStart();
	protected virtual void OnReset() { }

	void OnDestroy()
	{
		// Debug.Log("OnDestroy - abort thread" + name);
		if (threadList != null)
		{
			foreach (var thread in threadList)
			{
				if (thread != null && thread.IsAlive)
				{
					thread.Abort();
				}
			}
		}
	}

	protected bool AddThread(in ThreadStart function)
	{
		if (threadList != null && function != null)
		{
			threadList.Add(new Thread(function));
			// thread.Priority = System.Threading.ThreadPriority.AboveNormal;
			return true;
		}

		return false;
	}

	private void StartThreads()
	{
		if (threadList != null)
		{
			foreach (var thread in threadList)
			{
				if (thread != null && !thread.IsAlive)
				{
					thread.Start();
				}
			}
		}
	}

	public void SetPluginParameters(in XmlNode node)
	{
		if (parameters != null)
		{
			parameters.SetRootData(node);
		}
		else
		{
			Debug.LogWarning("Cannot set plugin parameters");
		}
	}

	protected bool PrepareDevice(in string hashKey, out ushort port, out ulong hash)
	{
		port = bridgePortManager.AllocateSensorPort(hashKey);
		hash = DeviceHelper.GetStringHashCode(hashKey);

		if (port == 0)
		{
			Debug.LogError("Port for device is not allocated!!!!!!!!");
			return false;
		}
		// Debug.LogFormat("PrepareDevice - port({0}) hash({1})", port, hash);

		return true;
	}

	protected string MakeHashKey(in string partName = "", string subPartName = "")
	{
		return modelName + partName + subPartName;
	}

	protected bool RegisterTxDevice(in string hashKey)
	{
		if (PrepareDevice(hashKey, out ushort port, out ulong hash))
		{
			SetHashForPublish(hash);
			InitializePublisher(port);
			return true;
		}

		return false;
	}

	protected bool RegisterRxDevice(in string hashKey)
	{
		if (PrepareDevice(hashKey, out ushort port, out ulong hash))
		{
			SetHashForSubscription(hash);
			InitializeSubscriber(port);
			return 	true;
		}

		return true;
	}

	protected bool RegisterServiceDevice(in string hashKey)
	{
		if (PrepareDevice(hashKey, out ushort port, out ulong hash))
		{
			SetHashForResponse(hash);
			InitializeResponsor(port);

			return true;
		}

		return true;
	}

	protected bool RegisterClientDevice(in string hashKey)
	{
		if (PrepareDevice(hashKey, out ushort port, out ulong hash))
		{
			SetHashForRequest(hash);
			InitializeRequester(port);
			return true;
		}

		return true;
	}

	void Awake()
	{
		parameters = new PluginParameters();
		threadList = new List<Thread>();

		var coreObject = GameObject.Find("Core");

		if (coreObject == null)
		{
			Debug.LogError("Failed to Find 'Core'!!!!");
		}
		else
		{
			bridgePortManager = coreObject.GetComponent<BridgePortManager>();
			if (bridgePortManager == null)
			{
				Debug.LogError("Failed to get 'bridgePortManager'!!!!");
			}

			if (string.IsNullOrEmpty(modelName))
			{
				modelName = DeviceHelper.GetModelName(gameObject);
			}
		}

		OnAwake();
	}

	// Start is called before the first frame update
	void Start()
	{
		// PrintPluginData();

		OnStart();

		StartThreads();
	}

	public void Reset()
	{
		OnReset();
	}

	protected static void ClearMemoryStream(ref MemoryStream ms)
	{
		if (ms != null)
		{
			if (ms != null)
			{
				ms.SetLength(0);
				ms.Position = 0;
				ms.Capacity = 0;
			}
		}
	}
}