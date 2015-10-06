using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Org.Kevoree.Core.Api;

namespace Org.Kevoree.Core.Api.Adaptation
{
    [Serializable]
    public class AdaptationModel : MarshalByRefObject, ISerializable, IDeserializationCallback, ISet<AdaptationPrimitive>, ICollection<AdaptationPrimitive>, IEnumerable<AdaptationPrimitive>, IEnumerable
    {

        private HashSet<AdaptationPrimitive> deriv = new HashSet<AdaptationPrimitive>();


        IEnumerator<AdaptationPrimitive> IEnumerable<AdaptationPrimitive>.GetEnumerator()
        {
            return deriv.GetEnumerator();
        }

        public IEnumerator GetEnumerator()
        {
            return ((IEnumerable) deriv).GetEnumerator();
        }

        void ICollection<AdaptationPrimitive>.Add(AdaptationPrimitive item)
        {
            deriv.Add(item);
        }

        public void Clear()
        {
            deriv.Clear();
        }

        public bool Contains(AdaptationPrimitive item)
        {
            return deriv.Contains(item);
        }

        public void CopyTo(AdaptationPrimitive[] array, int arrayIndex)
        {
            deriv.CopyTo(array, arrayIndex);
        }

        public bool Remove(AdaptationPrimitive item)
        {
            return deriv.Remove(item);
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            deriv.GetObjectData(info, context);
        }

        public void OnDeserialization(object sender)
        {
            deriv.OnDeserialization(sender);
        }

        public bool Add(AdaptationPrimitive item)
        {
            return deriv.Add(item);
        }

        public void UnionWith(IEnumerable<AdaptationPrimitive> other)
        {
            deriv.UnionWith(other);
        }

        public void IntersectWith(IEnumerable<AdaptationPrimitive> other)
        {
            deriv.IntersectWith(other);
        }

        public void ExceptWith(IEnumerable<AdaptationPrimitive> other)
        {
            deriv.ExceptWith(other);
        }

        public void SymmetricExceptWith(IEnumerable<AdaptationPrimitive> other)
        {
            deriv.SymmetricExceptWith(other);
        }

        public bool IsSubsetOf(IEnumerable<AdaptationPrimitive> other)
        {
            return deriv.IsSubsetOf(other);
        }

        public bool IsProperSubsetOf(IEnumerable<AdaptationPrimitive> other)
        {
            return deriv.IsProperSubsetOf(other);
        }

        public bool IsSupersetOf(IEnumerable<AdaptationPrimitive> other)
        {
            return deriv.IsSupersetOf(other);
        }

        public bool IsProperSupersetOf(IEnumerable<AdaptationPrimitive> other)
        {
            return deriv.IsProperSupersetOf(other);
        }

        public bool Overlaps(IEnumerable<AdaptationPrimitive> other)
        {
            return deriv.Overlaps(other);
        }

        public bool SetEquals(IEnumerable<AdaptationPrimitive> other)
        {
            return deriv.SetEquals(other);
        }

        public void CopyTo(AdaptationPrimitive[] array)
        {
            deriv.CopyTo(array);
        }

        public void CopyTo(AdaptationPrimitive[] array, int arrayIndex, int count)
        {
            deriv.CopyTo(array, arrayIndex, count);
        }

        public int RemoveWhere(Predicate<AdaptationPrimitive> match)
        {
            return deriv.RemoveWhere(match);
        }

        public void TrimExcess()
        {
            deriv.TrimExcess();
        }

        public int Count
        {
            get { return deriv.Count; }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public IEqualityComparer<AdaptationPrimitive> Comparer
        {
            get { return deriv.Comparer; }
        }

    }
}
