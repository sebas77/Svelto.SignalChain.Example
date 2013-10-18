using UnityEngine;
using Svelto.Communication.SignalChain;

public class Capsule : MonoBehaviour 
{
	BubbleSignal<Cube> _bubbleSignal;
	
	void Awake()
	{
		_bubbleSignal = new BubbleSignal<Cube>(this.transform);
	}		
	
	void OnMouseDown()
	{
		_bubbleSignal.Dispatch(new BetterEvent(Color.blue));
	}
}
