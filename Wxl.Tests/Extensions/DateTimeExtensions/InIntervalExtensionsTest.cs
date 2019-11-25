using NUnit.Framework;
using System;
using Wxl.Extensions.DateTimeExtensions;
using FluentAssertions;

namespace Wxl.Tests.Extensions.DateTimeExtensions
{
    public class InIntervalExtensionsTest : BaseTest<InIntervalExtensionsTest>
    {
        private DateTime _value;
        private DateTime _intervalStart;
        private DateTime _intervalEnd;

        public InIntervalExtensionsTest()
        {
            _test = this;
        }

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void IntersectingIntervalsReturnsTrue()
        {
            Given.ValueIsFirstOfJanuary2019();
            And.IntervalCoversJanuary2019();
            Then.ValueIsInInterval()
                .Should().BeTrue();
        }

        [Test]
        public void IntervalsNotIntersectingReturnsFalse()
        {
            Given.ValueIsFirstOfFebruary2019();
            And.IntervalCoversJanuary2019();
            Then.ValueIsInInterval()
                .Should().BeFalse();
        }

        [Test]
        public void AllDatesEqualReturnsTrue()
        {
            Given.ValueIsFirstOfJanuary2019();
            And.IntervalCoversFirstOfJanuary2019();
            Then.ValueIsInInterval()
                .Should().BeTrue();
        }

        [Test]
        public void ThrowWhenIntervalStartsAfterEnd()
        {
            Given.ValueIsFirstOfJanuary2019();
            And.IntervalCoversErroneousDates();
            Then.ValueIsInIntervalAsAction()
                .Should().Throw<ArgumentException>()
                .And.ParamName.Should().Be("intervalStart");
        }

        private void ValueIsFirstOfJanuary2019()
        {
            _value = new DateTime(2019, 1, 1);
        }

        private void ValueIsFirstOfFebruary2019()
        {
            _value = new DateTime(2019, 2, 1);
        }

        private void IntervalCoversJanuary2019()
        {
            _intervalStart = new DateTime(2019, 1, 1, 0, 0, 0);
            _intervalEnd = new DateTime(2019, 1, 31, 23, 59, 59);
        }

        private void IntervalCoversFirstOfJanuary2019()
        {
            _intervalStart = new DateTime(2019, 1, 1, 0, 0, 0);
            _intervalEnd = new DateTime(2019, 1, 1, 0, 0, 0);
        }

        private void IntervalCoversErroneousDates()
        {
            _intervalStart = new DateTime(2019, 2, 1, 0, 0, 0);
            _intervalEnd = new DateTime(2019, 1, 1, 0, 0, 0);
        }

        private bool ValueIsInInterval()
        {
            return _value.InInterval(_intervalStart, _intervalEnd);
        }

        private Action ValueIsInIntervalAsAction()
        {
            return () => ValueIsInInterval();
        }    
    }
}
