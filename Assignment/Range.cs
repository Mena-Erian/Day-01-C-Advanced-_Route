using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;


namespace Assignment
{
    internal class Range<T> where T : IComparable<T>, INumber<T>
    {
        public T Minimum { get; set; }
        public T Maximum { get; set; }
        public Range(T minimum  , T maximum)
        {
            Minimum = minimum; // 5
            Maximum = maximum; // 10
        }

        public bool IsInRange(T value)//7
        {
            var min = value.CompareTo(Minimum);
            if (min == -1) return false;
            var max = value.CompareTo(Maximum);
            if (max == 1) return false;
            if ((min >= 0) && max <= 0) return true;
            return false;
        }

        public T Length()
        {
            return Maximum - Minimum;
        }
    }
}
