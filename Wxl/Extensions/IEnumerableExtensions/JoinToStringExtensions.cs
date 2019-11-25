using System;
using System.Collections.Generic;
using System.Linq;

namespace Wxl.Extensions.IEnumerableExtensions
{
    public static class JoinToStringExtensions
    {
        public static string JoinToString<T>(this IEnumerable<T> source, string separator, bool ignoreNullValues = false)
        {
            return JoinToStringImpl(source, separator, null, ignoreNullValues);
        }

        public static string JoinToString<T>(
            this IEnumerable<T> source, 
            string separator,
            Func<T, string> valueSelector,
            bool ignoreNullValues = false)
        {
            return JoinToStringImpl(source, separator, valueSelector, ignoreNullValues);
        }

        private static string JoinToStringImpl<T>(
            IEnumerable<T> source, 
            string separator,  
            Func<T, string> valueSelector = null,
            bool ignoreNullValues = false)
        {
            var error = VerifyParams(source, separator, ignoreNullValues);
            if (error != null)
            {
                throw error;
            }

            if (ignoreNullValues)
            {
                source = source.Where(v => v != null);
            }

            var valuesToJoin = default(IEnumerable<string>);
            if (valueSelector != null)
            {
                valuesToJoin = source.Select(valueSelector);
            }
            else
            {
                valuesToJoin = source.Select(v => v.ToString());
            }

            return string.Join(separator, valuesToJoin);
        }

        private static Exception VerifyParams<T>(IEnumerable<T> source, string separator, bool ignoreNullValues)
        {
            if (source == null)
            {
                return CreateArgumentNullException(nameof(source));
            }

            if (separator == null)
            {
                return CreateArgumentNullException(nameof(separator));
            }

            if (source.Any(value => value == null) && !ignoreNullValues)
            {
                return new ArgumentException($"Argument {nameof(source)} cannot contain any element equal to null", nameof(source));
            }

            return null;
        }

        private static ArgumentNullException CreateArgumentNullException(string paramName)
        {
            return new ArgumentNullException(paramName, $"Argument {paramName} cannot be equal to null");
        }
    }
}
