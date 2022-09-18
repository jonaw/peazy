using Peazy.Core;
using System;

namespace Peazy.Extensions
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// Truncate string to length
        /// </summary>
        /// <param name="value">Value to truncate</param>
        /// <param name="length">Max length of returned string</param>
        /// <returns>Returns a new string, truncated to given length</returns>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when <paramref name="length"/> is negative</exception>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> equals null</exception>
        /// <example>
        /// var x = "This is a test";
        /// var truncated = x.Truncate(7);
        /// // truncated - "This is"
        /// </example>
        public static string Truncate(this string value, int length)
            => StringHelpers.Truncate(value, length, out _);

        /// <summary>
        /// Truncate string to length
        /// </summary>
        /// <param name="value">Value to truncate</param>
        /// <param name="length">Max length of returned string</param>
        /// <param name="truncated">When this method returns, this reports if value has been truncated</param>
        /// <returns>Returns a new string, truncated to given length</returns>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when <paramref name="length"/> is negative</exception>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> equals null</exception>
        /// <example>
        /// var x = "This is a test";
        /// var truncated = x.Truncate(7);
        /// // truncated - "This is"
        /// </example>
        public static string Truncate(this string value, int length, out bool truncated)
            => StringHelpers.Truncate(value, length, out truncated);
    }
}
