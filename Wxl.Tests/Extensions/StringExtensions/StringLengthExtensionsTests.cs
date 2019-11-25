using NUnit.Framework;
using System;
using Wxl.Extensions.StringExtensions;
using FluentAssertions;

namespace Wxl.Tests.Extensions.StringExtensionsTests
{
    public class StringLengthExtensionsTests : BaseTest<StringLengthExtensionsTests>
    {
        private string _value;
        private int _length;

        public StringLengthExtensionsTests()
        {
            _test = this;
        }

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ReturnTrueWhenShorterThanIntMax()
        {
            Given.ValueIs10Characters();
            And.LengthIs(int.MaxValue);
            Then.ValueShorterLengthThan().Should().BeTrue();
        }

        [Test]
        public void ReturnTrueWhenShorterThanMax()
        {
            Given.ValueIs10Characters();
            And.LengthIs(20);
            Then.ValueShorterLengthThan().Should().BeTrue();
        }

        [Test]
        public void ThrowWhenLengthIsZero()
        {
            Given.ValueIs10Characters();
            And.LengthIs(0);
            Then.ValueShorterLengthThanAsAction()
                .Should().Throw<ArgumentOutOfRangeException>()
                .And.ParamName.Should().Be("length");
        }

        [Test]
        public void ThrowWhenLengthIsNegative()
        {
            Given.ValueIs10Characters();
            And.LengthIs(-1);
            Then.ValueShorterLengthThanAsAction()
                .Should().Throw<ArgumentOutOfRangeException>()
                .And.ParamName.Should().Be("length");
        }

        [Test]
        public void ThrowWhenValueIsDefault()
        {
            Given.ValueIsDefault();
            And.LengthIs(20);
            Then.ValueLongerLengthThanAsAction()
                .Should().Throw<ArgumentNullException>()
                .And.ParamName.Should().Be("value");
        }

        private bool ValueShorterLengthThan()
        {
            return _value.ShorterLengthThan(_length);
        }

        private Action ValueShorterLengthThanAsAction()
        {
            return () => ValueShorterLengthThan();
        }

        private bool ValueLongerLengthThan()
        {
            return _value.LongerLengthThan(_length);
        }

        private Action ValueLongerLengthThanAsAction()
        {
            return () => ValueLongerLengthThan();
        }

        protected void ValueIs10Characters()
        {
            _value = "0123456789";
        }

        protected void ValueIsDefault()
        {
            _value = default;
        }

        protected void LengthIs(int length)
        {
            _length = length;
        }

    }
}
