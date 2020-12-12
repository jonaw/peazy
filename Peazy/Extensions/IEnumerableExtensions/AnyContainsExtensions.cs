using System;
using System.Collections.Generic;
using System.Linq;
using Peazy.Internal;

namespace Peazy.Extensions.IEnumerableExtensions
{
    public static class AnyContainsExtensions
    {
        public static bool AnyContains(this IEnumerable<string> source, string value)
            => AnyContainsImpl(source, value, StringComparison.Ordinal, StringNullStrategy.Ignore);

        public static bool AnyContains(this IEnumerable<string> source, string value, StringComparison comparisonType)
            => AnyContainsImpl(source, value, comparisonType, StringNullStrategy.Ignore);

        public static bool AnyContains(this IEnumerable<string> source, string value, StringNullStrategy nullStrategy)
            => AnyContainsImpl(source, value, StringComparison.Ordinal, nullStrategy);

        public static bool AnyContains(this IEnumerable<string> source, string value, StringComparison comparisonType, StringNullStrategy nullStrategy)
            => AnyContainsImpl(source, value, comparisonType, nullStrategy);

        public static bool AnyContains<T>(this IEnumerable<T> source, Func<T, string> selector, string value)
            => AnyContainsImpl(source, selector, value, StringComparison.Ordinal, StringNullStrategy.Ignore);

        public static bool AnyContains<T>(this IEnumerable<T> source, Func<T, string> selector, string value, StringComparison comparisonType)
            => AnyContainsImpl(source, selector, value, comparisonType, StringNullStrategy.Ignore);

        public static bool AnyContains<T>(this IEnumerable<T> source, Func<T, string> selector, string value, StringNullStrategy nullStrategy)
            => AnyContainsImpl(source, selector, value, StringComparison.Ordinal, nullStrategy);

        public static bool AnyContains<T>(this IEnumerable<T> source, Func<T, string> selector, string value, StringComparison comparisonType, StringNullStrategy nullStrategy)
            => AnyContainsImpl(source, selector, value, comparisonType, nullStrategy);

        private static bool AnyContainsImpl(this IEnumerable<string> source, string value, StringComparison comparisonType, StringNullStrategy nullStrategy)
        {
            var exception = ValidateArguments(source, value);
            if (exception != null)
            {
                throw exception;
            }

            return Impl(source, value, comparisonType, nullStrategy);
        }

        private static bool AnyContainsImpl<T>(this IEnumerable<T> source, Func<T, string> selector, string value, StringComparison comparisonType, StringNullStrategy nullStrategy)
        {
            var exception = ValidateArguments(source, value) ?? ValidateArgument(selector);
            if (exception != null)
            {
                throw exception;
            }

            return Impl(source, selector, value, comparisonType, nullStrategy);
        }

        private static bool Impl(this IEnumerable<string> source, string value, StringComparison comparisonType, StringNullStrategy nullStrategy)
        {
            source = source.ApplyNullStrategy(nullStrategy);
            return source.Any(v => v.IndexOf(value, comparisonType) > -1);
        }

        private static bool Impl<T>(this IEnumerable<T> source, Func<T, string> selector, string value, StringComparison comparisonType, StringNullStrategy nullStrategy)
        {
            source = source.ApplyNullStrategy(nullStrategy);
            var values = source.Select(selector);

            return values.Any(v => v.IndexOf(value, comparisonType) > -1);
        }

        private static Exception ValidateArguments<T>(this IEnumerable<T> source, string value)
        {
            if (source == null)
            {
                return ExceptionCreationHelpers.CreateArgumentNullException(nameof(source));
            }

            if (value == null)
            {
                return ExceptionCreationHelpers.CreateArgumentNullException(nameof(value));
            }

            return null;
        }

        private static Exception ValidateArgument<T>(Func<T, string> selector)
        {
            if (selector == null)
            {
                return ExceptionCreationHelpers.CreateArgumentNullException(nameof(selector));
            }

            return null;
        }
    }
}
