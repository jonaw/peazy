namespace Peazy.Extensions
{
    /// <summary>
    /// Determine strategy for handling null values
    /// </summary>
    public enum StringNullStrategy : byte
    {
        /// <summary>Do not ignore null values</summary>
        None = 0,

        /// <summary>Skip null values </summary>
        Skip = 1
    }
}