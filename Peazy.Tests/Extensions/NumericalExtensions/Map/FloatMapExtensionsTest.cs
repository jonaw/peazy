using Peazy.Extensions;

namespace Peazy.Tests.Extensions.NumericalExtensions.Map
{

    public class FloatMapExtensionsTest : BaseMapTest<FloatMapExtensionsTest, float>
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
            _value = 2.5f;
            _fromMin = 0;
            _fromMax = 5;
            _toMin = 0;
            _toMax = 1000;
        }

        protected override float ValueMap()
        {
            return _value.Map(_fromMin, _fromMax, _toMin, _toMax);
        }
    }

}
