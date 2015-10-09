using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Org.Kevoree.Core.Api
{
    public interface IComponentRunner : IRunner
    {
        bool Run();
    }
}
