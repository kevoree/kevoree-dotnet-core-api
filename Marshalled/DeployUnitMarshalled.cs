﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using org.kevoree;
using org.kevoree.pmodeling.api;
using Org.Kevoree.Core.Api.IMarshalled;

namespace Org.Kevoree.Core.Marshalled
{
    class DeployUnitMarshalled: MarshalByRefObject, IDeployUnitMarshalled
    {
        private org.kevoree.DeployUnit deployUnit;

        public DeployUnitMarshalled(org.kevoree.DeployUnit deployUnit)
        {
            this.deployUnit = deployUnit;
        }

        public string serialize()
        {
            var kf = new org.kevoree.factory.DefaultKevoreeFactory();
            return kf.createJSONSerializer().serialize(this.deployUnit);
        }
 
        public bool isOfType(Type t)
        {
            return t.IsAssignableFrom(this.deployUnit.GetType());
        }

        public IKMFContainerMarshalled eContainer()
        {
            return new KMFContainerMarshalled(this.deployUnit);
        }

        public string getRefInParent()
        {
            return this.deployUnit.getRefInParent();
        }

        public string path()
        {
            return this.deployUnit.path();
        }

        public IKMFContainerMarshalled CastToKFMContainer()
        {
            return new KMFContainerMarshalled(this.deployUnit);
        }

        public string getName()
        {
            return this.deployUnit.getName();
        }

        public string getVersion()
        {
            return this.deployUnit.getVersion();
        }

        public IValueMarshalled findFiltersByID(string p)
        {
            return new ValueMarshalled(this.deployUnit.findFiltersByID(p));
        }
    }
}
