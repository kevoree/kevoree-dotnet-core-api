using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Org.Kevoree.Core.Api.IMarshalled
{
    public interface IDeployUnitMarshalled : IKMFCommonMarshalled
    {
        string getName();

        string getVersion();

        IValueMarshalled findFiltersByID(string p);
    }
}
