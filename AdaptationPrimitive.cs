using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            String r1 = this._ref != null ? this._ref.path() : "";
            String r2 = this._ref2 != null ? this._ref2.path() : "";

            return Type.GetHashCode() ^ NodePath.GetHashCode() ^ r1.GetHashCode() ^ r2.GetHashCode();
            
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
            throw new java.lang.IllegalArgumentException();
        }

        public override string ToString()
        {

            string ref1str;
            if (_ref == null)
            {
                ref1str = "";
            }
            else
            {
                ref1str = _ref.path();
            }

            string ref2str;
            if (_ref2 == null)
            {
                ref2str = "";
            }
            else
            {
                ref2str = _ref2.path();
            }



            return "AdaptationPrimitive [Type = " + Type + "; RefPath = " + ref1str + "; Ref2Path = " + ref2str + "]";
        }

        public int CompareTo(object obj)
        {
            if (obj is AdaptationPrimitive)
            {
                var that = (AdaptationPrimitive) obj;
                var t1 = this.Type;
                var t2 = that.Type;
                var c1 = t1.CompareTo(t2);
                if (c1 != 0) return c1;

                var r1 = this._ref.path();
                var r2 = that._ref.path();
                var c3 = r1.CompareTo(r2);
                if (c3 != 0) return c3;

                string r21;
                string r22;

                if (this._ref2 != null)
                {
                    r21 = this._ref2.path();
                }
                else
                {
                    r21 = "";
                }

                if (that._ref2 != null)
                {
                    r22 = that._ref2.path();
                }
                else
                {
                    r22 = "";
                }

                return r21.CompareTo(r22);
            }
            throw new java.lang.IllegalArgumentException();
        }

    }
}
