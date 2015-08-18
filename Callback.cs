using System;

namespace Org.Kevoree.Core.Api
{
	public interface Callback
	{
		/**
     	 * @param result content of the answer (originChannelPath: name of the channel who forwarded the answer, originPortPath: path of the port who answered the call)
     	 */
		void onSuccess (CallbackResult result);

		/**
     	 * @param exception
     	 */
		void onError (Exception exception);
	}

}