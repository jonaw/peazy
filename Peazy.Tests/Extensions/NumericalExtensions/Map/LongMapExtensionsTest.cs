using Peazy.Extensions.NumericalExtensions;

namespace Peazy.Tests.Extensions.NumericalExtensions.Map
{
    public class LongMapExtensionsTest : BaseMapTest<LongMapExtensionsTest, long>
    {
        protected override void NegativeFromRangeAndPositiveToRange()
        {
            _value = -50;
            _fromMin = -100;
            _fromMax = 0;
            _toMin = 0;
            _toMax = 1000;
        }

        protected override void ValidMappingValues()
        {
            _value = 100;
            _fromMin = 0;
            _fromMax = 200;
            _toMin = 0;
            _toMax = 1000;
        }

        protected override long ValueMap()
        {
            return _value.Map(_fromMin, _fromMax, _toMin, _toMax);
        }
    }

}
