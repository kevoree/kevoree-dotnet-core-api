using System;

namespace Org.Kevoree.Core.Api
{
	public class CallbackResult
	{
		private string originPortPath;

		private string originChannelPath;

		private string payload;

		public string getOriginPortPath ()
		{
			return originPortPath;
		}

		public void setOriginPortPath (string originPortPath)
		{
			this.originPortPath = originPortPath;
		}

		public string getOriginChannelPath ()
		{
			return originChannelPath;
		}

		public void setOriginChannelPath (string originChannelPath)
		{
			this.originChannelPath = originChannelPath;
		}

		public string getPayload ()
		{
			return payload;
		}

		public void setPayload (string payload)
		{
			this.payload = payload;
		}
	}
}