using NUnit.Framework;
using System;
using Wxl.Extensions.IEnumerableExtensions;
using FluentAssertions;
using System.Linq;

namespace Wxl.Tests.Extensions.IEnumerableExtensions
{
    public class JoinToStringExtensionsTest : BaseTest<JoinToStringExtensionsTest>
    {
        private string[] _values;
        private string _result;
        private string _delimiter;
        private bool _ignoreNullValues;
        private Func<string, string> _valueSelector;

        public JoinToStringExtensionsTest()
        {
            _test = this;
        }

        [SetUp]
        public void Setup()
        {
            _result = "0123456789,0123456789";
            _delimiter = ",";
            _ignoreNullValues = false;
            _valueSelector = null;
        }

        [TestCase]
        public void ReturnExpectedResult()
        {
            Given.ValuesContainAllValidStrings();
            And.ExpextFullCharacterResult();
            Then.ValuesJoinedToString()
                .Should().Be(ExpectedResult(), "Because all values do not equal null");
        }

        [TestCase]
        public void ReturnExpectedResultWithSelector()
        {
            Given.ValuesContainAllValidStrings();
            And.ValueSelectorGetsFirstFiveCharacters();
            And.ExpectTruncatedResult();
            Then.ValuesJoinedToString()
                .Should().Be(ExpectedResult(), "Because all values do not equal null");
        }

        [TestCase]
        public void ThrowWhenValueIsNull()
        {
            Given.ValuesIsDefault();
            Then.ValuesJoinedToStringAsAction()
                .Should().Throw<ArgumentNullException>()
                .And.ParamName.Should().Be("source", "Because values equals null");
        }

        [TestCase]
        public void ThrowWhenSeparatorIsNull()
        {
            Given.DelimiterIsNull();
            And.ValuesContainAllValidStrings();
            Then.ValuesJoinedToStringAsAction()
                .Should().Throw<ArgumentNullException>()
                .And.ParamName.Should().Be("separator", "Because separator equals null");
        }

        [TestCase]
        public void ReturnEmptyStringWhenNoValues()
        {
            Given.ValuesIsEmpty();
            And.ExpectEmptyResult();
            Then.ValuesJoinedToString()
                .Should().Be(ExpectedResult(), "Because values is empty");
        }

        [TestCase]
        public void ThrowWhenValuesContainNull()
        {
            Given.ValuesContainOnlyNullElement();
            Then.ValuesJoinedToStringAsAction()
                .Should().Throw<ArgumentException>()
                .And.ParamName.Should().Be("source", "Because values contains at least one element that equals null");
        }

        [Test]
        public void ReturnEmptyString()
        {
            Given.ValuesContainOnlyNullElement();
            And.IgnoreNullValues();
            And.ExpectEmptyResult();
            Then.ValuesJoinedToString()
                .Should().BeEmpty();
        }

        private string[] ValuesContainOnlyNullElement()
        {
            _values = new[]
            {
                default(string)
            };

            return _values;
        }

        private string[] ValuesIsEmpty()
        {
            _values = new string[] { };
            return _values;
        }

        private string[] ValuesIsDefault()
        {
            _values = default;
            return _values;
        }

        private string[] ValuesContainAllValidStrings()
        {
            _values = new[]
            {
                "0123456789",
                "0123456789",
            };

            return _values;
        }

        private void DelimiterIsNull()
        {
            _delimiter = null;
        }

        private void IgnoreNullValues()
        {
            _ignoreNullValues = true;
        }

        private void ValueSelectorGetsFirstFiveCharacters()
        {
            _valueSelector = (str) =>
            {
                return str.Substring(0, 5);
            };
        }

        private void ExpectEmptyResult()
        {
            _result = string.Empty;
        }

        private void ExpextFullCharacterResult()
        {
            var expected = string.Join(_delimiter, _values);
            _result = expected;
        }

        private void ExpectTruncatedResult()
        {
            var values = _values.Select(_valueSelector);
            var expected = string.Join(_delimiter, values);
            _result = expected;
        }

        private string ExpectedResult()
        {
            return _result;
        }

        private string ValuesJoinedToString()
        {
            return _values.JoinToString(_delimiter, _valueSelector, _ignoreNullValues);
        }

        private Action ValuesJoinedToStringAsAction()
        {
            return () => ValuesJoinedToString();
        }
    }
}
