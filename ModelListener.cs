using System;
using org.kevoree;

namespace Org.Kevoree.Core.Api.Handler
{
	public interface ModelListener
	{
		/**
     * Method called before Kevoree Core accept an input model. Synchronized this methods is not suppose to block
     *
     * @param context
     * @return
     */
		bool preUpdate (UpdateContext context);

		/**
     * Method called to prepare the core to be update. Synchronized this methods can bloc Kevoree core
     *
     * @param context
     * @return
     */
		bool initUpdate (UpdateContext context);

		/* Method called after the local update of the runtime. Synchronized this method can bloc Kevoree core and must return true if update is accepted or not if there is any failure  */
		bool afterLocalUpdate (UpdateContext context);

		/**
     * Method called asynchronisly after a model update
     */
		void modelUpdated ();


		void preRollback (UpdateContext context);

		void postRollback (UpdateContext context);

	}

}

