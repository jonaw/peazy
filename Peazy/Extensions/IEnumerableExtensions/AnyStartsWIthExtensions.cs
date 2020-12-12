using System;
using System.Collections.Generic;
using System.Linq;
using Peazy.Internal;

namespace Peazy.Extensions.IEnumerableExtensions
{
    public static class AnyStartsWithExtensions
    {
        public static bool AnyStartsWith(this IEnumerable<string> source, string value)
            => AnyStartsWith(source, value, StringComparison.Ordinal, StringNullStrategy.Ignore);

        public static bool AnyStartsWith(this IEnumerable<string> source, string value, StringComparison comparisonType)
            => AnyStartsWithImpl(source, value, comparisonType, StringNullStrategy.Ignore);

        public static bool AnyStartsWith(this IEnumerable<string> source, string value, StringNullStrategy nullStrategy)
            => AnyStartsWithImpl(source, value, StringComparison.Ordinal, nullStrategy);

        public static bool AnyStartsWith(this IEnumerable<string> source, string value, StringComparison comparisonType, StringNullStrategy nullStrategy)
            => AnyStartsWithImpl(source, value, comparisonType, nullStrategy);

        public static bool AnyStartsWith<T>(this IEnumerable<T> source, Func<T, string> selector, string value)
                => AnyStartsWith(source, selector, value, StringComparison.Ordinal, StringNullStrategy.Ignore);

        public static bool AnyStartsWith<T>(this IEnumerable<T> source, Func<T, string> selector, string value, StringComparison comparisonType)
            => AnyStartsWithImpl(source, selector, value, comparisonType, StringNullStrategy.Ignore);

        public static bool AnyStartsWith<T>(this IEnumerable<T> source, Func<T, string> selector, string value, StringNullStrategy nullStrategy)
            => AnyStartsWithImpl(source, selector, value, StringComparison.Ordinal, nullStrategy);

        public static bool AnyStartsWith<T>(this IEnumerable<T> source, Func<T, string> selector, string value, StringComparison comparisonType, StringNullStrategy nullStrategy)
            => AnyStartsWithImpl(source, selector, value, comparisonType, nullStrategy);

        private static bool AnyStartsWithImpl<T>(this IEnumerable<T> source, Func<T, string> selector, string value, StringComparison comparisonType, StringNullStrategy nullStrategy)
        {
            var exception = ValidateArguments(source, value) ?? ValidateArgument(selector);
            if (exception != null)
            {
                throw exception;
            }

            var values = source.Select(v => selector(v));
            return Impl(values, value, comparisonType, nullStrategy);
        }

        public static bool AnyStartsWithImpl(this IEnumerable<string> source, string value, StringComparison comparisonType, StringNullStrategy nullStrategy)
        {
            var exception = ValidateArguments(source, value);
            if (exception != null)
            {
                throw exception;
            }

            return Impl(source, value, comparisonType, nullStrategy);
        }

        public static bool Impl(this IEnumerable<string> source, string value, StringComparison comparisonType, StringNullStrategy nullStrategy)
        {
            source = source.ApplyNullStrategy(nullStrategy);
            return source.Any(v => v.StartsWith(value, comparisonType));
        }

        private static Exception ValidateArgument<T>(Func<T, string> selector)
        {
            if (selector == null)
            {
                return ExceptionCreationHelpers.CreateArgumentNullException(nameof(selector));
            }

            return null;
        }

        private static Exception ValidateArguments<T>(IEnumerable<T> source, string value)
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
    }
}
