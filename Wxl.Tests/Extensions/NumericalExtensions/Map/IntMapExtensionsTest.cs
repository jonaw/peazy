using Wxl.Extensions.NumericalExtensions;

namespace Wxl.Tests.Extensions.NumericalExtensions.Map
{
    public class IntMapExtensionsTest : BaseMapTest<IntMapExtensionsTest, int>
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

        protected override int ValueMap()
        {
            return _value.Map(_fromMin, _fromMax, _toMin, _toMax);
        }
    }

}
