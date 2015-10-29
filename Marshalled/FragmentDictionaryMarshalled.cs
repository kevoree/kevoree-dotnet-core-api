using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Org.Kevoree.Core.Api;
using Org.Kevoree.Core.Api.IMarshalled;
using org.kevoree;

namespace Org.Kevoree.Core.Marshalled
{
    class FragmentDictionaryMarshalled: MarshalByRefObject, IFragmentDictionaryMarshalled
    {
        private org.kevoree.FragmentDictionary fragmentDictionary;

        public FragmentDictionaryMarshalled(org.kevoree.FragmentDictionary fragmentDictionary)
        {
            this.fragmentDictionary = fragmentDictionary;
        }

        public string serialize()
        {
            var kf = new org.kevoree.factory.DefaultKevoreeFactory();
            return kf.createJSONSerializer().serialize(this.fragmentDictionary);
        }

        public string getName()
        {
            return this.fragmentDictionary.getName();
        }

        public bool isOfType(Type t)
        {
            return t.IsAssignableFrom(this.fragmentDictionary.GetType());
        }

        public IKMFContainerMarshalled eContainer()
        {
            return new KMFContainerMarshalled(this.fragmentDictionary.eContainer());
        }

        public string getRefInParent()
        {
            return this.fragmentDictionary.getRefInParent();
        }

        public string path()
        {
            return this.fragmentDictionary.path();
        }

        public IKMFContainerMarshalled CastToKFMContainer()
        {
            return new KMFContainerMarshalled(this.fragmentDictionary);
        }

        public List<IValueMarshalled> getValues()
        {
            var ret = new List<IValueMarshalled>();
            var itt = this.fragmentDictionary.getValues().iterator();
            while (itt.hasNext())
            {
                ret.Add(new ValueMarshalled((Value)itt.next()));
            }
            return ret;
        }

        public IValueMarshalled findValuesByID(string p)
        {
            return new ValueMarshalled(this.fragmentDictionary.findValuesByID(p));
        }
    }
}
