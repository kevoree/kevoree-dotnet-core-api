using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Org.Kevoree.Core.Api;
using Org.Kevoree.Core.Api.IMarshalled;

namespace Org.Kevoree.Core.Marshalled
{
    class InstanceMarshalled : MarshalByRefObject, IInstanceMarshalled
    {
        private org.kevoree.Instance instance;

        public InstanceMarshalled(org.kevoree.Instance instance)
        {
            this.instance = instance;
        }

        public bool isOfType(Type t)
        {
            return t.IsAssignableFrom(this.instance.GetType());
        }

        public string getName()
        {
            return this.instance.getName();
        }

        public string path()
        {
            return this.instance.path();
        }

        public IKMFContainerMarshalled eContainer()
        {
            return  new KMFContainerMarshalled(this.instance.eContainer());
        }

        public string getRefInParent()
        {
            return this.instance.getRefInParent();
        }

        public IKMFContainerMarshalled CastToKFMContainer()
        {
            return new KMFContainerMarshalled(this.instance);
        }

        public ITypeDefinitionMarshalled GetTypeDefinition()
        {
            return new TypeDefinitionMarshalled(this.instance.getTypeDefinition());
        }
    }
}
