
using System.Collections;

namespace Assignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region 1. Bubble Sort Algorithm Optimisation

            #endregion

            #region 2. Range Class
            /// Range<int> range = new Range<int>(minimum: 5, maximum: 10);
            /// Range<string> rangeOfStrings = new Range<string>("dsfjkl", "KLJ");
            /// Console.WriteLine(range.IsInRange(9));
            /// //Console.WriteLine(range.Length((max, min) => max - min));
            /// Console.WriteLine(rangeOfStrings.Length());// will throw excption to use another overrload
            #endregion

            #region 3. Array List Rverse Manually
            /// ArrayList array = new ArrayList(10);
            /// //array.AddRange(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
            /// array.AddRange(new int[] { 5, 96, 8, 12, 13});
            /// //                          13,12,8,96,5
            /// Helper.Reverce(ref array);
            /// foreach (int item in array) Console.WriteLine(item); 
            #endregion

            #region 4. Get Even Numbers From List
            /// List<int> numbers = new List<int>([1, 2, 3, 4, 5, 6, 7, 8, 9, 10]);
            /// Helper.GetEvenNumbersList/*<int>*/(numbers).Print();
            #endregion

        }
    }
}
