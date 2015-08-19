using System;
using org.kevoree;
using Org.Kevoree.Core.Api.Handler;

namespace Org.Kevoree.Core.Api
{
	public interface LockCallBack
	{
		/**
     * This method is called when a lock has been required on Kevoree Core.
     * If <b>bypassUUID</b> is different than <b>null</b> and <b>error</b> is not true so the lock is correctly acquired and you can use the uuid to apply reconfiguration.
     * @param bypassUUID The uuid which allow to apply reconfiguration.
     * @param error a boolean which explicit if the lock is correctly set
     */
		void run(Guid bypassUUID, Boolean error);
	}

}

