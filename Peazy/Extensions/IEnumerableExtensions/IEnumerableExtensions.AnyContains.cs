using Peazy.Core;
using System;
using System.Collections.Generic;

namespace Peazy.Extensions
{
    public static partial class IEnumerableExtensions
    {
        public static bool AnyContains(this IEnumerable<string> source, string value)
            => IEnumerableHelpers.AnyContains(source, value, StringComparison.Ordinal, StringNullStrategy.Skip);

        public static bool AnyContains(this IEnumerable<string> source, string value, StringComparison comparisonType)
            => IEnumerableHelpers.AnyContains(source, value, comparisonType, StringNullStrategy.Skip);

        public static bool AnyContains(this IEnumerable<string> source, string value, StringNullStrategy nullStrategy)
            => IEnumerableHelpers.AnyContains(source, value, StringComparison.Ordinal, nullStrategy);

        public static bool AnyContains(this IEnumerable<string> source, string value, StringComparison comparisonType, StringNullStrategy nullStrategy)
            => IEnumerableHelpers.AnyContains(source, value, comparisonType, nullStrategy);

        public static bool AnyContains<T>(this IEnumerable<T> source, Func<T, string> selector, string value)
            => IEnumerableHelpers.AnyContains(source, selector, value, StringComparison.Ordinal, StringNullStrategy.Skip);

        public static bool AnyContains<T>(this IEnumerable<T> source, Func<T, string> selector, string value, StringComparison comparisonType)
            => IEnumerableHelpers.AnyContains(source, selector, value, comparisonType, StringNullStrategy.Skip);

        public static bool AnyContains<T>(this IEnumerable<T> source, Func<T, string> selector, string value, StringNullStrategy nullStrategy)
            => IEnumerableHelpers.AnyContains(source, selector, value, StringComparison.Ordinal, nullStrategy);

        public static bool AnyContains<T>(this IEnumerable<T> source, Func<T, string> selector, string value, StringComparison comparisonType, StringNullStrategy nullStrategy)
            => IEnumerableHelpers.AnyContains(source, selector, value, comparisonType, nullStrategy);
    }
}
