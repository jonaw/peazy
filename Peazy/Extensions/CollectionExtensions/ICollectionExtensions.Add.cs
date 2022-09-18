using System;
using System.Collections.Generic;
using Peazy.Core;

namespace Peazy.Extensions
{
    public static partial class ICollectionExtensions
    {
        public static ICollection<T> AddRange<T>(this ICollection<T> collection, IEnumerable<T> items)
            => ICollectionHelpers.AddRange(collection, items);

        public static ICollection<T> AddIf<T>(this ICollection<T> collection, T item, bool canAdd)
            => ICollectionHelpers.AddIf(collection, item, canAdd);

        public static ICollection<T> AddWhenAll<T>(this ICollection<T> collection, T item, Func<T, bool> predicate)
            => ICollectionHelpers.AddWhenAll(collection, item, predicate);
    }
}
