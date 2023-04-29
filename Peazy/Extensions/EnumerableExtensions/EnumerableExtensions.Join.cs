using System;
using System.Collections.Generic;
using Peazy.Core;

namespace Peazy.Extensions
{
    public static partial class EnumerableExtensions
    {
        /// <summary>
        /// Join values of an enumerable to a string. Null values defaults to <see cref="StringNullJoinStrategy.ReplaceWithEmptyString"/>
        /// </summary>
        /// <param name="source">Items to join to a string</param>
        /// <param name="separator">Separator value to join items with</param>
        /// <returns>Returns a new string containing each value in <paramref name="source"/> separated by <paramref name="separator"/></returns>
        public static string JoinToString(this IEnumerable<string> source, string separator)
            => EnumerableHelpers.JoinToString(source, separator, StringNullJoinStrategy.ReplaceWithEmptyString);

        /// <summary>
        /// Join values of an enumerable to a string.
        /// </summary>
        /// <param name="source">Items to join to a string</param>
        /// <param name="separator">Separator value to join items with</param>
        /// <param name="nullStrategy">Strategy for handling null values contained in <paramref name="source"/></param>
        /// <returns>Returns a new string containing each value in <paramref name="source"/> separated by <paramref name="separator"/></returns>
        public static string JoinToString(this IEnumerable<string> source, string separator, StringNullJoinStrategy nullStrategy)
            => EnumerableHelpers.JoinToString(source, separator, nullStrategy);

        /// <summary>
        /// Join values of an enumerable to a string. Null values defaults to <see cref="StringNullJoinStrategy.ReplaceWithEmptyString"/>
        /// </summary>
        /// <param name="source">Items to join to a string</param>
        /// <param name="selector">Select value to use when joining to string</param>
        /// <param name="separator">Separator value to join items with</param>
        /// <returns>Returns a new string containing each value in <paramref name="source"/> separated by <paramref name="separator"/></returns>
        public static string JoinToString<T>(this IEnumerable<T> source, Func<T, string> selector, string separator)
            => EnumerableHelpers.JoinToString(source, separator, selector, StringNullJoinStrategy.ReplaceWithEmptyString);

        /// <summary>
        /// Join values of an enumerable to a string.
        /// </summary>
        /// <param name="source">Items to join to a string</param>
        /// <param name="selector">Select value to use when joining to string</param>
        /// <param name="separator">Separator value to join items with</param>
        /// <param name="nullStrategy">Strategy for handling null values contained in <paramref name="source"/></param>
        /// <returns>Returns a new string containing each value in <paramref name="source"/> separated by <paramref name="separator"/></returns>
        public static string JoinToString<T>(this IEnumerable<T> source, Func<T, string> selector, string separator, StringNullJoinStrategy nullStrategy)
            => EnumerableHelpers.JoinToString(source, separator, selector, nullStrategy);
    }
}
