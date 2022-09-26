namespace Peazy.Extensions
{
    /// <summary>
    /// Determine strategy for handling <see cref="null"/> values
    /// </summary>
    public enum StringNullStrategy : byte
    {
        /// <summary>Do not ignore <see cref="null"/> values</summary>
        None = 0,

        /// <summary>Skip <see cref="null"/> values </summary>
        Skip = 1
    }
}