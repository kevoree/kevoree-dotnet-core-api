using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Org.Kevoree.Core.Api.IMarshalled;

namespace Org.Kevoree.Core.Api.Marshalled
{
    public class DictionaryTypeMarshalled: MarshalByRefObject, IDictionaryTypeMarshalled
    {
        private org.kevoree.DictionaryType dc;

        public DictionaryTypeMarshalled(org.kevoree.DictionaryType dc)
        {
            
            this.dc = dc;
        }

        public IDictionaryAttributeMarshalled findAttributesByID(string key)
        {
            return new DictionaryAttributeMarshalled(dc.findAttributesByID(key));
        }
    }
}
