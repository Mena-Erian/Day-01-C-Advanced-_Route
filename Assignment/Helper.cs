using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal static class Helper
    {
        public static void Print<T>(this T value) => Console.WriteLine(value);
        public static void Print<T>(this IEnumerable<T> values) where T : IEnumerable
        {
            foreach (T item in values) Console.WriteLine(item);
        }
        public static void Print<T>(this List<T> values)
        {
            foreach (T item in values) Console.WriteLine(item);
        }
        public static ArrayList Reverce(ref ArrayList arrayList)
        {
            #region solution using tempArray
            /// if (arrayList == null) return [];
            /// ArrayList tempArray = new ArrayList(arrayList.Capacity);
            /// for (int i = arrayList.Count - 1; i >= 0; i--)
            /// {
            ///     tempArray.Add(arrayList[i]);
            /// }
            /// arrayList = tempArray;
            /// return arrayList;
            #endregion

            if (arrayList == null && arrayList!.Count <= 0) return [];
            int tempIndexer = arrayList.Count - 1;//9
            object temp;

            for (int i = 0; i < arrayList.Count / 2; i++)
            {
                temp = arrayList[i] ?? new object { };
                arrayList[i] = null;
                arrayList[i] = arrayList[tempIndexer];
                arrayList[tempIndexer--] = temp;
            }
            return arrayList;
        }
        public static List<T> GetEvenNumbersList<T>(List<T> array) where T : INumber<T>/*, IModulusOperators<T, T, T>*/
        {
            List<T> list = new List<T>(array.Count);
            foreach (T item in array)
                if (item % T.CreateChecked(2) == T.Zero) list.Add(item);

            ///   //if (Mod(item, temp1) == temp2) list.Add(item);
            ///   //if ( item % 2 ==0 ) list.Add(item);

            return list;
        }
        /// public static T Mod<T>(T a, T b) where T : INumber<T>
        /// {
        ///     return a % b;
        /// }

        public static int GetNonRepeatedChar(string str)
        {
            //string str = "Mohamdad";
            str = str.ToLower();
            bool isNonCharRepeated = true;
            Dictionary<char, int> dictionary = new Dictionary<char, int>();
            List<int> indexesOfRepeatedChar = new List<int>((int)Math.Ceiling(str.Length / 2f));

            for (int i = 0; i < str.Length; i++)
            {
                isNonCharRepeated = dictionary.TryAdd(str[i], i);
                if (!isNonCharRepeated) indexesOfRepeatedChar.Add(i);
            }
            // if we don't have repeated characters
            if (indexesOfRepeatedChar.Count == 0)
            {
                return 0;
            }
            // if all char is repeated
            else if (indexesOfRepeatedChar.Count == indexesOfRepeatedChar.Capacity)
            {
                return -1;
            }
            // if we have char or more are repeated
            else if (indexesOfRepeatedChar.Count > 0)
            {
                ///  //           4  67
                ///  // str = "mohamdad"
                ///  // indexesOfRepeatedChar = [4,6,7]
                ///  // count = 3
                ///  // dicitonary = "mohad"

                for (int i = 0; i < indexesOfRepeatedChar.Count; i++)
                    dictionary.Remove(str[indexesOfRepeatedChar[i]]);
                
                return dictionary.Values.ToArray()[0];
            }

            return -1;
        }
    }
}
