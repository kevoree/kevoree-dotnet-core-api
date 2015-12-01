using Org.Kevoree.Core.Api.IMarshalled;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using org.kevoree;
using Org.Kevoree.Core.Marshalled;

namespace Org.Kevoree.Core.Api.Marshalled
{
    class NetworkInforMarshalled : MarshalByRefObject, INetworkInfoMarshalled
    {
        private NetworkInfo deleg;

        public NetworkInforMarshalled(NetworkInfo list)
        {
            this.deleg = list;
        }

        public bool isOfType(Type t)
        {
            return t.IsAssignableFrom(deleg.GetType());
        }

        public IKMFContainerMarshalled eContainer()
        {
            return new KMFContainerMarshalled(deleg.eContainer());
        }

        public string getRefInParent()
        {
            return this.deleg.getRefInParent();
        }

        public string path()
        {
            return this.path();
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

        public List<IValueMarshalled> getValues()
        {
            var itt = this.deleg.getValues().iterator();
            var ret = new List<IValueMarshalled>();
            while (itt.hasNext())
            {
                ret.Add(new ValueMarshalled((Value)itt.next()));
            }
            return ret;
        }

        public string getName()
        {
            return deleg.getName();
        }
    }
}
