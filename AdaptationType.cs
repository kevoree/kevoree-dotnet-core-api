using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Org.Kevoree.Core.Api
{
    public enum AdaptationType
    {
        AddDeployUnit,
        RemoveDeployUnit,
        UpdateInstance,
        UpdateBinding,
        UpdateDictionaryInstance,
        AddInstance,
        RemoveInstance,
        AddBinding,
        RemoveBinding,
        StartInstance,
        StopInstance,
        LinkDeployUnit,
        UpdateCallMethod,
        UpgradeInstance
    }
}
