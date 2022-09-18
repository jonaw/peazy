using Peazy.Core;

namespace Peazy.Extensions
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// Determines whether a given string is null, empty or white-space
        /// </summary>
        /// <param name="value">String to test</param>
        public static bool IsNullOrWhiteSpace(this string value)
            => string.IsNullOrWhiteSpace(value);

        /// <summary>
        /// Determines whether a given string is not null, not empty and not white-space
        /// </summary>
        /// <param name="value">String to test</param>
        public static bool HasContent(this string value)
            => !string.IsNullOrWhiteSpace(value);

        /// <summary>
        /// Determines whether a given string is null or empty
        /// </summary>
        /// <param name="value">String to test</param>
        public static bool IsNullOrEmpty(this string value)
            => string.IsNullOrEmpty(value);

        /// <summary>
        /// Determines whether a specific string is not null and not empty
        /// </summary>
        /// <param name="value">String to test</param>
        public static bool HasContentOrWhitespace(this string value)
            => !value.IsNullOrEmpty();

        public static bool IsIntegerString(this string value)
            => StringHelpers.IsIntegerString(value);
    }
}
