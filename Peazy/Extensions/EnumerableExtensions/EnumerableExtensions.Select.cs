using System;
using System.Collections.Generic;
using Peazy.Core;

namespace Peazy.Extensions
{
    public static partial class EnumerableExtensions
    {
        /// <summary>
        /// Project <paramref name="source"/> items to another type, provided item is qualified by <paramref name="predicate"/>
        /// </summary>
        /// <param name="source">Source of items to project</param>
        /// <param name="selector">Projecting function</param>
        /// <param name="predicate">Qualify item for projection</param>
        /// <typeparam name="T">Type of items to project</typeparam>
        /// <typeparam name="E">Type of projected items</typeparam>
        /// <returns>Returns a new enumerable containing projected items</returns>
        public static IEnumerable<E> SelectWhere<T, E>(this IEnumerable<T> source, Func<T, E> selector, Predicate<T> predicate)
                => EnumerableHelpers.SelectWhere(source, selector, predicate);

        /// <summary>
        /// Project <paramref name="source"/> items to another type and return as List
        /// </summary>
        /// <param name="source">Source of items to project</param>
        /// <param name="selector">Projecting function</param>
        /// <typeparam name="T">Type of items to project</typeparam>
        /// <typeparam name="E">Type of projected items</typeparam>
        /// <returns>Returns a new list containing projected items</returns>
        public static List<E> SelectToList<T, E>(this IEnumerable<T> source, Func<T, E> selector)
                => EnumerableHelpers.SelectToList(source, selector);
    }
}
