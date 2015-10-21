using System;
using org.kevoree;
using Org.Kevoree.Core.Api.IMarshalled;

namespace Org.Kevoree.Core.Api
{
	public interface UUIDModel
	{
		Guid getUUID();

		IContainerRootMarshalled getModel();
	}

}

