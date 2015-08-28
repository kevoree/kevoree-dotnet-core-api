using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Org.Kevoree.Core.Api
{
    public class AdaptationPrimitive
    {
        private string primitiveType;
        private string targetNodeName;
        private object _ref;

        public string getPrimitiveType() {
            return primitiveType;
        }

        public void setPrimitiveType(string primitiveType) {
            this.primitiveType = primitiveType;
        }

        public string getTargetNodeName() {
            return targetNodeName;
        }

        public void setTargetNodeName(string targetNodeName) {
            this.targetNodeName = targetNodeName;
        }

        public object getRef() {
            return _ref;
        }

        public void setRef(Object _ref) {
            this._ref = _ref;
        }
    }
}
