using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
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
            
            for (int i = 0; i < arrayList.Count/2; i++)
            {
                temp = arrayList[i] ?? new object { };
                arrayList[i] = null;
                arrayList[i] = arrayList[tempIndexer];
                arrayList[tempIndexer--] = temp;
            }
            return arrayList;
        }
    }
}
