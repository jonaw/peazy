using Peazy.Core;
using System;
using System.Collections.Generic;

namespace Peazy.Extensions
{
    public static partial class EnumerableExtensions
    {
        public static bool AnyEndsWith(this IEnumerable<string> source, string value)
            => EnumerableHelpers.AnyEndsWith(source, value, StringComparison.Ordinal, StringNullStrategy.Skip);

        public static bool AnyEndsWith(this IEnumerable<string> source, string value, StringComparison comparisonType)
            => EnumerableHelpers.AnyEndsWith(source, value, comparisonType, StringNullStrategy.Skip);

        public static bool AnyEndsWith(this IEnumerable<string> source, string value, StringNullStrategy nullStrategy)
            => EnumerableHelpers.AnyEndsWith(source, value, StringComparison.Ordinal, nullStrategy);

        public static bool AnyEndsWith(this IEnumerable<string> source, string value, StringComparison comparisonType, StringNullStrategy nullStrategy)
            => EnumerableHelpers.AnyEndsWith(source, value, comparisonType, nullStrategy);

        public static bool AnyEndsWith<T>(this IEnumerable<T> source, Func<T, string> selector, string value)
            => EnumerableHelpers.AnyEndsWith(source, selector, value, StringComparison.Ordinal, StringNullStrategy.Skip);

        public static bool AnyEndsWith<T>(this IEnumerable<T> source, Func<T, string> selector, string value, StringComparison comparisonType)
            => EnumerableHelpers.AnyEndsWith(source, selector, value, comparisonType, StringNullStrategy.Skip);

        public static bool AnyEndsWith<T>(this IEnumerable<T> source, Func<T, string> selector, string value, StringNullStrategy nullStrategy)
            => EnumerableHelpers.AnyEndsWith(source, selector, value, StringComparison.Ordinal, nullStrategy);

        public static bool AnyEndsWith<T>(this IEnumerable<T> source, Func<T, string> selector, string value, StringComparison comparisonType, StringNullStrategy nullStrategy)
            => EnumerableHelpers.AnyEndsWith(source, selector, value, comparisonType, nullStrategy);
    }
}
