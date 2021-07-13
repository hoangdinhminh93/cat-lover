using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace CatLover.Extensions
{
    public static class ObservableExtensions
    {
        /// <summary>
        /// Convert from IList to ObservableCollection.
        /// </summary>
        public static ObservableCollection<T> ToObservableCollection<T>(this IList<T> list)
        {
            var collection = new ObservableCollection<T>();
            if (list != null && list.Count != 0)
            {
                foreach (var item in list)
                {
                    collection.Add(item);
                }
            }
            return collection;
        }

        /// <summary>
        /// Add records to list and then convert to ObservableCollection
        /// </summary>
        public static ObservableCollection<T> AddRangeObservableCollection<T>(this IList<T> list, IList<T> extendList)
        {
            if (list == null)
                list = new List<T>();
            if (extendList != null && extendList.Count != 0)
            {
                foreach (var item in extendList)
                {
                    if (!list.Contains(item))
                        list.Add(item);
                }
            }
            return list.ToObservableCollection();
        }
    }
}