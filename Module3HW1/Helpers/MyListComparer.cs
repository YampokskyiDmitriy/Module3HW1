using System.Collections.Generic;

namespace Module3HW1.Helpers
{
    public class MyListComparer<T> : IComparer<T>
    {
        public int Compare(T x, T y)
        {
            if (x.GetHashCode() > y.GetHashCode())
            {
                return 1;
            }
            else if (x.GetHashCode() == y.GetHashCode())
            {
                return 0;
            }

            return -1;
        }
    }
}