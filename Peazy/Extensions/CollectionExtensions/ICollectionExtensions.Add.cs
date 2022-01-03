using System;
using System.Collections.Generic;
using System.Linq;

namespace Peazy.Extensions
{
    public static partial class ICollectionExtensions
    {
        public static ICollection<T> AddRange<T>(this ICollection<T> collection, IEnumerable<T> items)
            => AddRangeImpl(collection, items);

        public static ICollection<T> AddIf<T>(this ICollection<T> collection, T item, bool canAdd)
            => AddIfImpl(collection, item, canAdd);

        public static ICollection<T> AddWhenAll<T>(this ICollection<T> collection, T item, Func<T, bool> predicate)
        {
            var canAdd = collection.All(predicate);
            
            AddIfImpl(collection, item, canAdd);

            return collection;
        }

        #region Implementations
        private static ICollection<T> AddRangeImpl<T>(ICollection<T> collection, IEnumerable<T> items)
        {
            foreach(var item in items)
            {
                collection.Add(item);
            }

            return collection;
        }

        private static ICollection<T> AddIfImpl<T>(ICollection<T> collection, T item, bool canAdd)
        {
            if (canAdd)
            {
                collection.Add(item);
            }

            return collection;
        }
        #endregion
    }
}
