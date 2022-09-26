using System;
using Peazy.Core;

namespace Peazy.Extensions
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// Determine if length of a given string is shorter than a given length
        /// </summary>
        /// <exception cref="ArgumentException">Thrown when <paramref name="length"/> is positive</exception>
        public static bool HasLength(this string value, int length)
            => StringHelpers.HasLength(value, length);

        /// <summary>
        /// Determine if length of a given string is shorter than a given length
        /// </summary>
        /// <exception cref="ArgumentException">Thrown when <paramref name="length"/> is positive</exception>
        public static bool IsShorterThan(this string value, int length)
            => StringHelpers.IsShorterThan(value, length);

        /// <summary>
        /// Ensure length of <paramref name="value"/> is longer than given <paramref name="length"/>
        /// </summary>
        /// <exception cref="ArgumentException">Thrown when <paramref name="length"/> is positive</exception>
        public static bool IsLongerThan(this string value, int length)
            => StringHelpers.IsLongerThan(value, length);
    }
}
