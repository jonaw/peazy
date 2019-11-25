using FluentAssertions;
using NUnit.Framework;
using System;
using Wxl.Extensions.StringExtensions;
using Wxl.Tests.Extensions.StringExtensionsTests.Base;

namespace Wxl.Tests.Extensions.StringExtensionsTests
{
    public class StringNotNullExtensionsTest : BaseStringContentExtensionsTest<StringNotNullExtensionsTest>
    {
        public StringNotNullExtensionsTest()
        {
            _test = this;
        }

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ReturnFalseWhenDefault()
        {
            Given.ValueIsDefault();
            Then.StringNotNullAndNotWhiteSpace().Should().BeFalse();
        }

        [Test]
        public void DontThrowWhenDefault()
        {
            Given.ValueIsDefault();
            Then.StringNotNullAndNotWhiteSpaceAsAction()
                .Should().NotThrow();
        }

        [Test]
        public void ReturnFalseWhenWhiteSpace()
        {
            Given.ValueIsWhiteSpace();
            Then.StringNotNullAndNotWhiteSpace()
                .Should().BeFalse();
        }

        [Test]
        public void ReturnFalseWhenEmpty()
        {
            Given.ValueIsEmpty();
            Then.StringNotNullAndNotWhiteSpace().Should().BeFalse();
        }

        [Test]
        public void ReturnTrueWhenStringHasContent()
        {
            Given.ValueContainsNonWhiteSpaceCharacters();
            Then.StringNotNullAndNotWhiteSpace()
                .Should().BeTrue();
        }

        private bool StringNotNullAndNotEmpty()
        {
            return _string.NotNullAndNotEmpty();
        }

        private bool StringNotNullAndNotWhiteSpace()
        {
            return _string.NotNullAndNotWhiteSpace();
        }

        private Action StringNotNullAndNotWhiteSpaceAsAction()
        {
            return () => StringNotNullAndNotWhiteSpace();
        }
    }
}
