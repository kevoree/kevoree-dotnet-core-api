using System;
using org.kevoree;
using Org.Kevoree.Core.Api.IMarshalled;

namespace Org.Kevoree.Core.Api.Handler
{
    [Serializable]
	public class UpdateContext
	{
		public UpdateContext (IContainerRootMarshalled currentModel, IContainerRootMarshalled proposedModel, String callerPath)
		{
			this.currentModel = currentModel;
			this.proposedModel = proposedModel;
			this.callerPath = callerPath;
		}

		protected IContainerRootMarshalled currentModel;

        protected IContainerRootMarshalled proposedModel;

		protected String callerPath;

        public IContainerRootMarshalled getCurrentModel()
		{
			return currentModel;
		}

        public IContainerRootMarshalled getProposedModel()
		{
			return proposedModel;
		}

		public String getCallerPath ()
		{
			return callerPath;
		}
	}


}

