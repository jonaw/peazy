using System;
using System.Collections.Generic;
using System.Linq;
using Peazy.Extensions;
using Peazy.Internal;

namespace Peazy.Core
{
    internal static partial class EnumerableHelpers
    {
        public static bool AnyStartsWith<T>(IEnumerable<T> source, Func<T, string> selector, string value, StringComparison comparisonType, StringNullStrategy nullStrategy)
        {
            var exception = ValidateArguments(source, value) ?? ValidateArgument(selector);
            if (exception != null)
            {
                throw exception;
            }

            var values = source.Select(v => selector(v));
            return AnyStartsWithCore(values, value, comparisonType, nullStrategy);
        }

        public static bool AnyStartsWith(IEnumerable<string> source, string value, StringComparison comparisonType, StringNullStrategy nullStrategy)
        {
            var exception = ValidateArguments(source, value);
            if (exception != null)
            {
                throw exception;
            }

            return AnyStartsWithCore(source, value, comparisonType, nullStrategy);
        }

        private static bool AnyStartsWithCore(IEnumerable<string> source, string value, StringComparison comparisonType, StringNullStrategy nullStrategy)
        {
            source = source.ApplyNullStrategy(nullStrategy);
            return source.Any(v => v.StartsWith(value, comparisonType));
        }
    }
}