using System;
using System.Collections.Generic;
using System.Linq;

namespace Wxl.Extensions.IEnumerableExtensions
{
    public static class AnyContainsExtensions
    {
        public static bool AnyContains<T>(this IEnumerable<T> source, Func<T, string> selector, string value, StringComparison comparisonType)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            if (selector == null)
            {
                throw new ArgumentNullException(nameof(selector));
            }

            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            return source.Any(v => selector(v).IndexOf(value, comparisonType) > -1);
        }

        public static bool AnyContains(this IEnumerable<string> source, string value, StringComparison comparisonType)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            return source.Any(v => v.IndexOf(value, comparisonType) > -1);
        }
    }
}
