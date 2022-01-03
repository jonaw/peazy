using Peazy.Internal;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Peazy.Extensions
{
    public static partial class IEnumerableExtensions
    {
        public static bool AnyEndsWith(this IEnumerable<string> source, string value)
            => AnyEndsWithImpl(source, value, StringComparison.Ordinal, StringNullStrategy.Skip);

        public static bool AnyEndsWith(this IEnumerable<string> source, string value, StringComparison comparisonType)
            => AnyEndsWithImpl(source, value, comparisonType, StringNullStrategy.Skip);

        public static bool AnyEndsWith(this IEnumerable<string> source, string value, StringNullStrategy nullStrategy)
            => AnyEndsWithImpl(source, value, StringComparison.Ordinal, nullStrategy);

        public static bool AnyEndsWith(this IEnumerable<string> source, string value, StringComparison comparisonType, StringNullStrategy nullStrategy)
            => AnyEndsWithImpl(source, value, comparisonType, nullStrategy);

        public static bool AnyEndsWith<T>(this IEnumerable<T> source, Func<T, string> selector, string value)
            => AnyEndsWithImpl(source, selector, value, StringComparison.Ordinal, StringNullStrategy.Skip);

        public static bool AnyEndsWith<T>(this IEnumerable<T> source, Func<T, string> selector, string value, StringComparison comparisonType)
            => AnyEndsWithImpl(source, selector, value, comparisonType, StringNullStrategy.Skip);

        public static bool AnyEndsWith<T>(this IEnumerable<T> source, Func<T, string> selector, string value, StringNullStrategy nullStrategy)
            => AnyEndsWithImpl(source, selector, value, StringComparison.Ordinal, nullStrategy);

        public static bool AnyEndsWith<T>(this IEnumerable<T> source, Func<T, string> selector, string value, StringComparison comparisonType, StringNullStrategy nullStrategy)
            => AnyEndsWithImpl(source, selector, value, comparisonType, nullStrategy);

        private static bool AnyEndsWithImpl<T>(this IEnumerable<T> source, Func<T, string> selector, string value, StringComparison comparisonType, StringNullStrategy nullStrategy)
        {
            var exception = ValidateArguments(source, value) ?? ValidateArgument(selector);
            if (exception != null)
            {
                throw exception;
            }

            var values = source.Select(v => selector(v));
            return AEImpl(values, value, comparisonType, nullStrategy);
        }

        public static bool AnyEndsWithImpl(this IEnumerable<string> source, string value, StringComparison comparisonType, StringNullStrategy nullStrategy)
        {
            var exception = ValidateArguments(source, value);
            if (exception != null)
            {
                throw exception;
            }

            return AEImpl(source, value, comparisonType, nullStrategy);
        }

        public static bool AEImpl(this IEnumerable<string> source, string value, StringComparison comparisonType, StringNullStrategy nullStrategy)
        {
            source = source.ApplyNullStrategy(nullStrategy);
            return source.Any(v => v.EndsWith(value, comparisonType));
        }
    }
}
