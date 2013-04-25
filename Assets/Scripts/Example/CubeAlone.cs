using UnityEngine;
using Svelto.Communication.SignalChain;

public class CubeAlone : MonoBehaviour 
{
	public Transform root;
	SignalChain _chain;
	
	void Awake()
	{
		_chain = new SignalChain(root);
	}
	
	void OnMouseDown()
	{
		_chain.Broadcast("event");
		
		_chain.Broadcast(new BetterEvent(Color.green));
	}
}
