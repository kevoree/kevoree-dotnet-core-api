using org.kevoree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Org.Kevoree.Core.Api
{
    public interface BootstrapService
    {

        INodeRunner createInstance(ContainerNode nodeInstance);

        IComponentRunner LoadSomething(string name, string version, string path);
    }
}
