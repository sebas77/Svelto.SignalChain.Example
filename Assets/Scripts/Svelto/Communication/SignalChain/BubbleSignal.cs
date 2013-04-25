using System;
using UnityEngine;

namespace Svelto.Communication.SignalChain
{
	public class BubbleSignal
	{
		private SignalChain _signalChain;
				
		public BubbleSignal (Transform node)
		{
			Transform 	root = null;
			
			while (node != null)
			{
				if (RootIsFound(node) == true)
				{
					root = node;
					
					break;
				}
				
				node = node.parent;
			}
			
			_signalChain = new SignalChain(root == null ? node : root);
		}
		
		public void Dispatch(Type type)
		{
			_signalChain.Broadcast(type);
		}
		
		public void Dispatch<T>(T notification)
		{
			_signalChain.Broadcast(notification);
		}
		
		private bool RootIsFound(Transform node)
		{
			return Array.FindIndex<MonoBehaviour>(node.GetComponents<MonoBehaviour>(), (obj) => { return obj is IChainRoot; }) != -1;
		}
	}
}

