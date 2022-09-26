using System;
using System.Collections.Generic;
using Peazy.Internal;

namespace Peazy.Core
{
    internal static partial class EnumerableHelpers
    {
        public static IEnumerable<T> DistinctBy<T, E>(this IEnumerable<T> source, Func<T, E> selector)
        {
            if (source == null)
            {
                throw ExceptionCreationHelpers.CreateArgumentNullException(nameof(source));
            }

            if (selector == null)
            {
                throw ExceptionCreationHelpers.CreateArgumentNullException(nameof(selector));
            }

            return DistinctByCore(source, selector, null);
        }

        public static IEnumerable<T> DistinctBy<T, E>(this IEnumerable<T> source, Func<T, E> selector, IEqualityComparer<E> comparer)
        {
            if (source == null)
            {
                throw ExceptionCreationHelpers.CreateArgumentNullException(nameof(source));
            }

            if (selector == null)
            {
                throw ExceptionCreationHelpers.CreateArgumentNullException(nameof(selector));
            }

            return DistinctByCore(source, selector, comparer);
        }

        private static IEnumerable<T> DistinctByCore<T, E>(IEnumerable<T> source, Func<T, E> selector, IEqualityComparer<E> comparer)
        {
            var set = new HashSet<E>(comparer);
            foreach (var element in source)
            {
                var value = selector(element);
                if (set.Add(value))
                {
                    yield return element;
                }
            }
        }
    }
}
