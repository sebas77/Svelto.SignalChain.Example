using UnityEngine;
using Svelto.Communication.SignalChain;

public class Capsule : MonoBehaviour 
{
	BubbleSignal _bubbleSignal;
	
	void Awake()
	{
		_bubbleSignal = new BubbleSignal(this.transform);
	}		
	
	void OnMouseDown()
	{
		_bubbleSignal.Dispatch(new BetterEvent(Color.blue));
	}
}
