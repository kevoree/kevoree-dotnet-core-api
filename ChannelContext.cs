using System;
using System.Collections.Generic;

namespace Org.Kevoree.Core.Api
{
	public interface ChannelContext
	{
		List<Port> getLocalPorts ();

		List<String> getRemotePortPaths ();
	}
}