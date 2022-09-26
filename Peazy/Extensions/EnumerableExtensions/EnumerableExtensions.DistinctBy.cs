using Peazy.Core;
using System;
using System.Collections.Generic;

namespace Peazy.Extensions
{
    public static partial class EnumerableExtensions
    {
        // With the release of .NET 6, these methods are available through System.Linq
        // https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.distinctby?view=net-6.0

        #if !NET6_0_OR_GREATER
        public static IEnumerable<T> DistinctBy<T, E>(this IEnumerable<T> source, Func<T, E> selector)
            => EnumerableHelpers.DistinctBy(source, selector);

        public static IEnumerable<T> DistinctBy<T, E>(this IEnumerable<T> source, Func<T, E> selector, IEqualityComparer<E> comparer)
            => EnumerableHelpers.DistinctBy(source, selector, comparer);
        #endif
    }
}
