namespace Peazy.Extensions.StringExtensions
{
    public static class StringContentExtensions
    {
        /// <summary>
        /// Determines whether a given string is null, empty or white-space
        /// </summary>
        /// <param name="value">String to test</param>
        public static bool IsNullOrWhiteSpace(this string value)
        {
            return string.IsNullOrWhiteSpace(value);
        }

        /// <summary>
        /// Determines whether a given string is not null, not empty and not white-space
        /// </summary>
        /// <param name="value">String to test</param>
        public static bool NotNullAndNotWhiteSpace(this string value)
        {
            return !string.IsNullOrWhiteSpace(value);
        }

        /// <summary>
        /// Determines whether a given string is null or empty
        /// </summary>
        /// <param name="value">String to test</param>
        public static bool IsNullOrEmpty(this string value)
        {
            return value == null || value == string.Empty;
        }

        /// <summary>
        /// Determines whether a specific string is not null and not empty
        /// </summary>
        /// <param name="value">String to test</param>
        public static bool NotNullAndNotEmpty(this string value)
        {
            return value != null && value != string.Empty;
        }
    }
}
