using System;

namespace Peazy.Extensions.StringExtensions
{
    public static class StringTruncateExtensions
    {
        /// <summary>
        /// Truncate string to length
        /// </summary>
        /// <param name="value">Value to truncate</param>
        /// <param name="length">Max length of returned string</param>
        /// <returns>Truncated string</returns>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when <paramref name="length"/> is negative</exception>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> equals null</exception>
        public static string Truncate(this string value, int length)
        {
            return TruncateImpl(value, length);
        }

        private static string TruncateImpl(string value, int length)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value), "Argument cannot be null");
            }

            if (length < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(length), $"Argument must be a positive integer");
            }

            if (length == 0)
            {
                return string.Empty;
            }

            if (value.Length < length)
            {
                return string.Copy(value);
            }

            return value.Substring(0, length);
        }
    }
}
