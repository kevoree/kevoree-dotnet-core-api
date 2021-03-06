﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using org.kevoree;
using Org.Kevoree.Core.Api.IMarshalled;
using Org.Kevoree.Core.Marshalled;

namespace Org.Kevoree.Core.Api.Marshalled
{
    public class ComponentInstanceMarshalled: MarshalByRefObject, IComponentInstanceMarshalled
    {

        private readonly ComponentInstance deleg;

        public ComponentInstanceMarshalled(ComponentInstance component)
        {
            this.deleg = component;

        }

        public string getName()
        {
            return this.deleg.getName();
        }

        public bool isOfType(Type t)
        {

            return t.IsAssignableFrom(this.deleg.GetType());
        }

        public IKMFContainerMarshalled eContainer()
        {
            return new KMFContainerMarshalled(this.deleg.eContainer());
        }

        public string getRefInParent()
        {
            return this.deleg.getRefInParent();
        }

        public string path()
        {
            return this.deleg.path();
        }

        public IKMFContainerMarshalled CastToKFMContainer()
        {
            return new KMFContainerMarshalled(this.deleg);
        }

        public string serialize()
        {
            var kf = new org.kevoree.factory.DefaultKevoreeFactory();
            return kf.createJSONSerializer().serialize(this.deleg);
        }

        public ITypeDefinitionMarshalled GetTypeDefinition()
        {
            return new TypeDefinitionMarshalled(this.deleg.getTypeDefinition());
        }

        public IDictionaryMarshalled getDictionary()
        {
            if (this.deleg.getDictionary() != null)
            {
                return new DictionaryMarshalled(this.deleg.getDictionary());
            }
            else { return null;}
        }

        
        public List<IFragmentDictionaryMarshalled> getFragmentDictionary()
        {
            var fragments = this.deleg.getFragmentDictionary();
            var itt = fragments.iterator();
            var ret = new List<IFragmentDictionaryMarshalled>();
            while (itt.hasNext())
            {
                var fd = (FragmentDictionary) itt.next();
                ret.Add(new FragmentDictionaryMarshalled(fd));
            }
            return ret;
        }

        public IPortMarshalled findProvidedByID(string id)
        {
            var result = this.deleg.findProvidedByID(id);
            if (result != null)
            {
                return new PortMarshalled(result);
            }
            else
            {
                return null;
            }
        }
    }
}
