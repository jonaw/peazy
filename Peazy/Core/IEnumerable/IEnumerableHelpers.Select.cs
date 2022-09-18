using System;
using System.Collections.Generic;
using System.Linq;
using Peazy.Extensions;
using Peazy.Internal;

namespace Peazy.Core
{
    internal static partial class IEnumerableHelpers
    {
        public static IEnumerable<E> SelectWhere<T, E>(IEnumerable<T> elements, Func<T, E> selector, Predicate<T> predicate)
        {
            foreach (var element in elements)
            {
                if (predicate(element))
                {
                    yield return selector(element);
                }
            }
        }

        public static List<E> SelectToList<T, E>(IEnumerable<T> elements, Func<T, E> selector)
        {
            return elements.Select(selector).ToList();
        }

        public static List<E> SelectToListWhere<T, E>(IEnumerable<T> elements, Func<T, E> selector, Predicate<T> predicate)
        {
            return elements.SelectWhere(selector, predicate).ToList();
        }
    }
}