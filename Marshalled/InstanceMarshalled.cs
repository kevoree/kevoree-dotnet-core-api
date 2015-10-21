using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using org.kevoree;
using Org.Kevoree.Core.Api;
using Org.Kevoree.Core.Api.IMarshalled;
using Org.Kevoree.Core.Api.Marshalled;

namespace Org.Kevoree.Core.Marshalled
{
    class InstanceMarshalled : MarshalByRefObject, IInstanceMarshalled
    {
        private org.kevoree.Instance instance;

        public InstanceMarshalled(org.kevoree.Instance instance)
        {
            this.instance = instance;
        }

        public string serialize()
        {
            var kf = new org.kevoree.factory.DefaultKevoreeFactory();
            return kf.createJSONSerializer().serialize(this.instance);
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

        public IDictionaryMarshalled getDictionary()
        {
            if (this.instance.getDictionary() != null)
            {
                return new DictionaryMarshalled(this.instance.getDictionary());
            }
            else
            {
                return null;
            }
        }

        public List<IFragmentDictionaryMarshalled> getFragmentDictionary()
        {
            var fragments = this.instance.getFragmentDictionary();
            var itt = fragments.iterator();
            var ret = new List<IFragmentDictionaryMarshalled>();
            while (itt.hasNext())
            {
                var fd = (FragmentDictionary) itt.next();
                ret.Add(new FragmentDictionaryMarshalled(fd));
            }
            return ret;
        }
    }
}
