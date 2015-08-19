using System;
using org.kevoree;

namespace Org.Kevoree.Core.Api
{
	public interface UUIDModel
	{
		Guid getUUID();

		ContainerRoot getModel();
	}

}

