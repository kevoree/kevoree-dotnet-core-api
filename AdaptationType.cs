using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Org.Kevoree.Core.Api
{
    public enum AdaptationType
    {
        AddDeployUnit = 1,
        RemoveDeployUnit = 2,
        UpdateInstance =3,
        UpdateBinding = 4,
        UpdateDictionaryInstance =5,
        AddInstance = 6,
        RemoveInstance = 7,
        AddBinding = 8,
        RemoveBinding = 9,
        StartInstance = 10,
        StopInstance = 11,
        LinkDeployUnit = 12,
        UpdateCallMethod = 13,
        UpgradeInstance = 14
    }
}
