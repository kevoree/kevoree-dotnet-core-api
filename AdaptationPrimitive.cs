using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using java.lang;
using Object = System.Object;

namespace Org.Kevoree.Core.Api
{
    public class AdaptationPrimitive: MarshalByRefObject, IComparable
    {
        private AdaptationType Type;
        private string NodePath;
        private object _ref;

        public AdaptationType getType()
        {
            return Type;
        }

        public void setType(AdaptationType Type) {
            this.Type = Type;
        }

        public string getNodePath() {
            return NodePath;
        }

        public void setNodePath(string NodePath) {
            this.NodePath = NodePath;
        }

        public object getRef() {
            return _ref;
        }

        public void setRef(Object _ref) {
            this._ref = _ref;
        }

        public override int GetHashCode()
        {
            return Type.GetHashCode() ^ NodePath.GetHashCode() ^ _ref.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj is AdaptationPrimitive)
            {
                var a = Tuple.Create(this.Type, this.NodePath);
                var b = Tuple.Create(((AdaptationPrimitive)obj).Type, ((AdaptationPrimitive)obj).NodePath);
                return  a.Equals(b);
            }
            throw new IllegalArgumentException();
        }

        public int CompareTo(object obj)
        {
            if (obj is AdaptationPrimitive)
            {
                //Tuple<AdaptationType, string>
                var t1 = this.Type;
                var n1 = this.NodePath;
                var t2 = ((AdaptationPrimitive) obj).Type;
                var n2 = ((AdaptationPrimitive)obj).NodePath;
                if (t1.CompareTo(t2) != 0) return t1.CompareTo(t2);
                return n1.CompareTo(n2);
            }
            throw new IllegalArgumentException();
        }

    }
}
