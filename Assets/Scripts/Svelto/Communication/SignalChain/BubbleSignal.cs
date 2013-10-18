using System;
using UnityEngine;

namespace Svelto.Communication.SignalChain
{
	public class BubbleSignal<T>
	{
		SignalChain _signalChain;
				
		public BubbleSignal (Transform node)
		{
			Transform 	root = node;
			
			while (root != null && RootIsFound(root) == false)	
				root = root.parent;
				
			_signalChain = new SignalChain(root == null ? node : root);
		}
		
		//  The notification of type T is broadcasted 
		//	to all the active children of type IChainListener
		
		public void Dispatch<T>()
		{
			_signalChain.Broadcast<T>();
		}
		
		//  The notification of type T is broadcasted 
		//	to all the active children of type IChainListener
		
		public void Dispatch<T>(T notification)
		{
			_signalChain.Broadcast<T>(notification);
		}
		
		//  The notification of type T is broadcasted 
		//	to all the children of type IChainListener
		
		public void DeepDispatch<T>()
		{
			_signalChain.DeepBroadcast<T>();
		}
		
		//  The notification of type T is broadcasted 
		//	to all the children of type IChainListener
		
		public void DeepDispatch<T>(T notification)
		{
			_signalChain.DeepBroadcast<T>(notification);
		}
		
		//  The notification of type T is sent 
		//	to the root components of type IChainListener
		
		public void TargetedDispatch<T>()
		{
			_signalChain.Send<T>();
		}
		
		//  The notification of type T is sent 
		//	to the root components of type IChainListener
		
		public void TargetedDispatch<T>(T notification)
		{
			_signalChain.Send<T>(notification);
		}
		
		private bool RootIsFound(Transform node)
		{
			return Array.FindIndex<Component>(node.GetComponents<Component>(), obj => { 
				return obj is T; 
			}) != -1;
		}
	}
}

