using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Data;

namespace System.Collections.ObjectModel  
{
    public static class CollectionEx
    {
        public static ObservableCollection<T> ToObservableCollection<T>(this IEnumerable<T> list)
        {
            var collection = new ObservableCollection<T>();
            foreach (var e in list)
                collection.Add(e);
            return collection;
        }
        //public static List<T> ToList<T>(this IEnumerable<T> list)
        //{
        //    var collection = new List<T>();
        //    foreach (var e in list)
        //        collection.Add(e);
        //    return collection;
        //}
        public static T LastItem<T>(this List<T> list)
        {
            if (list == null || list.Count == 0)
                return default(T);

            var count = list.Count();
            return list[count - 1];
        }
        public static T FirstItem<T>(this List<T> list)
        {
            if (list == null || list.Count == 0)
                return default(T);
            
            return list[0];
        }
        public static CollectionViewSource SortBy(this CollectionViewSource viewSource, 
            string propertyName, ListSortDirection direction = ListSortDirection.Descending)
        {
            viewSource.SortDescriptions.Add(new SortDescription(propertyName, direction));
            return viewSource;
        }
    }
}