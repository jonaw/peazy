using Peazy.Core;
using System;
using System.Collections.Generic;

namespace Peazy.Extensions
{
    public static partial class EnumerableExtensions
    {
        public static bool AnyContains(this IEnumerable<string> source, string value)
            => EnumerableHelpers.AnyContains(source, value, StringComparison.Ordinal, StringNullStrategy.Skip);

        public static bool AnyContains(this IEnumerable<string> source, string value, StringComparison comparisonType)
            => EnumerableHelpers.AnyContains(source, value, comparisonType, StringNullStrategy.Skip);

        public static bool AnyContains(this IEnumerable<string> source, string value, StringNullStrategy nullStrategy)
            => EnumerableHelpers.AnyContains(source, value, StringComparison.Ordinal, nullStrategy);

        public static bool AnyContains(this IEnumerable<string> source, string value, StringComparison comparisonType, StringNullStrategy nullStrategy)
            => EnumerableHelpers.AnyContains(source, value, comparisonType, nullStrategy);

        public static bool AnyContains<T>(this IEnumerable<T> source, Func<T, string> selector, string value)
            => EnumerableHelpers.AnyContains(source, selector, value, StringComparison.Ordinal, StringNullStrategy.Skip);

        public static bool AnyContains<T>(this IEnumerable<T> source, Func<T, string> selector, string value, StringComparison comparisonType)
            => EnumerableHelpers.AnyContains(source, selector, value, comparisonType, StringNullStrategy.Skip);

        public static bool AnyContains<T>(this IEnumerable<T> source, Func<T, string> selector, string value, StringNullStrategy nullStrategy)
            => EnumerableHelpers.AnyContains(source, selector, value, StringComparison.Ordinal, nullStrategy);

        public static bool AnyContains<T>(this IEnumerable<T> source, Func<T, string> selector, string value, StringComparison comparisonType, StringNullStrategy nullStrategy)
            => EnumerableHelpers.AnyContains(source, selector, value, comparisonType, nullStrategy);
    }
}
