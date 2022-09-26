using FluentAssertions;
using NUnit.Framework;
using Peazy.Extensions;
using System;

namespace Peazy.Tests.Extensions.StringExtensionsTests
{
    public class StringTruncateExtensionsTest : BaseTest<StringTruncateExtensionsTest>
    {
        private string _value;
        private string _expectedValue;
        private int _length;

        public StringTruncateExtensionsTest()
        {
            _test = this;
        }

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ThrowWhenStringIsDefault()
        {
            Given.ValueIsDefault();
            And.LengthIs(10);
            Then.StringTruncateAsAction()
                .Should().Throw<ArgumentNullException>()
                .And.ParamName.Should().Be("value", "Because value is default");
        }

        [Test]
        public void ThrowWhenLengthIsNegative()
        {
            Given.ValueContains10Charaters();
            And.LengthIs(-1);

            Then.StringTruncateAsAction()
                .Should().Throw<ArgumentOutOfRangeException>()
                .And.ParamName.Should().Be("length");
        }

        [Test]
        public void ReturnSameWhenLengthLongerThanString()
        {
            Given.ValueContains10Charaters();
            And.LengthIs(int.MaxValue);
            And.ExpectedValueContains10Characters();

            Then.StringTruncate().Should().Be(ExpectedValue());
        }

        [Test]
        public void ReturnShorterWhenLengthSHorterThanString()
        {
            Given.ValueContains10Charaters();
            And.LengthIs(5);
            And.ExpectedValueContains5Characters();
            Then.StringTruncate().Should().Be(ExpectedValue());
        }

        private void ValueIsDefault()
        {
            _value = default;
        }

        private void ValueContains10Charaters()
        {
            _value = "0123456789";
        }

        private void ExpectedValueContains5Characters()
        {
            _expectedValue = "01234";
        }

        private void ExpectedValueContains10Characters()
        {
            _expectedValue = "0123456789";
        }

        private string ExpectedValue()
        {
            return _expectedValue;
        }

        private void LengthIs(int length)
        {
            _length = length;
        }

        private string StringTruncate()
        {
            return _value.Truncate(_length);
        }

        private Action StringTruncateAsAction()
        {
            return () => _value.Truncate(_length);
        }
    }
}
