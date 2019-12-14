using NUnit.Framework;
using System;
using Wxl.Extensions.IEnumerableExtensions;
using FluentAssertions;

namespace Wxl.Tests.Extensions.IEnumerableExtensions
{
    public class AnyContainsExtensionsTest : BaseTest<AnyContainsExtensionsTest>
    {
        private string[] _source;
        private string _value;
        private Func<string, string> _selector;
        private StringComparison _comparisonType;

        public AnyContainsExtensionsTest()
        {
            _test = this;
        }

        [SetUp]
        public void Setup()
        {
            _source = default;
            _value = default;
            _selector = default;
        }

        [Test]
        public void ThrowWhenSourceIsDefault()
        {
            Given.SourceIsDefault();
            And.ValueIsSubstringOfSourceElement();
            And.SelectorIsValid();
            Then.SourceAnyContainsAsAction().Should().Throw<ArgumentNullException>()
                .And.ParamName.Should().Be("source");
        }

        [Test]
        public void ReturnTrueWhenSourceHasElementsAndValueIsSubstringOfSourceElement()
        {
            Given.SourceHasElements();
            And.ValueIsSubstringOfSourceElement();
            And.SelectorIsValid();
            Then.SourceAnyContains().Should().BeTrue();
        }

        [Test]
        public void ThrowWhenValueIsDefault()
        {
            Given.SourceHasElements();
            And.ValueIsDefault();
            And.SelectorIsValid();
            Then.SourceAnyContainsAsAction().Should().Throw<ArgumentNullException>()
                .And.ParamName.Should().Be("value");
        }

        [Test]
        public void ThrowWhenSelectorIsDefault()
        {
            Given.SourceHasElements();
            And.ValueIsSubstringOfSourceElement();
            And.SelectorIsDefault();
            Then.SourceAnyContainsAsAction().Should().Throw<ArgumentNullException>()
                .And.ParamName.Should().Be("selector");
        }

        private bool SourceAnyContains()
        {
            return _source.AnyContains(_selector, _value, StringComparison.OrdinalIgnoreCase);
        }

        private Action SourceAnyContainsAsAction()
        {
            return () => _source.AnyContains(_selector, _value, StringComparison.OrdinalIgnoreCase);
        }

        private void SourceIsDefault()
        {
            _source = default;
        }

        private void SourceHasElements()
        {
            _source = new[] { "Element #1", "Element #2" };
        }

        private void ValueIsDefault()
        {
            _value = default;
        }

        private void ValueIsSubstringOfSourceElement()
        {
            _value = "#1";
        }

        private void SelectorIsDefault()
        {
            _selector = default;
        }

        private void SelectorIsValid()
        {
            _selector = (val) => val;
        }
    }
}
