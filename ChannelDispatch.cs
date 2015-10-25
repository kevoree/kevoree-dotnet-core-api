using System;

namespace Org.Kevoree.Core.Api
{
	public interface ChannelDispatch
	{
		void dispatch (string payload, Callback callback);
	    void registerPort(Port p);
	    void removePort(Port p);
	}
}