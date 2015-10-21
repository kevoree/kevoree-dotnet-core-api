using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using org.kevoree;
using org.kevoree.impl;
using Org.Kevoree.Core.Api;
using Org.Kevoree.Core.Api.IMarshalled;
using Org.Kevoree.Core.Api.Marshalled;

namespace Org.Kevoree.Core.Marshalled
{
    class ChannelMarshalled : MarshalByRefObject, IChannelMarshalled
    {
        private org.kevoree.Channel channel;

        public ChannelMarshalled(org.kevoree.Channel channel)
        {
            this.channel = channel;
        }

        public bool getStarted()
        {
            return this.channel.getStarted().booleanValue();
        }

        public List<IFragmentDictionaryMarshalled> getFragmentDictionary()
        {
            var ret = new List<IFragmentDictionaryMarshalled>();
            var itt = channel.getFragmentDictionary().iterator();
            while (itt.hasNext())
            {
                ret.Add(new FragmentDictionaryMarshalled((FragmentDictionary)itt.next()));
            }
            return ret;
        }

        public List<IMBindingMarshalled> getBindings()
        {
            var ret = new List<IMBindingMarshalled>();
            var itt = channel.getBindings().iterator();
            while (itt.hasNext())
            {
                ret.Add(new MBindingMarshalled((MBinding)itt.next()));
            }
            return ret;
        }


        public bool isOfType(Type t)
        {
            return t.IsAssignableFrom(this.channel.GetType());
        }

        public string serialize()
        {
            var kf = new org.kevoree.factory.DefaultKevoreeFactory();
            return kf.createJSONSerializer().serialize(this.channel);
        }

        public IKMFContainerMarshalled eContainer()
        {

            return new KMFContainerMarshalled(this.channel.eContainer());
        }

        public string getRefInParent()
        {
            return this.channel.getRefInParent();
        }

        public string path()
        {
            return this.channel.path();
        }

        public IKMFContainerMarshalled CastToKFMContainer()
        {
            return new KMFContainerMarshalled(this.channel);
        }

        public ITypeDefinitionMarshalled GetTypeDefinition()
        {
            return new TypeDefinitionMarshalled(this.channel.getTypeDefinition());
        }

        public IDictionaryMarshalled getDictionary()
        {
            if (this.channel.getDictionary() != null)
            {
                return new DictionaryMarshalled(this.channel.getDictionary());
            }
            else { return null; }
        }

        public string getName()
        {
            return this.channel.getName();
        }
    }
}
