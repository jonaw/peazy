using FluentAssertions;
using NUnit.Framework;
using System;

namespace Peazy.Tests.Extensions.NumericalExtensions.Map
{
    public abstract class BaseMapTest<Test, ValueType> : BaseTest<Test> where ValueType : IComparable
    {
        protected ValueType _value;
        protected ValueType _fromMin;
        protected ValueType _fromMax;
        protected ValueType _toMin;
        protected ValueType _toMax;

        [Test]
        public virtual void ReturnPositiveValueFromPositive()
        {
            ValidMappingValues();
            ValueMap().Should().Be(500);
        }

        [Test]
        public virtual void ReturnPositiveValueFromNegative()
        {
            NegativeFromRangeAndPositiveToRange();
            ValueMap().Should().Be(500);
        }

        protected abstract void NegativeFromRangeAndPositiveToRange();

        protected abstract void ValidMappingValues();

        protected abstract ValueType ValueMap();
    }
}
