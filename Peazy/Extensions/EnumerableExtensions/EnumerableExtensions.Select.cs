using System;
using System.Collections.Generic;
using Peazy.Core;

namespace Peazy.Extensions
{
    public static partial class EnumerableExtensions
    {
        public static IEnumerable<E> SelectWhere<T, E>(this IEnumerable<T> elements, Func<T, E> selector, Predicate<T> predicate)
                => EnumerableHelpers.SelectWhere(elements, selector, predicate);

        public static List<E> SelectToList<T, E>(this IEnumerable<T> elements, Func<T, E> selector)
                => EnumerableHelpers.SelectToList(elements, selector);

        public static List<E> SelectToListWhere<T, E>(this IEnumerable<T> elements, Func<T, E> selector, Predicate<T> predicate)
                => EnumerableHelpers.SelectToListWhere(elements, selector, predicate);
    }
}
