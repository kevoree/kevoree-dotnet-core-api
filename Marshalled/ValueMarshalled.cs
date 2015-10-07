using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Org.Kevoree.Core.Api.IMarshalled;

namespace Org.Kevoree.Core.Marshalled
{
    class ValueMarshalled: MarshalByRefObject, IValueMarshalled
    {
        private org.kevoree.Value valueMarshalled;

        public ValueMarshalled(org.kevoree.Value valueMarshalled)
        {
            this.valueMarshalled = valueMarshalled;
        }

        public bool isOfType(Type t)
        {
            return t.IsAssignableFrom(this.valueMarshalled.GetType());
        }

        public IKMFContainerMarshalled eContainer()
        {
            return new KMFContainerMarshalled(this.valueMarshalled.eContainer());
        }

        public string getRefInParent()
        {
            return this.valueMarshalled.getRefInParent();
        }

        public string path()
        {
            return this.valueMarshalled.path();
        }

        public IKMFContainerMarshalled CastToKFMContainer()
        {
            return new KMFContainerMarshalled(this.valueMarshalled);
        }
    }
}
