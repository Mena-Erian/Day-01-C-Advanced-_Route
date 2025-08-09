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
        public static void Print<T>( this IEnumerable<T> values) where T : IEnumerable
        {
            foreach (T item in values) Console.WriteLine(item);
        }
        public static void Print<T>(this List<T> values)
        {
            foreach (T item in values) Console.WriteLine(item);
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

    }
}
