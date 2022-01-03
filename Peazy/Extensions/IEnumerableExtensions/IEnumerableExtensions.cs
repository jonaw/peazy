using Peazy.Internal;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Peazy.Extensions
{
    public static partial class IEnumerableExtensions
    {
        public static DateTime MinDateBy<T>(this IEnumerable<T> elements, Func<T, DateTime> selector)
        {
            return elements.Select(selector).Min();
        }

        public static DateTime MaxDateBy<T>(this IEnumerable<T> elements, Func<T, DateTime> selector)
        {
            return elements.Select(selector).Max();
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
