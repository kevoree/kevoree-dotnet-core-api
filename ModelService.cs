using System;
using org.kevoree;
using Org.Kevoree.Core.Api.Handler;
using org.kevoree.modeling.api.trace;

namespace Org.Kevoree.Core.Api
{
	public interface ModelService
	{
		UUIDModel getCurrentModel ();

		ContainerRoot getPendingModel ();

		void compareAndSwap (ContainerRoot model, Guid uuid, UpdateCallback callback);

		void update (ContainerRoot model, UpdateCallback callback);

		void registerModelListener (ModelListener listener);

		void unregisterModelListener (ModelListener listener);

		void acquireLock (LockCallBack callBack, long timeout);

		void releaseLock (Guid uuid);

		string getNodeName ();


		void submitScript (string script, UpdateCallback callback);

		void submitSequence (TraceSequence sequence, UpdateCallback callback);
	}
}

