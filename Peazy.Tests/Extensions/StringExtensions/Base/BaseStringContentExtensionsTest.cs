namespace Peazy.Tests.Extensions.StringExtensionsTests.Base
{
    public abstract class BaseStringContentExtensionsTest<T> : BaseTest<T>
    {
        protected string _string;

        protected void ValueIsDefault()
        {
            _string = default;
        }

        protected void ValueIsWhiteSpace()
        {
            _string = " \n\r\t";
        }

        protected void ValueIsEmpty()
        {
            _string = string.Empty;
        }

        protected void ValueContainsNonWhiteSpaceCharacters()
        {
            _string = "test";
        }
    }
}
