using UnityEngine;
using System.Collections;
using Svelto.Communication.SignalChain;

public class Sphere : MonoBehaviour, IChainListener
{
	public void Listen<T>(T message)
	{
		if (message is BetterEvent)
		{
			this.transform.renderer.material.color = (message as BetterEvent).color;
		}
	}
}
