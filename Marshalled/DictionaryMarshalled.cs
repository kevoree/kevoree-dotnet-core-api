using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using org.kevoree;
using Org.Kevoree.Core.Api.IMarshalled;
using Org.Kevoree.Core.Marshalled;

namespace Org.Kevoree.Core.Api.Marshalled
{
    class DictionaryMarshalled: MarshalByRefObject, IDictionaryMarshalled
    {
        private org.kevoree.Dictionary deleg;

        public DictionaryMarshalled(org.kevoree.Dictionary deleg)
        {
            this.deleg = deleg;
        }

        public List<IValueMarshalled> getValues()
        {
            var ret = new List<IValueMarshalled>();
            var itt = this.deleg.getValues().iterator();
            while (itt.hasNext())
            {
               ret.Add(new ValueMarshalled((Value)itt.next())); 
            }
            return ret;
        }

        public bool isOfType(Type t)
        {
            return t.IsAssignableFrom(this.deleg.GetType());
        }

        public IKMFContainerMarshalled eContainer()
        {
            return  new KMFContainerMarshalled(this.deleg.eContainer());
        }

        public string getRefInParent()
        {
            return this.deleg.getRefInParent();
        }

        public string path()
        {
            return this.deleg.path();
        }

        public string serialize()
        {
            var kf = new org.kevoree.factory.DefaultKevoreeFactory();
            return kf.createJSONSerializer().serialize(this.deleg);
        }

        public IKMFContainerMarshalled CastToKFMContainer()
        {
            return new KMFContainerMarshalled(this.deleg);
        }
    }
}