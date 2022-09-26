using System;
using System.Collections.Generic;
using System.Linq;
using Peazy.Extensions;
using Peazy.Internal;

namespace Peazy.Core
{
    internal static partial class EnumerableHelpers
    {
        public static string JoinToString(
            IEnumerable<string> source,
            string separator,
            StringNullJoinStrategy nullStrategy)
        {
            var exception = ValidateJoinArguments(source, separator);
            if (exception != null)
            {
                throw exception;
            }

            return JoinToStringCore(source, separator, nullStrategy);
        }

        public static string JoinToString<T>(
            IEnumerable<T> source,
            string separator,
            Func<T, string> selector,
            StringNullJoinStrategy nullStrategy)
        {
            var exception = ValidateJoinArguments(source, separator) ?? ValidateArgument(selector);
            if (exception != null)
            {
                throw exception;
            }

            var values = source.Select(selector);
            return JoinToStringCore(values, separator, nullStrategy);
        }

        private static string JoinToStringCore(
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
            if (nullStrategy == StringNullJoinStrategy.Skip)
            {
                return source.Where(v => v != null);
            }
            else if (nullStrategy == StringNullJoinStrategy.ReplaceWithEmptyString)
            {
                return source.Select(v => v ?? string.Empty);
            }

            return source;
        }
    }
}