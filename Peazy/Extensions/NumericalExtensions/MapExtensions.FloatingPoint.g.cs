/*******************************************************************************
*                                                                              *
*                            THIS FILE IS GENERATED                            *
*                                                                              *
*******************************************************************************/
using Peazy.Core;

namespace Peazy.Extensions
{
    public static partial class MapExtensions
    {
                                                /// <summary>
        /// Map a value contained in a source range to value in a target range.
        /// </summary>
        /// <param name="value">Value to map</param>
        /// <param name="sourceMin">Source range minimum value</param>
        /// <param name="sourceMax">Source range maximum value</param>
        /// <param name="targetMin">Target range minimum value</param>
        /// <param name="targetMax">Target range maximum value</param>
        /// <returns>Returns the mapped value</returns>
        public static decimal Map(this decimal value, decimal sourceMin, decimal sourceMax, decimal targetMin, decimal targetMax)
            => NumericHelpers.Map(value, sourceMin, sourceMax, targetMin, targetMax);

        /// <summary>
        /// Map a value contained in a source range to value in a target range.
        /// </summary>
        /// <param name="value">Value to map</param>
        /// <param name="sourceMin">Source range minimum value</param>
        /// <param name="sourceMax">Source range maximum value</param>
        /// <param name="targetMin">Target range minimum value</param>
        /// <param name="targetMax">Target range maximum value</param>
        /// <returns>Returns the mapped value</returns>
        public static double Map(this double value, double sourceMin, double sourceMax, double targetMin, double targetMax)
            => NumericHelpers.Map(value, sourceMin, sourceMax, targetMin, targetMax);

        /// <summary>
        /// Map a value contained in a source range to value in a target range.
        /// </summary>
        /// <param name="value">Value to map</param>
        /// <param name="sourceMin">Source range minimum value</param>
        /// <param name="sourceMax">Source range maximum value</param>
        /// <param name="targetMin">Target range minimum value</param>
        /// <param name="targetMax">Target range maximum value</param>
        /// <returns>Returns the mapped value</returns>
        public static float Map(this float value, float sourceMin, float sourceMax, float targetMin, float targetMax)
            => NumericHelpers.Map(value, sourceMin, sourceMax, targetMin, targetMax);

    }
}