using System;

namespace Wxl.Extensions.StringExtensions
{
    public static class StringLengthExtensions
    {
        /// <summary>
        /// Determine if length of a given string is shorter than a given length
        /// </summary>
        /// <exception cref="ArgumentException">Thrown when <paramref name="length"/> is positive</exception>
        public static bool ShorterLengthThan(this string value, int length)
        {
            return ShorterLengthThanImpl(value, length);
        }

        /// <summary>
        /// Ensure length of <paramref name="value"/> is longer than given <paramref name="length"/>
        /// </summary>
        /// <exception cref="ArgumentException">Thrown when <paramref name="length"/> is positive</exception>
        public static bool LongerLengthThan(this string value, int length)
        {
            return LongerLengthThanImpl(value, length);
        }

        #region Implementations
        private static bool ShorterLengthThanImpl(string value, int length)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value), "Argument cannot be null");
            }

            if (length <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(length), $"Argument must be a positive integer");
            }

            // Max length of a string is equal to max value of int
            if (length == int.MaxValue)
            {
                return true;
            }

            return value.Length < length;
        }

        private static bool LongerLengthThanImpl(string value, int length)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value), "Argument cannot be null");
            }

            if (length <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(length), $"Argument must be a positive integer");
            }

            // Max length of a string is equal to max value of int
            if (length == int.MaxValue)
            {
                return true;
            }

            return value.Length > length;
        }
        #endregion
    }
}
