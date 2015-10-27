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
        void attachOutputPort(Port port, string fieldName);

        void attachInputPort(Port port);

        void detachInputPort(Port port);

        /** call a channel from an OutputPort */
        void sendThroughInputPort(string value, string fieldName);

        void dispatch(string payload, Callback callback); // , string methodName
    }
}
