using System;

namespace Svelto.Communication.SignalChain
{
	public interface IChainListener
	{
		void Listen<T>(T message);
	}
}

