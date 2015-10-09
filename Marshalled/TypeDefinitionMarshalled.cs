using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Org.Kevoree.Core.Api.IMarshalled;

namespace Org.Kevoree.Core.Marshalled
{
    class TypeDefinitionMarshalled: MarshalByRefObject, ITypeDefinitionMarshalled
    {
        private readonly org.kevoree.TypeDefinition typeDefinition;

        public TypeDefinitionMarshalled(org.kevoree.TypeDefinition typeDefinition)
        {
            this.typeDefinition = typeDefinition;
        }

        public string getVersion()
        {
            return this.typeDefinition.getVersion();
        }

        public string getName()
        {
            return this.typeDefinition.getName();
        }
    }
}
