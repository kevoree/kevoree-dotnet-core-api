using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using org.kevoree;
using Org.Kevoree.Core.Api;
using Org.Kevoree.Core.Api.IMarshalled;

namespace Org.Kevoree.Core.Marshalled
{
    class ContainerNodeMarshalled : MarshalByRefObject, IContainerNodeMarshalled
    {
        private readonly org.kevoree.ContainerNode _containerNode;

        public ContainerNode getDelegate()
        {    
            return _containerNode;
        }

        public string getName()
        {
            return this._containerNode.getName();
        }

        public ContainerNodeMarshalled(org.kevoree.ContainerNode containerNode)
        {
            this._containerNode = containerNode;
        }

        public string path()
        {
            if (this._containerNode == null) return null;
            return this._containerNode.path();
        }


        public string serialize()
        {
            var kf = new org.kevoree.factory.DefaultKevoreeFactory();
            return kf.createJSONSerializer().serialize(this._containerNode);
        }

        public bool isOfType(Type t)
        {
            return t.IsAssignableFrom(this._containerNode.GetType());
        }

        public IKMFContainerMarshalled eContainer()
        {
            return new KMFContainerMarshalled(this._containerNode.eContainer());
        }

        public string getRefInParent()
        {
            return this._containerNode.getRefInParent();
        }

        public IKMFContainerMarshalled CastToKFMContainer()
        {
            return new KMFContainerMarshalled(this._containerNode);
        }

        public IContainerNodeMarshalled getHost()
        {
            return new ContainerNodeMarshalled(this._containerNode.getHost());
        }
    }
}
