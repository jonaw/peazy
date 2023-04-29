namespace Peazy.Extensions
{
    /// <summary>
    /// Determine strategy for handling null values then joining values to string
    /// </summary>
    public enum StringNullJoinStrategy : byte
    {
        /// <summary>Do not ignore null values when joining values to string</summary>
        None = 0,

        /// <summary>Skip null values when joining values to string</summary>
        Skip = 1,

        /// <summary>Replace null values with an empty string when joining values to string</summary>
        ReplaceWithEmptyString = 2
    }
}