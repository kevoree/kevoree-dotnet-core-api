using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using java.lang;
using Org.Kevoree.Core.Api.IMarshalled;
using Object = System.Object;

namespace Org.Kevoree.Core.Api
{
    public class AdaptationPrimitive : MarshalByRefObject, IComparable
    {
        private AdaptationType Type;
        private string NodePath;
        private IKMFContainerMarshalled _ref;
        private IKMFContainerMarshalled _ref2;

        public AdaptationType getType()
        {
            return Type;
        }

        public void setType(AdaptationType Type)
        {
            this.Type = Type;
        }

        public string getNodePath()
        {
            return NodePath;
        }

        public void setNodePath(string NodePath)
        {
            this.NodePath = NodePath;
        }

        public IKMFContainerMarshalled getRef()
        {
            return _ref;
        }

        public void setRef(IKMFContainerMarshalled _ref)
        {
            this._ref = _ref;
        }

        public IKMFContainerMarshalled getRef2()
        {
            return _ref2;
        }

        public void setRef2(IKMFContainerMarshalled _ref2)
        {
            this._ref2 = _ref2;
        }

        public override int GetHashCode()
        {
            if (this._ref2 != null)
            {
                return Type.GetHashCode() ^ NodePath.GetHashCode() ^ _ref.GetHashCode() ^ _ref2.GetHashCode();
            }
            else { return Type.GetHashCode() ^ NodePath.GetHashCode() ^ _ref.GetHashCode(); }
        }

        public override bool Equals(object obj)
        {
            if (obj is AdaptationPrimitive)
            {
                var a = Tuple.Create(this.Type, this.NodePath, this._ref, this._ref2);
                var that = (AdaptationPrimitive) obj;
                var b = Tuple.Create(that.Type, that.NodePath, that._ref, that._ref2);
                return a.Equals(b);
            }
            throw new IllegalArgumentException();
        }

        public override string ToString()
        {
            return "AdaptationPrimitive [Type = " + Type + " ; NodePath = " + NodePath + " ; Ref = " + _ref + "; Ref2 = " + _ref2 + "]";
        }

        public int CompareTo(object obj)
        {
            if (obj is AdaptationPrimitive)
            {
                var t1 = this.Type;
                var n1 = this.NodePath;
                var t2 = ((AdaptationPrimitive)obj).Type;
                var n2 = ((AdaptationPrimitive)obj).NodePath;
                if (t1.CompareTo(t2) != 0) return t1.CompareTo(t2);
                return n1.CompareTo(n2);
            }
            throw new IllegalArgumentException();
        }

    }
}
