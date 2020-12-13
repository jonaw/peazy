namespace Peazy.Extensions.IEnumerableExtensions
{
    public enum StringNullJoinStrategy : byte
    {
        None = 0,
        DiscardValue = 1,
        ReplaceWithEmptyString = 1
    }
}