using System;
using org.kevoree;

namespace Org.Kevoree.Core.Api.Handler
{
	public class UpdateContext
	{
		public UpdateContext (ContainerRoot currentModel, ContainerRoot proposedModel, String callerPath)
		{
			this.currentModel = currentModel;
			this.proposedModel = proposedModel;
			this.callerPath = callerPath;
		}

		protected ContainerRoot currentModel;

		protected ContainerRoot proposedModel;

		protected String callerPath;

		public ContainerRoot getCurrentModel ()
		{
			return currentModel;
		}

		public ContainerRoot getProposedModel ()
		{
			return proposedModel;
		}

		public String getCallerPath ()
		{
			return callerPath;
		}
	}


}

