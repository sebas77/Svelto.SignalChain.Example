using UnityEngine;
using Svelto.Communication.SignalChain;

public class CubeAlone : MonoBehaviour 
{
	public Transform root;
	
	void OnMouseDown()
	{
		new SignalChain(root).Broadcast("event");
		
		new SignalChain(root).Broadcast(new BetterEvent(Color.green));
	}
}
