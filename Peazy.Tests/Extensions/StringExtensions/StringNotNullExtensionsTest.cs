using FluentAssertions;
using NUnit.Framework;
using Peazy.Extensions;
using Peazy.Tests.Extensions.StringExtensionsTests.Base;
using System;

namespace Peazy.Tests.Extensions.StringExtensionsTests
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
            return _string.HasContentOrWhitespace();
        }

        private bool StringNotNullAndNotWhiteSpace()
        {
            return _string.HasContent();
        }

        private Action StringNotNullAndNotWhiteSpaceAsAction()
        {
            return () => StringNotNullAndNotWhiteSpace();
        }
    }
}
