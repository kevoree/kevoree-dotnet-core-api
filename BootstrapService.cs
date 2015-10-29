using org.kevoree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Org.Kevoree.Core.Api.IMarshalled;

namespace Org.Kevoree.Core.Api
{
    public interface BootstrapService
    {

        INodeRunner createInstance(IContainerNodeMarshalled nodeInstance);

        IComponentRunner LoadSomething(string name, string version, string path);
    }
}
