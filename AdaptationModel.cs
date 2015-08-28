using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Org.Kevoree.Core.Api;

namespace Org.Kevoree.Core.Api.Adaptation
{
    public class AdaptationModel
    {
        private List<AdaptationPrimitive> adaptations = new List<AdaptationPrimitive>();
        private Step orderedPrimitiveSet;


        public List<AdaptationPrimitive> getAdaptations()
        {
            return adaptations;
        }

        public void setAdaptations(List<AdaptationPrimitive> adaptations)
        {
            this.adaptations = adaptations;
        }

        public Step getOrderedPrimitiveSet()
        {
            return orderedPrimitiveSet;
        }

        public void setOrderedPrimitiveSet(Step orderedPrimitiveSet)
        {
            this.orderedPrimitiveSet = orderedPrimitiveSet;
        }
    }
}
