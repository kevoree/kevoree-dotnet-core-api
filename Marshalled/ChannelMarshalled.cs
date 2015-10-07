using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using org.kevoree;
using Org.Kevoree.Core.Api;
using Org.Kevoree.Core.Api.IMarshalled;

namespace Org.Kevoree.Core.Marshalled
{
    class ChannelMarshalled : MarshalByRefObject, IChannelMarshalled
    {
        private org.kevoree.Channel channel;

        public ChannelMarshalled(org.kevoree.Channel channel)
        {
            this.channel = channel;
        }

        public bool isOfType(Type t)
        {
            return t.IsAssignableFrom(this.channel.GetType());
        }

        public IKMFContainerMarshalled eContainer()
        {
            
            return new KMFContainerMarshalled(this.channel.eContainer());
        }

        public string getRefInParent()
        {
            return this.channel.getRefInParent();
        }

        public string path()
        {
            return this.channel.path();
        }

        public IKMFContainerMarshalled CastToKFMContainer()
        {
            return new KMFContainerMarshalled(this.channel);
        }
    }
}
