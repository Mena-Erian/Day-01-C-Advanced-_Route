using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal static class Helper<T> where T : IComparable<T>
        // T must be Class or Struct Implementing the Built-in interface "IComparable"
    {

       
        public static void BubbleSort(T[] Arr)
        {
            if (Arr is null || Arr.Length == 0) return;

            for (int i = 0; i < Arr.Length /*6*/; i++) // i = 0
            {
                for (int j = 0; j < Arr.Length - 1 - i /*5*/; j++) // j = 2
                {
                    //         > 
                    if (Arr[j].CompareTo(Arr[j + 1]) == 1)
                       Swap(ref Arr[j], ref Arr[j + 1]);
                }
            }
        }
        public static void BubbleSort(int[] Arr)
        {
            if (Arr is null || Arr.Length == 0) return;

            for (int i = 0; i < Arr.Length /*6*/; i++) // i = 0
            {
                for (int j = 0; j < Arr.Length - 1 - i /*5*/; j++) // j = 2
                {
                    if (Arr[j] > Arr[j + 1])
                        Helper<int>.Swap(ref Arr[j], ref Arr[j + 1]);
                }
            }
        }

        delegate bool FunCDelgete(T X, T Y);
        public static bool isPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;
            double dividedResult = default(double);
            //for (int i = 2; i <= number; i++)
            //{
            //    dividedResult = number / (double)i;
            //    if (dividedResult % 1 ==0) return false;
            //}

            for (int i = 3; i <= Math.Sqrt(number); i += 2)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }
        public static int LinarSearch(T[] Arr, T Value)
        {
            if (Arr?.Length > 0 && Value is not null)
            {
                for (int i = 0; i < Arr.Length; i++)
                {
                    if (Value.Equals(Arr[i]))
                        return i;
                }
            }
            return -1;
        }
        //                                              Startige Design pattern
        public static int LinarSearch(T[] Arr, T Value, IEqualityComparer<T> equalityComparer)
        {
            if (Arr?.Length > 0 && Value is not null)
            {
                for (int i = 0; i < Arr.Length; i++)
                {
                    //if (Value.Equals(Arr[i]))
                    if (equalityComparer.Equals(Value, Arr[i]))
                        return i;
                }
            }
            return -1;
        }
        //                                              built in delegete
        public static int LinarSearch(T[] Arr, T Value, Func<T, T, bool> equals)
        {

            if (Arr?.Length > 0 && Value is not null)
            {
                for (int i = 0; i < Arr.Length; i++)
                {
                    //if (Value.Equals(Arr[i]))
                    if (equals(Value, Arr[i]))
                        return i;
                }
            }
            return -1;
        }
        public static void Swap(ref T x, ref T y)/* where T : struct */
        {
            //Console.WriteLine("=== SWAP ===");
            T temp = x;
            x = y;
            y = temp;
        }

        public static void Print/*<T>*/(string Name)
        {
            Console.WriteLine($"Hello {Name}");
        }
        ///--------------------------------------------------------
        public static void Swap(ref object x, ref object y)
        {
            //int NumberX  = (int)x; // UnBoxing
            Console.WriteLine("=== SWAP ===");
            object temp = x;
            x = y;
            y = temp;
            // Boxing && UnBoxing
            // UnSafe Casting
            // any type Can to be Object
        }

        public static void Swap(ref int x, ref int y)
        {
            //Console.WriteLine("=== SWAP ===");
            int temp = x;
            x = y;
            y = temp;
        }
        public static void Swap(ref double x, ref double y)
        {
            Console.WriteLine("=== SWAP ===");
            double temp = x;
            x = y;
            y = temp;
        }
        public static void Swap(ref Point x, ref Point y)
        {
            Console.WriteLine("=== SWAP ===");
            Point temp = x;
            x = y;
            y = temp;
        }
    }
}
