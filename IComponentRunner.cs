using Org.Kevoree.Core.Api.IMarshalled;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Org.Kevoree.Core.Api
{
    public interface IComponentRunner : IRunner
    {
        bool Run();
        bool Stop();
        

        /** Inject an PortOutput to a component */
        void attacheOutputPort(Port port, string fieldName);

        /** call a channel from an OutputPort */
        void sendThroughInputPort(string value, string fieldName);
    }
}
