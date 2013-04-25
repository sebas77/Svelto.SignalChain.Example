using UnityEngine;
using System.Collections;
using Svelto.Communication.SignalChain;

public class Cylinder : MonoBehaviour, IChainListener
{
	public void Listen<T>(T message)
	{
		if (message is string && (message as string) == "event")
		{
			this.transform.renderer.material.color = Color.red;
		}
	}
}
