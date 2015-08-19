using System;
using org.kevoree;

namespace Org.Kevoree.Core.Api
{
	public interface UpdateCallback
	{
		void run(bool applied);
	}

}

