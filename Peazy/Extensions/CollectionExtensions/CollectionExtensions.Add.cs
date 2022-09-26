using System;
using System.Collections.Generic;
using Peazy.Core;

namespace Peazy.Extensions
{
    public static partial class CollectionExtensions
    {
        /// <summary>
        /// Add a range of items to a collection
        /// </summary>
        /// <param name="collection">Collection to add to</param>
        /// <param name="items">Items to add to the collection</param>
        /// <typeparam name="T">Type of collection and items</typeparam>
        /// <returns>Returns the given <paramref name="collection"/> with items added</returns>
        public static ICollection<T> AddRange<T>(this ICollection<T> collection, IEnumerable<T> items)
            => CollectionHelpers.AddRange(collection, items);
    }
}
