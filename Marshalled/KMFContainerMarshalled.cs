using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using org.kevoree;
using org.kevoree.impl;
using Org.Kevoree.Core.Api;
using Org.Kevoree.Core.Api.IMarshalled;
using Org.Kevoree.Core.Api.Marshalled;

namespace Org.Kevoree.Core.Marshalled
{
    class KMFContainerMarshalled : MarshalByRefObject,  IKMFContainerMarshalled
    {
        private readonly  org.kevoree.pmodeling.api.KMFContainer _kMFContainer;

        public string serialize()
        {
            var kf = new org.kevoree.factory.DefaultKevoreeFactory();
            return kf.createJSONSerializer().serialize(this._kMFContainer);
        }

        public IMBindingMarshalled CastToMBinding()
        {
            return new MBindingMarshalled((MBinding)_kMFContainer);
        }

        public IDeployUnitMarshalled CastToDeployUnit()
        {
            return new DeployUnitMarshalled((DeployUnit) this._kMFContainer);
        }

        public IValueMarshalled CastToValue()
        {
            return new ValueMarshalled((Value) this._kMFContainer);
        }

        public IInstanceMarshalled CastToInstance()
        {
            return new InstanceMarshalled((Instance)_kMFContainer);
        }

        public IFragmentDictionaryMarshalled CastToFragmentDictionary()
        {
            return new FragmentDictionaryMarshalled((FragmentDictionary) this._kMFContainer);
        }

        public KMFContainerMarshalled(org.kevoree.pmodeling.api.KMFContainer kMFContainer)
        {
            this._kMFContainer = kMFContainer;
        }

        public bool isOfType(Type t)
        {
            return t.IsAssignableFrom(this._kMFContainer.GetType());
        }

        public IKMFContainerMarshalled eContainer()
        {
            return new KMFContainerMarshalled(this._kMFContainer.eContainer());
        }

        public string getRefInParent()
        {
            return this._kMFContainer.getRefInParent();
        }

        public string path()
        {
            return this._kMFContainer.path();
        }

        public IKMFContainerMarshalled CastToKFMContainer()
        {
            return new KMFContainerMarshalled(this._kMFContainer);
        }

        public IComponentInstanceMarshalled CastToComponentInstance()
        {
            return new ComponentInstanceMarshalled((ComponentInstance) this._kMFContainer);
        }

        public IChannelMarshalled CastToChannel()
        {
            return new ChannelMarshalled((Channel)this._kMFContainer);
        }

        public IGroupMarshalled CastToGroup()
        {
            return  new GroupMarshalled((Group)_kMFContainer);
        }

        public IContainerNodeMarshalled CastToContainerNode()
        {
            var casted = (ContainerNode) this._kMFContainer;
            var ret = new ContainerNodeMarshalled(casted);
            return ret;
        }

        public override string ToString()
        {
            return this._kMFContainer.ToString();
        }
    }
}
