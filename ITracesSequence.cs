using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using org.kevoree.pmodeling.api.trace;

namespace Org.Kevoree.Core.Api
{
    public interface ITracesSequence
    {
        List<IModelTraceMarshalled> GetTraces();
    }
}
