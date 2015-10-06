using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using org.kevoree;

namespace Org.Kevoree.Core.Api.IMarshalled
{
    public interface IKMFContainerMarshalled
    {
        bool isOfType(Type t);
        IKMFContainerMarshalled eContainer();
        string getRefInParent();
        string path();
        IMBindingMarshalled getMBinding();
        IInstanceMarshalled getInstance();
        IFragmentDictionaryMarshalled getFragmentDictionary();
    }
}
