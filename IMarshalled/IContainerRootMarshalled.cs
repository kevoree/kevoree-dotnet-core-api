﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Org.Kevoree.Core.Api.IMarshalled
{
    public interface IContainerRootMarshalled : IKMFCommonMarshalled
    {
        IContainerNodeMarshalled findNodesByID(string str);
        IKMFContainerMarshalled findByPath(string path);
        bool isReadOnly();
        void setGenerated_KMF_ID(string id);
    }
}
