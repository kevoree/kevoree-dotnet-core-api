using System;

namespace Org.Kevoree.Core.Api
{
	public interface Context
	{
		string getPath ();

		string getNodeName ();

		string getInstanceName ();
	}
}