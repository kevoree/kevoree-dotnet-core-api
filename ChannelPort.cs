using System;
using System.Collections.Generic;

namespace Org.Kevoree.Core.Api
{
	public interface ChannelPort
	{
	    void addInputPort(Port p);
	    void removeInputPort(Port p);
	}
}