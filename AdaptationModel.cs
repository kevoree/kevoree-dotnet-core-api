using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Org.Kevoree.Core.Api;

namespace Org.Kevoree.Core.Api.Adaptation
{
    [Serializable]
    public class AdaptationModel : MarshalByRefObject
    {

        private SortedSet<AdaptationPrimitive> deriv = new SortedSet<AdaptationPrimitive>();
        
        public bool Add(AdaptationPrimitive item)
        {
            return deriv.Add(item);
        }

        public SortedSet<AdaptationPrimitive> ToArray()
        {
            return this.deriv;
        }

        public override string ToString()
        {
            return "AdaptationModel [\n" + String.Join(",\n", this.deriv) + "\n]";
        }

    }
}
