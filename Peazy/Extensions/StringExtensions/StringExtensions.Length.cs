using System;

namespace Peazy.Extensions
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// Determine if length of a given string is shorter than a given length
        /// </summary>
        /// <exception cref="ArgumentException">Thrown when <paramref name="length"/> is positive</exception>
        public static bool HasLength(this string value, int length)
            => HasLengthImpl(value, length);

        /// <summary>
        /// Determine if length of a given string is shorter than a given length
        /// </summary>
        /// <exception cref="ArgumentException">Thrown when <paramref name="length"/> is positive</exception>
        public static bool IsShorterThan(this string value, int length)
            => IsShorterThanImpl(value, length);

        /// <summary>
        /// Ensure length of <paramref name="value"/> is longer than given <paramref name="length"/>
        /// </summary>
        /// <exception cref="ArgumentException">Thrown when <paramref name="length"/> is positive</exception>
        public static bool IsLongerThan(this string value, int length)
            => IsLongerThanImpl(value, length);

        #region Implementations
        private static bool HasLengthImpl(string value, int length)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value), "Argument cannot be null");
            }

            if (length <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(length), $"Argument must be a positive integer");
            }

            return value.Length == length;
        }

        private static bool IsShorterThanImpl(string value, int length)
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

        private static bool IsLongerThanImpl(string value, int length)
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
