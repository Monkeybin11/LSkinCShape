using System;
using System.Collections;
using System.Collections.Generic;


    public class ListX<T> : IList
    {
        private List<T> list = new List<T>();

        public EventHandler AddHandler;
        public EventHandler RemoveHandler;
        public EventHandler ClearHandler;
        public bool IsReadOnly
        {
            get
            {
                return ((IList)list).IsReadOnly;
            }
        }

        public bool IsFixedSize
        {
            get
            {
                return ((IList)list).IsFixedSize;
            }
        }

        public int Count
        {
            get
            {
                return ((IList)list).Count;
            }
        }

        public object SyncRoot
        {
            get
            {
                return ((IList)list).SyncRoot;
            }
        }

        public bool IsSynchronized
        {
            get
            {
                return ((IList)list).IsSynchronized;
            }
        }

        object IList.this[int index]
        {
            get
            {
                return ((IList)list)[index];
            }

            set
            {
                ((IList)list)[index] = value;
            }
        }

        public T this[int index]
        {
            get
            {
                return list[index];
            }
            set
            {
                list[index] = value;
            }
        }

        /// <summary>
        /// 为list设置白名单
        /// </summary>
        ////public void WhiteList() {


        ////}

        public int Add(object value)
        {
            int state = ((IList)list).Add(value);
            if (AddHandler != null)
                AddHandler(value, null);
            return state;
        }

        public int Add(object value, EventHandler DoneWork)
        {
            int state = ((IList)list).Add(value);
            if (DoneWork != null)
                DoneWork(value, null);
            return state;
        }

        public bool Contains(object value)
        {
            return ((IList)list).Contains(value);
        }

        public void Clear()
        {
            ((IList)list).Clear();
            if (ClearHandler != null) ClearHandler(null,null);

        }
        public int IndexOf(object value)
        {
            return ((IList)list).IndexOf(value);
        }

        public void Insert(int index, object value)
        {
            ((IList)list).Insert(index, value);
        }

        public void Remove(object value)
        {
            ((IList)list).Remove(value);
            if (RemoveHandler != null) RemoveHandler(value, null);
        }

        public void Remove(object value, EventHandler DoneWork)
        {
            ((IList)list).Remove(value);
            if (DoneWork != null) DoneWork(value, null);
        }

        public void RemoveAt(int index)
        {
            ((IList)list).RemoveAt(index);
        }

        public void CopyTo(Array array, int index)
        {
            ((IList)list).CopyTo(array, index);
        }

        public IEnumerator GetEnumerator()
        {
            return ((IList)list).GetEnumerator();
        }
    }
