﻿using Peazy.Core;
using System;
using System.Collections.Generic;

namespace Peazy.Extensions
{
    public static partial class IEnumerableExtensions
    {
        public static bool AnyStartsWith(this IEnumerable<string> source, string value)
            => AnyStartsWith(source, value, StringComparison.Ordinal, StringNullStrategy.Skip);

        public static bool AnyStartsWith(this IEnumerable<string> source, string value, StringComparison comparisonType)
            => IEnumerableHelpers.AnyStartsWith(source, value, comparisonType, StringNullStrategy.Skip);

        public static bool AnyStartsWith(this IEnumerable<string> source, string value, StringNullStrategy nullStrategy)
            => IEnumerableHelpers.AnyStartsWith(source, value, StringComparison.Ordinal, nullStrategy);

        public static bool AnyStartsWith(this IEnumerable<string> source, string value, StringComparison comparisonType, StringNullStrategy nullStrategy)
            => IEnumerableHelpers.AnyStartsWith(source, value, comparisonType, nullStrategy);

        public static bool AnyStartsWith<T>(this IEnumerable<T> source, Func<T, string> selector, string value)
                => AnyStartsWith(source, selector, value, StringComparison.Ordinal, StringNullStrategy.Skip);

        public static bool AnyStartsWith<T>(this IEnumerable<T> source, Func<T, string> selector, string value, StringComparison comparisonType)
            => IEnumerableHelpers.AnyStartsWith(source, selector, value, comparisonType, StringNullStrategy.Skip);

        public static bool AnyStartsWith<T>(this IEnumerable<T> source, Func<T, string> selector, string value, StringNullStrategy nullStrategy)
            => IEnumerableHelpers.AnyStartsWith(source, selector, value, StringComparison.Ordinal, nullStrategy);

        public static bool AnyStartsWith<T>(this IEnumerable<T> source, Func<T, string> selector, string value, StringComparison comparisonType, StringNullStrategy nullStrategy)
            => IEnumerableHelpers.AnyStartsWith(source, selector, value, comparisonType, nullStrategy);
    }
}
