using FluentAssertions;
using NUnit.Framework;
using Peazy.Extensions;
using System;
using System.Linq;

namespace Peazy.Tests.Extensions.IEnumerableExtensions
{
    public class JoinToStringExtensionsTest : BaseTest<JoinToStringExtensionsTest>
    {
        private string[] _values;
        private string _result;
        private string _delimiter;
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
            Then.ValuesJoinedToStringWithSelector()
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
        }

        private void ValueSelectorGetsFirstFiveCharacters()
        {
            _valueSelector = (str) => str.Substring(0, 5);
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
            return _values.JoinToString(_delimiter, StringNullJoinStrategy.Skip);
        }

        private string ValuesJoinedToStringAndDontSkip()
        {
            return _values.JoinToString(_delimiter, StringNullJoinStrategy.None);
        }

        private string ValuesJoinedToStringWithSelector()
        {
            return _values.JoinToString(_valueSelector, _delimiter, StringNullJoinStrategy.Skip);
        }

        private Action ValuesJoinedToStringAsAction()
        {
            return () => ValuesJoinedToString();
        }

        private Action ValuesJoinedToStringAndDontSkipAsAction()
        {
            return () => ValuesJoinedToStringAndDontSkip();
        }

        private Action ValuesJoinedToStringWithSelectorAsAction()
        {
            return () => ValuesJoinedToStringWithSelector();
        }
    }
}
