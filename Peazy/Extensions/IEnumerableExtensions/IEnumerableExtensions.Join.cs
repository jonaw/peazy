using System;
using System.Collections.Generic;
using Peazy.Core;

namespace Peazy.Extensions
{
    public static partial class IEnumerableExtensions
    {
        public static string JoinToString(this IEnumerable<string> source, string separator)
            => IEnumerableHelpers.JoinToString(source, separator, StringNullJoinStrategy.ReplaceWithEmptyString);

        public static string JoinToString(this IEnumerable<string> source, string separator, StringNullJoinStrategy nullStrategy)
            => IEnumerableHelpers.JoinToString(source, separator, nullStrategy);

        public static string JoinToString<T>(this IEnumerable<T> source, Func<T, string> selector, string separator)
            => IEnumerableHelpers.JoinToString(source, separator, selector, StringNullJoinStrategy.ReplaceWithEmptyString);

        public static string JoinToString<T>(this IEnumerable<T> source, Func<T, string> selector, string separator, StringNullJoinStrategy nullStrategy)
            => IEnumerableHelpers.JoinToString(source, separator, selector, nullStrategy);
    }
}
