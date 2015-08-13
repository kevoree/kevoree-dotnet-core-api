using System;

namespace  Org.Kevoree.Core.Api
{
	public interface Port
	{

		void send (string payload, Callback callback);

		string getPath ();

		int getConnectedBindingsSize ();
	}
}