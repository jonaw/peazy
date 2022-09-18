using System;
using System.Collections.Generic;
using System.Linq;

namespace Peazy.Core
{
    internal static partial class ICollectionHelpers
    {
        public static ICollection<T> AddRange<T>(ICollection<T> collection, IEnumerable<T> items)
        {
            foreach (var item in items)
            {
                collection.Add(item);
            }

            return collection;
        }

        public static ICollection<T> AddIf<T>(ICollection<T> collection, T item, bool canAdd)
        {
            if (canAdd)
            {
                collection.Add(item);
            }

            return collection;
        }

        public static ICollection<T> AddWhenAll<T>(ICollection<T> collection, T item, Func<T, bool> predicate)
        {
            var shouldAdd = collection.All(predicate);
            AddIf(collection, item, shouldAdd);
            return collection;
        }
    }
}