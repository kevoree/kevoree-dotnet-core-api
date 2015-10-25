﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using org.kevoree;

namespace Org.Kevoree.Core.Api.IMarshalled
{
    public interface IContainerNodeMarshalled : IKMFCommonMarshalled
    {
        ContainerNode getDelegate();
        string getName();
        IContainerNodeMarshalled getHost();
    }
}
