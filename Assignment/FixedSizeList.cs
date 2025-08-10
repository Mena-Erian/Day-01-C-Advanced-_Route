using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{

    internal class FixedSizeList<T> : List<T>
    {
        #region Constructor
        public FixedSizeList(int capacity) : base(capacity) { }
        public FixedSizeList(List<T> values) : base(values) { }
        #endregion

        #region Methods
        public new void Add(T item)
        {
            if (Count == Capacity - 1)
                throw new Exception("This Fixed List and is already Full.");
            base.Add(item);
        }
        public T Get(int index)
        {
            return base[index];
        }
        #endregion

    }
}
/// internal class FixedSizeList<T> : List<T>
/// {
///     #region Attributes and Properties
///     private int capacity = 0; 
///     public int Count {  get { return _list.Count; } }
///     public bool IsReadOnly { get; private set; }
///     #endregion
///   
///     #region Constructor
///     public FixedSizeList(int capacity)
///     {
///         this.capacity = capacity;
///         _list = new FixedSizeList<T>(this.capacity);
///     }
///     #endregion
///
///     #region Indexer
///     public T this[int index] {
///         get => _list[index];
///         set { 
///             if (value == null) throw new ArgumentNullException("value");
///             if (index > capacity)  this._list[index] = value; 
///             
///             throw new IndexOutOfRangeException();
///         } 
///     }
///     #endregion
///
///     #region Methods
///     public void Add(T item)
///     {
///         _list.Add(item);
///         base.Add(item);
///     }
///
///     public void Clear()
///     {
///         throw new NotImplementedException();
///     }
///
///     public bool Contains(T item)
///     {
///         throw new NotImplementedException();
///     }
///
///     public void CopyTo(T[] array, int arrayIndex)
///     {
///         throw new NotImplementedException();
///     }
///
///     public IEnumerator<T> GetEnumerator()
///     {
///         throw new NotImplementedException();
///     }
///
///     public int IndexOf(T item)
///     {
///         throw new NotImplementedException();
///     }
///
///     public void Insert(int index, T item)
///     {
///         throw new NotImplementedException();
///     }
///
///     public bool Remove(T item)
///     {
///         throw new NotImplementedException();
///     }
///
///     public void RemoveAt(int index)
///     {
///         throw new NotImplementedException();
///     }
///
///     IEnumerator IEnumerable.GetEnumerator()
///     {
///         return GetEnumerator();
///     } 
///     #endregion
///  }
