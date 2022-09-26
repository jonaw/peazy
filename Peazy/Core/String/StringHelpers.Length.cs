using System;

namespace Peazy.Core
{
    internal static partial class StringHelpers
    {
        public static bool HasLength(string value, int length)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value), "Argument cannot be null");
            }

            if (length <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(length), "Argument must be a positive integer");
            }

            return value.Length == length;
        }

        public static bool IsShorterThan(string value, int length)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value), "Argument cannot be null");
            }

            if (length <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(length), "Argument must be a positive integer");
            }

            // Max length of a string is equal to max value of int
            if (length == int.MaxValue)
            {
                return true;
            }

            return value.Length < length;
        }

        public static bool IsLongerThan(string value, int length)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value), "Argument cannot be null");
            }

            if (length <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(length), "Argument must be a positive integer");
            }

            // Max length of a string is equal to max value of int
            if (length == int.MaxValue)
            {
                return true;
            }

            return value.Length > length;
        }
    }
}