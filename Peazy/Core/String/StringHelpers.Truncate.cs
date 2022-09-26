using System;
using Peazy.Internal;

namespace Peazy.Core
{
    internal static partial class StringHelpers
    {
        public static string Truncate(string value, int length, out bool truncated)
        {
            truncated = false;
            if (value == null)
            {
                throw ExceptionCreationHelpers.CreateArgumentNullException(nameof(value));
            }

            if (length < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(length), $"Argument must be a positive integer");
            }

            if (length == 0)
            {
                return string.Empty;
            }

            if (value.Length <= length)
            {
                return value;
            }

            truncated = true;

            #if NETCOREAPP3_1_OR_GREATER
            return value[..length];
            #else
            return value.Substring(0, length);
            #endif
        }
    }
}