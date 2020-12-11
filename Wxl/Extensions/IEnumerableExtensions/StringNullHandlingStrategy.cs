namespace Wxl.Extensions.IEnumerableExtensions
{
    public enum StringNullStrategy : byte
    {
        None = 0,
        Ignore = 1
    }

    public enum StringNullJoinStrategy : byte
    {
        None = 0,
        DiscardValue = 1,
        ReplaceWithEmptyString = 1
    }
}