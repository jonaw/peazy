using Peazy.Core;
using System;
using System.Collections.Generic;

namespace Peazy.Extensions
{
    public static partial class EnumerableExtensions
    {
        /// <summary>
        /// Check if any item in an enumerable contains value. Compares values with <see cref="StringComparison.Ordinal"/>
        /// </summary>
        /// <param name="source">Source to seek for value</param>
        /// <param name="value">Value to seek for</param>
        /// <returns>Returns true if <paramref name="value"/> is found in any value in <paramref name="source"/>, else returns false</returns>
        public static bool AnyContains(this IEnumerable<string> source, string value)
            => EnumerableHelpers.AnyContains(source, value, StringComparison.Ordinal, StringNullStrategy.Skip);

        /// <summary>
        /// Check if any item in an enumerable contains value.
        /// </summary>
        /// <param name="source">Source to seek for value</param>
        /// <param name="value">Value to seek for</param>
        /// <param name="comparisonType">Comparison type to use when seeking for <paramref name="value"/> in <paramref name="source"/></param>
        /// <returns>Returns true if <paramref name="value"/> is found in any value in <paramref name="source"/>, else returns false</returns>
        public static bool AnyContains(this IEnumerable<string> source, string value, StringComparison comparisonType)
            => EnumerableHelpers.AnyContains(source, value, comparisonType, StringNullStrategy.Skip);

        /// <summary>
        /// Check if any item in an enumerable contains value.
        /// </summary>
        /// <param name="source">Source to seek for value</param>
        /// <param name="selector">Select what value of an item get checked against <paramref name="value"/></param>
        /// <param name="value">Value to seek for</param>
        /// <typeparam name="T">Type of enumerable</typeparam>
        /// <returns>Returns true if <paramref name="value"/> is found in any value in <paramref name="source"/>, given by <paramref name="selector"/>, else returns false</returns>
        public static bool AnyContains<T>(this IEnumerable<T> source, Func<T, string> selector, string value)
            => EnumerableHelpers.AnyContains(source, selector, value, StringComparison.Ordinal, StringNullStrategy.Skip);

        /// <summary>
        /// Check if any item in an enumerable contains value.
        /// </summary>
        /// <param name="source">Source to seek for value</param>
        /// <param name="selector">Select what value of an item get checked against <paramref name="value"/></param>
        /// <param name="value">Value to seek for</param>
        /// /// <param name="comparisonType">Comparison type to use when seeking for <paramref name="value"/> in <paramref name="source"/></param>
        /// <typeparam name="T">Type of enumerable</typeparam>
        /// <returns>Returns true if <paramref name="value"/> is found in any value in <paramref name="source"/>, given by <paramref name="selector"/>, else returns false</returns>
        public static bool AnyContains<T>(this IEnumerable<T> source, Func<T, string> selector, string value, StringComparison comparisonType)
            => EnumerableHelpers.AnyContains(source, selector, value, comparisonType, StringNullStrategy.Skip);
    }
}
