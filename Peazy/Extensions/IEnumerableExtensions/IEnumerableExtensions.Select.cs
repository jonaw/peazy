using System;
using System.Collections.Generic;
using Peazy.Core;

namespace Peazy.Extensions
{
    public static partial class IEnumerableExtensions
    {
        public static IEnumerable<E> SelectWhere<T, E>(this IEnumerable<T> elements, Func<T, E> selector, Predicate<T> predicate)
                => IEnumerableHelpers.SelectWhere(elements, selector, predicate);

        public static List<E> SelectToList<T, E>(this IEnumerable<T> elements, Func<T, E> selector)
                => IEnumerableHelpers.SelectToList(elements, selector);

        public static List<E> SelectToListWhere<T, E>(this IEnumerable<T> elements, Func<T, E> selector, Predicate<T> predicate)
                => IEnumerableHelpers.SelectToListWhere(elements, selector, predicate);
    }
}
