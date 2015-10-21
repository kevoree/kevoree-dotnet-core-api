using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Org.Kevoree.Core.Api
{
    public enum AdaptationType
    {
        StopInstance = 1,
        RemoveBinding = 2,
        RemoveInstance = 3,
        RemoveDeployUnit = 4,
        AddDeployUnit = 5,
        AddInstance = 6,
        AddBinding = 7,
        UpdateDictionary = 8,
        UpdateInstance = 9,
        StartInstance = 10,
        Harakiri = 11
    }
}
