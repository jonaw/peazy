using FluentAssertions;
using NUnit.Framework;
using Peazy.Extensions;
using Peazy.Tests.Extensions.StringExtensionsTests.Base;
using System;

namespace Peazy.Tests.Extensions.StringExtensionsTests
{
    public class StringIsNullExtensionsTest : BaseStringContentExtensionsTest<StringIsNullExtensionsTest>
    {
        public StringIsNullExtensionsTest()
        {
            _test = this;
        }

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ReturnTrueFromDefaultString()
        {
            Given.ValueIsDefault();
            Then.StringIsNullOrWhiteSpace().Should().BeTrue();
        }

        [Test]
        public void DontThrowFromDefaultString()
        {
            Given.ValueIsDefault();
            Then.StringIsNullOrWhiteSpaceAsAction().Should().NotThrow();
        }

        [Test]
        public void ReturnTrueFromWhiteSpaceString()
        {
            Given.ValueIsWhiteSpace();
            Then.StringIsNullOrWhiteSpace().Should().BeTrue();
        }

        [Test]
        public void ReturnTrueFromEmptyString()
        {
            Given.ValueIsEmpty();
            Then.StringIsNullOrEmpty().Should().BeTrue();
        }

        [Test]
        public void ReturnFalseFromStringWithContent()
        {
            Given.ValueContainsNonWhiteSpaceCharacters();
            Then.StringIsNullOrWhiteSpace().Should().BeFalse();
        }

        private bool StringIsNullOrWhiteSpace()
        {
            return _string.IsNullOrWhiteSpace();
        }

        private Action StringIsNullOrWhiteSpaceAsAction()
        {
            return () => _string.IsNullOrWhiteSpace();
        }

        private bool StringIsNullOrEmpty()
        {
            return _string.IsNullOrEmpty();
        }
    }

}