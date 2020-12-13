using System;
using FluentAssertions;
using NUnit.Framework;
using Peazy.Helpers.DateTimeHelpers;

namespace Peazy.Tests.Helpers.DateTimeHelpers
{
    public class DateIntervalIntersectionHelpersTest : BaseTest<DateIntervalIntersectionHelpersTest>
    {
        private DateTime _aIntervalStart;
        private DateTime _aIntervalEnd;
        private DateTime _bIntervalStart;
        private DateTime _bIntervalEnd;

        private DateInterval _intervalStart;
        private DateInterval _intervalEnd;

        public DateIntervalIntersectionHelpersTest()
        {
            _test = this;
        }

        [SetUp]
        public void Setup()
        {
            _aIntervalStart = default;
            _aIntervalEnd = default;
            _bIntervalStart = default;
            _bIntervalEnd = default;
            _intervalStart = default;
            _intervalEnd = default;
        }

        [Test]
        public void ReturnTrueWhenIntervalsIntersect()
        {
            Given.IntersectionACoversPrimoAndMedioJanuary();
            And.IntersectionBCoversMedioAndUltimoJanuary();
            Then.IntervalsIntersect()
                .Should().BeTrue();
        }

        [Test]
        public void ReturnFalseWhenIntervalsDontIntersect()
        {
            Given.IntersectionACoversJanuary();
            And.IntersectionBCoversDecember();
            Then.IntervalsIntersect()
                .Should().BeFalse();
        }

        [Test]
        public void ReturnTrueWhenIntervalRangesIntersect()
        {
            Given.IntersectionACoversPrimoAndMedioJanuary();
            AIsStartInterval();
            And.IntersectionBCoversMedioAndUltimoJanuary();
            BIsEndInterval();
            Then.IntervalsIntersectWithInterval()
                .Should().BeTrue();
        }

        [Test]
        public void ReturnFalseWhenIntervalRangesDontIntersect()
        {
            Given.IntersectionACoversJanuary();
            And.AIsStartInterval();
            And.IntersectionBCoversDecember();
            And.BIsEndInterval();
            Then.IntervalsIntersectWithInterval()
                .Should().BeFalse();
        }

        private void IntersectionACoversJanuary()
        {
            _aIntervalStart = new DateTime(2019, 1, 1, 0, 0, 0);
            _aIntervalEnd = new DateTime(2019, 1, 31, 23, 59, 59);
        }

        private void IntersectionBCoversDecember()
        {
            _bIntervalStart = new DateTime(2019, 12, 1, 0, 0, 0);
            _bIntervalEnd = new DateTime(2019, 12, 31, 23, 59, 59);
        }

        private void IntersectionACoversPrimoAndMedioJanuary()
        {
            _aIntervalStart = new DateTime(2019, 1, 1, 0, 0, 0);
            _aIntervalEnd = new DateTime(2019, 1, 20, 23, 59, 59);
        }

        private void IntersectionBCoversMedioAndUltimoJanuary()
        {
            _bIntervalStart = new DateTime(2019, 1, 11, 0, 0, 0);
            _bIntervalEnd = new DateTime(2019, 1, 31, 23, 59, 59);
        }

        private void AIsStartInterval()
        {
            _intervalStart = new DateInterval(_aIntervalStart, _aIntervalEnd);
        }

        private void BIsEndInterval()
        {
            _intervalEnd = new DateInterval(_bIntervalStart, _bIntervalEnd);
        }

        private bool IntervalsIntersect()
        {
            return DateHelpers.IntervalsIntersect(
                _aIntervalStart,
                _aIntervalEnd,
                _bIntervalStart,
                _bIntervalEnd
                );
        }

        private Action IntervalsIntersectAsAction()
        {
            return () => IntervalsIntersect();
        }


        private bool IntervalsIntersectWithInterval()
        {
            return DateHelpers.IntervalsIntersect(
                _intervalStart,
                _intervalEnd
                );
        }

        private Action IntervalsIntersectWithIntervalAsAction()
        {
            return () => IntervalsIntersectWithInterval();
        }

    }
}
