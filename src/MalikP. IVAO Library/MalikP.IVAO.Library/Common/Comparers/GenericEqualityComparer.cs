using System.Collections.Generic;

namespace MalikP.IVAO.Library.Common.Comparers
{
    public sealed class GenericEqualityComparer<T> : IEqualityComparer<T>
    {
        public bool Equals(T x, T y)
        {
            return object.Equals(x, y);
        }

        public int GetHashCode(T obj)
        {
            return obj.GetHashCode();
        }
    }
}
