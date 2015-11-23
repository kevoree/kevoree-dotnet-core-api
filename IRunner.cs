using Org.Kevoree.Core.Api.IMarshalled;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Org.Kevoree.Core.Api
{
    public interface IRunner
    {
        void setPluginPath(string pluginPath);
        void setPackageName(string packageName);
        void setPackageVersion(string packageVersion);
        bool updateDictionary(IDictionaryAttributeMarshalled attribute, IValueMarshalled value);

    }
}
