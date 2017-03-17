// ----------------------------------------------------------------
// Author:  Tim Gubener (fortender)
// Filename: ReadOnlyObservableCollection.cs (Timmethy.Core)
// Timestamp: 11.08.2016 00:43
// ----------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace Timmethy.Core {
    /// <summary>
    ///     Wraps a <see cref="BindingList{T}" /> and disallows any operation which would change the underlying list by simply
    ///     throwing
    ///     exceptions when one of those forbidden functions/properties are called. In order to provide bi-directional
    ///     databinding and
    ///     notifications when a cell/item has changed we need a collection/list type such as <see cref="BindingList{T}" />
    ///     which has
    ///     those abilities. In NET Framework 3.5 there is no proper <see cref="ReadOnlyObservableCollection{T}" /> contained
    ///     so this
    ///     class is used to achieve that.
    /// </summary>
    /// <typeparam name="T">The type to be contained</typeparam>
    public class ReadOnlyObservableCollection<T> : IBindingList, IList<T> where T : INotifyPropertyChanged {
        private readonly BindingList<T> _list;

        public ReadOnlyObservableCollection() {
            _list = new BindingList<T>();
        }

        public ReadOnlyObservableCollection(IList<T> list) {
            _list = new BindingList<T>(list);
        }

        public event ListChangedEventHandler ListChanged {
            add { _list.ListChanged += value; }
            remove { _list.ListChanged -= value; }
        }

        //
        //  Interface implementations
        //
        bool IList.IsReadOnly => false;

        bool IList.IsFixedSize => true;

        int ICollection.Count => _list.Count;

        object ICollection.SyncRoot => ((IList) _list).SyncRoot;

        bool ICollection.IsSynchronized => ((IList) _list).IsSynchronized;

        bool IBindingList.AllowNew => false;

        bool IBindingList.AllowEdit => true;

        bool IBindingList.AllowRemove => false;

        bool IBindingList.SupportsChangeNotification => ((IBindingList) _list).SupportsChangeNotification;

        bool IBindingList.SupportsSearching => ((IBindingList) _list).SupportsSearching;

        bool IBindingList.SupportsSorting => ((IBindingList) _list).SupportsSorting;

        bool IBindingList.IsSorted => ((IBindingList) _list).IsSorted;

        PropertyDescriptor IBindingList.SortProperty => ((IBindingList) _list).SortProperty;

        ListSortDirection IBindingList.SortDirection => ((IBindingList) _list).SortDirection;

        object IList.this[int index] {
            get { return ((IList) _list)[index]; }
            set { throw new NotSupportedException("readonly"); }
        }

        int IList.Add(object value) {
            throw new NotSupportedException("readonly");
        }

        bool IList.Contains(object value) => _list.Contains((T) value);

        void IList.Clear() {
            throw new NotSupportedException("readonly");
        }

        int IList.IndexOf(object value) {
            throw new NotSupportedException("readonly");
        }

        void IList.Insert(int index, object value) {
            throw new NotSupportedException("readonly");
        }

        void IList.Remove(object value) {
            throw new NotSupportedException("readonly");
        }

        void IList.RemoveAt(int index) {
            throw new NotSupportedException("readonly");
        }

        void ICollection.CopyTo(Array array, int index) {
            _list.CopyTo((T[]) array, index);
        }

        IEnumerator IEnumerable.GetEnumerator() => _list.GetEnumerator();

        object IBindingList.AddNew() {
            throw new NotSupportedException("readonly");
        }

        void IBindingList.AddIndex(PropertyDescriptor property) {
            ((IBindingList) _list).AddIndex(property);
        }

        void IBindingList.ApplySort(PropertyDescriptor property, ListSortDirection direction) {
            ((IBindingList) _list).ApplySort(property, direction);
        }

        int IBindingList.Find(PropertyDescriptor property, object key) => ((IBindingList) _list).Find(property, key);

        void IBindingList.RemoveIndex(PropertyDescriptor property) {
            ((IBindingList) _list).RemoveIndex(property);
        }

        void IBindingList.RemoveSort() {
            ((IBindingList) _list).RemoveSort();
        }

        public int Count => _list.Count;

        public bool IsReadOnly => true;

        public T this[int index] {
            get { return _list[index]; }
            set { throw new NotSupportedException("readonly"); }
        }

        public IEnumerator<T> GetEnumerator() => _list.GetEnumerator();

        public int IndexOf(T item) => _list.IndexOf(item);

        public void Insert(int index, T item) {
            throw new NotSupportedException("readonly");
        }

        public void RemoveAt(int index) {
            throw new NotSupportedException("readonly");
        }

        void ICollection<T>.Add(T item) {
            throw new NotSupportedException("readonly");
        }

        public void Clear() {
            throw new NotSupportedException("readonly");
        }

        public bool Contains(T item) => _list.Contains(item);

        public void CopyTo(T[] array, int arrayIndex) {
            _list.CopyTo(array, arrayIndex);
        }

        public bool Remove(T item) {
            throw new NotSupportedException("readonly");
        }

        protected void Add(T item) {
            _list.Add(item);
        }

        public void ResetBindings() {
            _list.ResetBindings();
        }
    }
}