using System;

namespace Org.Kevoree.Core.Api
{
	public interface ChannelDispatch
	{
		void dispatch (string payload, Callback callback);
	}
}