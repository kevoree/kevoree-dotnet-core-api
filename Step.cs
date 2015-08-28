using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Org.Kevoree.Core.Api;

namespace Org.Kevoree.Core.Api.Adaptation
{
    public class Step
    {
        private List<AdaptationPrimitive> adaptations = new List<AdaptationPrimitive>();
        private Step nextStep;
        private AdaptationType adaptationType;

        public List<AdaptationPrimitive> getAdaptations()
        {
            return adaptations;
        }

        public void setAdaptations(List<AdaptationPrimitive> adaptations)
        {
            this.adaptations = adaptations;
        }

        public Step getNextStep()
        {
            return nextStep;
        }

        public void setNextStep(Step nextStep)
        {
            this.nextStep = nextStep;
        }

        public AdaptationType getAdaptationType()
        {
            return adaptationType;
        }

        public void setAdaptationType(AdaptationType adaptationType)
        {
            this.adaptationType = adaptationType;
        }
    }
}
