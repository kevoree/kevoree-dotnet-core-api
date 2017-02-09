using System;
using org.kevoree;
using Org.Kevoree.Core.Api.Handler;
using Org.Kevoree.Core.Api.IMarshalled;

namespace Org.Kevoree.Core.Api
{
	public interface ModelService
	{
		UUIDModel getCurrentModel ();

        IContainerRootMarshalled getPendingModel();

        void compareAndSwap(IContainerRootMarshalled model, Guid uuid, UpdateCallback callback);

        void update(IContainerRootMarshalled model, UpdateCallback callback);

		void registerModelListener (ModelListener listener);

		void unregisterModelListener (ModelListener listener);

		void acquireLock (LockCallBack callBack, long timeout);

		void releaseLock (Guid uuid);

		string getNodeName ();


		void submitScript (string script, UpdateCallback callback);

        void submitSequence(org.kevoree.modeling.api.trace.TraceSequence sequence, UpdateCallback callback);
	}
}

