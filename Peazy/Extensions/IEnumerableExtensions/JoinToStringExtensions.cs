using System;
using System.Collections.Generic;
using System.Linq;
using Peazy.Internal;

namespace Peazy.Extensions.IEnumerableExtensions
{

    public static class JoinToStringExtensions
    {
        public static string JoinToString(this IEnumerable<string> source, string separator)
            => JoinToStringImpl(source, separator, StringNullJoinStrategy.ReplaceWithEmptyString);

        public static string JoinToString(this IEnumerable<string> source, string separator, StringNullJoinStrategy nullStrategy)
            => JoinToStringImpl(source, separator, nullStrategy);

        public static string JoinToString<T>(this IEnumerable<T> source, Func<T, string> selector, string separator)
            => JoinToStringImpl(source, separator, selector, StringNullJoinStrategy.ReplaceWithEmptyString);

        public static string JoinToString<T>(this IEnumerable<T> source, Func<T, string> selector, string separator, StringNullJoinStrategy nullStrategy)
            => JoinToStringImpl(source, separator, selector, nullStrategy);

        private static string JoinToStringImpl(
            IEnumerable<string> source,
            string separator,
            StringNullJoinStrategy nullStrategy)
        {
            var exception = ValidateArguments(source, separator);
            if (exception != null)
            {
                throw exception;
            }

            return Impl(source, separator, nullStrategy);
        }

        private static string JoinToStringImpl<T>(
            IEnumerable<T> source,
            string separator,
            Func<T, string> selector,
            StringNullJoinStrategy nullStrategy)
        {
            var exception = ValidateArguments(source, separator) ?? ValidateArgument(selector);
            if (exception != null)
            {
                throw exception;
            }

            var values = source.Select(selector);
            return Impl(values, separator, nullStrategy);
        }

        private static string Impl(
            IEnumerable<string> source,
            string separator,
            StringNullJoinStrategy nullStrategy)
        {
            var values = ApplyNullStrategy(source, nullStrategy);
            return string.Join(separator, values);
        }

        private static IEnumerable<string> ApplyNullStrategy(
            IEnumerable<string> source,
            StringNullJoinStrategy nullStrategy)
        {
            if (nullStrategy == StringNullJoinStrategy.DiscardValue)
            {
                source = source.Where(v => v != null);
            }
            else if (nullStrategy == StringNullJoinStrategy.ReplaceWithEmptyString)
            {
                source = source.Select(v => v ?? string.Empty);
            }

            return source;
        }

        private static Exception ValidateArgument<T>(Func<T, string> selector)
        {
            if (selector == null)
            {
                return ExceptionCreationHelpers.CreateArgumentNullException(nameof(selector));
            }

            return null;
        }

        private static Exception ValidateArguments<T>(IEnumerable<T> source, string separator)
        {
            if (source == null)
            {
                return ExceptionCreationHelpers.CreateArgumentNullException(nameof(source));
            }

            if (separator == null)
            {
                return ExceptionCreationHelpers.CreateArgumentNullException(nameof(separator));
            }

            return null;
        }
    }
}
