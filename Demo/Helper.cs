using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal static class Helper
    {

        public static void Swap<T>(ref T x, ref T y)/* where T : struct */
        {
            Console.WriteLine("=== SWAP ===");
            T temp = x;
            x = y;
            y = temp;
        }

        public static void Print<T>(string Name)
        {
            Console.WriteLine($"Hello {Name}");
        }

        /// public static void Swap(ref object x, ref object y)
        /// {
        ///     //int NumberX  = (int)x; // UnBoxing
        ///     Console.WriteLine("=== SWAP ===");
        ///     object temp = x;
        ///     x = y;
        ///     y = temp;
        ///     // Boxing && UnBoxing
        ///     // UnSafe Casting
        ///     // any type Can to be Object
        /// }

        /// public static void Swap(ref int x, ref int y)
        /// {
        ///     Console.WriteLine("=== SWAP ===");
        ///     int temp = x;
        ///     x = y;
        ///     y = temp;
        /// }
        /// public static void Swap(ref double   x, ref double y)
        /// {
        ///     Console.WriteLine("=== SWAP ===");
        ///     double temp = x;
        ///     x = y;
        ///     y = temp;
        /// }
        /// public static void Swap(ref Point x, ref Point y)
        /// {
        ///     Console.WriteLine("=== SWAP ===");
        ///     Point temp = x;
        ///     x = y;
        ///     y = temp;
        /// }
    }
}
