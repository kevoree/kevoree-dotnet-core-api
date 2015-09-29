using org.kevoree;
using Org.Kevoree.Core.Api.Adaptation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Org.Kevoree.Core.Api
{
    public interface NodeType
    {
        AdaptationModel plan(ContainerRoot actualModel, ContainerRoot targetModel);

        PrimitiveCommand getPrimitive(AdaptationPrimitive primitive);

        void Start();
    }
}
