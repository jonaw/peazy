using System;
using System.Collections.Generic;
using System.Linq;
using Peazy.Extensions;
using Peazy.Internal;

namespace Peazy.Core
{
    internal static partial class EnumerableHelpers
    {
		public static bool AnyContains(IEnumerable<string> source, string value, StringComparison comparisonType, StringNullStrategy nullStrategy)
        {
            var exception = ValidateArguments(source, value);
            if (exception != null)
            {
                throw exception;
            }

            source = source.ApplyNullStrategy(nullStrategy);
            return source.Any(v => v.IndexOf(value, comparisonType) > -1);
        }

        public static bool AnyContains<T>(IEnumerable<T> source, Func<T, string> selector, string value, StringComparison comparisonType, StringNullStrategy nullStrategy)
        {
            var exception = ValidateArguments(source, value) ?? ValidateArgument(selector);
            if (exception != null)
            {
                throw exception;
            }

            source = source.ApplyNullStrategy(nullStrategy);
            var values = source.Select(selector);

            return values.Any(v => v.IndexOf(value, comparisonType) > -1);
        }
    }
}