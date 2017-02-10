using org.kevoree;
using Org.Kevoree.Core.Api.Adaptation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using org.kevoree.pmodeling.api.trace;
using Org.Kevoree.Core.Api;
using Org.Kevoree.Core.Api.Command;
using Org.Kevoree.Core.Api.IMarshalled;

namespace Org.Kevoree.Core.Api
{
    public interface NodeType
    {
        AdaptationModel plan(IContainerRootMarshalled current, IContainerRootMarshalled target, ITracesSequence traces);

        ICommand getPrimitive(AdaptationPrimitive primitive);

        void Start();
    }
}
