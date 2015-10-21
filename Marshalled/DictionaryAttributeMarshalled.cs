using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Org.Kevoree.Core.Api.Marshalled
{
    public class DictionaryAttributeMarshalled : MarshalByRefObject, IDictionaryAttributeMarshalled
    {
        private org.kevoree.DictionaryAttribute dictionaryAttribute;

        public DictionaryAttributeMarshalled(org.kevoree.DictionaryAttribute dictionaryAttribute)
        {
            this.dictionaryAttribute = dictionaryAttribute;
            
        }

        public string getName()
        {
            return this.dictionaryAttribute.getName();
        }

        public string getDatatype()
        {
            return this.dictionaryAttribute.getDatatype().name();
        }
    }
}
