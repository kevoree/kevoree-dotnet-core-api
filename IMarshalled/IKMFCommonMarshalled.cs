using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Org.Kevoree.Core.Api.IMarshalled
{
    public interface IKMFCommonMarshalled
    {
        bool isOfType(Type t);
        IKMFContainerMarshalled eContainer();
        string getRefInParent();
        string path();
        string serialize();
        IKMFContainerMarshalled CastToKFMContainer();
    }
}
