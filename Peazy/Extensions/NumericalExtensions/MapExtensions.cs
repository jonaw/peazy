/*******************************************************************************
*                                                                              *
*                            THIS FILE IS GENERATED                            *
*                                                                              *
*******************************************************************************/
using Peazy.Internal.Numeric;
using System;

namespace Peazy.Extensions
{
    public static class MapExtensions
    {

        // ! THIS FILE IS GENERATED !

        /// <summary>
        /// Map a value from one range to another. Utilizes <see cref="MidpointRounding.ToEven"/> when rounding mapped value to integer
        /// </summary>
        /// <param name="value">Value to map</param>
        /// <param name="sourceMin">Source range minimum value</param>
        /// <param name="sourceMax">Souce range maximum value</param>
        /// <param name="targetMin">Target range minimum value</param>
        /// <param name="targetMax">Target range maximum value</param>
        /// <returns>Returns the mapped value</returns>
        public static ulong Map(this ulong value, ulong sourceMin, ulong sourceMax, ulong targetMin, ulong targetMax)
            => value.Map(sourceMin, sourceMax, targetMin, targetMax, MidpointRounding.ToEven);

        /// <summary>
        /// Map a value from one range to another
        /// </summary>
        /// <param name="value">Value to map</param>
        /// <param name="sourceMin">Source range minimum value</param>
        /// <param name="sourceMax">Souce range maximum value</param>
        /// <param name="targetMin">Target range minimum value</param>
        /// <param name="targetMax">Target range maximum value</param>
        /// <param name="mode">Rounding mode</param>
        /// <returns>Returns the mapped value</returns>
        public static ulong Map(this ulong value, ulong sourceMin, ulong sourceMax, ulong targetMin, ulong targetMax, MidpointRounding roundingMode)
            => MapImpl(value, sourceMin, sourceMax, targetMin, targetMax, roundingMode);

        private static ulong MapImpl(ulong value, ulong sourceMin, ulong sourceMax, ulong targetMin, ulong targetMax, MidpointRounding roundingMode)
        {
            var mappedAndRoundedValue = MapAndRound(value, sourceMin, sourceMax, targetMin, targetMax, roundingMode);
            var result = Convert.ToUInt64(mappedAndRoundedValue);

            return result;
        }


        // ! THIS FILE IS GENERATED !

        /// <summary>
        /// Map a value from one range to another. Utilizes <see cref="MidpointRounding.ToEven"/> when rounding mapped value to integer
        /// </summary>
        /// <param name="value">Value to map</param>
        /// <param name="sourceMin">Source range minimum value</param>
        /// <param name="sourceMax">Souce range maximum value</param>
        /// <param name="targetMin">Target range minimum value</param>
        /// <param name="targetMax">Target range maximum value</param>
        /// <returns>Returns the mapped value</returns>
        public static long Map(this long value, long sourceMin, long sourceMax, long targetMin, long targetMax)
            => value.Map(sourceMin, sourceMax, targetMin, targetMax, MidpointRounding.ToEven);

        /// <summary>
        /// Map a value from one range to another
        /// </summary>
        /// <param name="value">Value to map</param>
        /// <param name="sourceMin">Source range minimum value</param>
        /// <param name="sourceMax">Souce range maximum value</param>
        /// <param name="targetMin">Target range minimum value</param>
        /// <param name="targetMax">Target range maximum value</param>
        /// <param name="mode">Rounding mode</param>
        /// <returns>Returns the mapped value</returns>
        public static long Map(this long value, long sourceMin, long sourceMax, long targetMin, long targetMax, MidpointRounding roundingMode)
            => MapImpl(value, sourceMin, sourceMax, targetMin, targetMax, roundingMode);

        private static long MapImpl(long value, long sourceMin, long sourceMax, long targetMin, long targetMax, MidpointRounding roundingMode)
        {
            var mappedAndRoundedValue = MapAndRound(value, sourceMin, sourceMax, targetMin, targetMax, roundingMode);
            var result = Convert.ToInt64(mappedAndRoundedValue);

            return result;
        }


        // ! THIS FILE IS GENERATED !

        /// <summary>
        /// Map a value from one range to another. Utilizes <see cref="MidpointRounding.ToEven"/> when rounding mapped value to integer
        /// </summary>
        /// <param name="value">Value to map</param>
        /// <param name="sourceMin">Source range minimum value</param>
        /// <param name="sourceMax">Souce range maximum value</param>
        /// <param name="targetMin">Target range minimum value</param>
        /// <param name="targetMax">Target range maximum value</param>
        /// <returns>Returns the mapped value</returns>
        public static uint Map(this uint value, uint sourceMin, uint sourceMax, uint targetMin, uint targetMax)
            => value.Map(sourceMin, sourceMax, targetMin, targetMax, MidpointRounding.ToEven);

        /// <summary>
        /// Map a value from one range to another
        /// </summary>
        /// <param name="value">Value to map</param>
        /// <param name="sourceMin">Source range minimum value</param>
        /// <param name="sourceMax">Souce range maximum value</param>
        /// <param name="targetMin">Target range minimum value</param>
        /// <param name="targetMax">Target range maximum value</param>
        /// <param name="mode">Rounding mode</param>
        /// <returns>Returns the mapped value</returns>
        public static uint Map(this uint value, uint sourceMin, uint sourceMax, uint targetMin, uint targetMax, MidpointRounding roundingMode)
            => MapImpl(value, sourceMin, sourceMax, targetMin, targetMax, roundingMode);

        private static uint MapImpl(uint value, uint sourceMin, uint sourceMax, uint targetMin, uint targetMax, MidpointRounding roundingMode)
        {
            var mappedAndRoundedValue = MapAndRound(value, sourceMin, sourceMax, targetMin, targetMax, roundingMode);
            var result = Convert.ToUInt32(mappedAndRoundedValue);

            return result;
        }


        // ! THIS FILE IS GENERATED !

        /// <summary>
        /// Map a value from one range to another. Utilizes <see cref="MidpointRounding.ToEven"/> when rounding mapped value to integer
        /// </summary>
        /// <param name="value">Value to map</param>
        /// <param name="sourceMin">Source range minimum value</param>
        /// <param name="sourceMax">Souce range maximum value</param>
        /// <param name="targetMin">Target range minimum value</param>
        /// <param name="targetMax">Target range maximum value</param>
        /// <returns>Returns the mapped value</returns>
        public static int Map(this int value, int sourceMin, int sourceMax, int targetMin, int targetMax)
            => value.Map(sourceMin, sourceMax, targetMin, targetMax, MidpointRounding.ToEven);

        /// <summary>
        /// Map a value from one range to another
        /// </summary>
        /// <param name="value">Value to map</param>
        /// <param name="sourceMin">Source range minimum value</param>
        /// <param name="sourceMax">Souce range maximum value</param>
        /// <param name="targetMin">Target range minimum value</param>
        /// <param name="targetMax">Target range maximum value</param>
        /// <param name="mode">Rounding mode</param>
        /// <returns>Returns the mapped value</returns>
        public static int Map(this int value, int sourceMin, int sourceMax, int targetMin, int targetMax, MidpointRounding roundingMode)
            => MapImpl(value, sourceMin, sourceMax, targetMin, targetMax, roundingMode);

        private static int MapImpl(int value, int sourceMin, int sourceMax, int targetMin, int targetMax, MidpointRounding roundingMode)
        {
            var mappedAndRoundedValue = MapAndRound(value, sourceMin, sourceMax, targetMin, targetMax, roundingMode);
            var result = Convert.ToInt32(mappedAndRoundedValue);

            return result;
        }


        // ! THIS FILE IS GENERATED !

        /// <summary>
        /// Map a value from one range to another. Utilizes <see cref="MidpointRounding.ToEven"/> when rounding mapped value to integer
        /// </summary>
        /// <param name="value">Value to map</param>
        /// <param name="sourceMin">Source range minimum value</param>
        /// <param name="sourceMax">Souce range maximum value</param>
        /// <param name="targetMin">Target range minimum value</param>
        /// <param name="targetMax">Target range maximum value</param>
        /// <returns>Returns the mapped value</returns>
        public static ushort Map(this ushort value, ushort sourceMin, ushort sourceMax, ushort targetMin, ushort targetMax)
            => value.Map(sourceMin, sourceMax, targetMin, targetMax, MidpointRounding.ToEven);

        /// <summary>
        /// Map a value from one range to another
        /// </summary>
        /// <param name="value">Value to map</param>
        /// <param name="sourceMin">Source range minimum value</param>
        /// <param name="sourceMax">Souce range maximum value</param>
        /// <param name="targetMin">Target range minimum value</param>
        /// <param name="targetMax">Target range maximum value</param>
        /// <param name="mode">Rounding mode</param>
        /// <returns>Returns the mapped value</returns>
        public static ushort Map(this ushort value, ushort sourceMin, ushort sourceMax, ushort targetMin, ushort targetMax, MidpointRounding roundingMode)
            => MapImpl(value, sourceMin, sourceMax, targetMin, targetMax, roundingMode);

        private static ushort MapImpl(ushort value, ushort sourceMin, ushort sourceMax, ushort targetMin, ushort targetMax, MidpointRounding roundingMode)
        {
            var mappedAndRoundedValue = MapAndRound(value, sourceMin, sourceMax, targetMin, targetMax, roundingMode);
            var result = Convert.ToUInt16(mappedAndRoundedValue);

            return result;
        }


        // ! THIS FILE IS GENERATED !

        /// <summary>
        /// Map a value from one range to another. Utilizes <see cref="MidpointRounding.ToEven"/> when rounding mapped value to integer
        /// </summary>
        /// <param name="value">Value to map</param>
        /// <param name="sourceMin">Source range minimum value</param>
        /// <param name="sourceMax">Souce range maximum value</param>
        /// <param name="targetMin">Target range minimum value</param>
        /// <param name="targetMax">Target range maximum value</param>
        /// <returns>Returns the mapped value</returns>
        public static short Map(this short value, short sourceMin, short sourceMax, short targetMin, short targetMax)
            => value.Map(sourceMin, sourceMax, targetMin, targetMax, MidpointRounding.ToEven);

        /// <summary>
        /// Map a value from one range to another
        /// </summary>
        /// <param name="value">Value to map</param>
        /// <param name="sourceMin">Source range minimum value</param>
        /// <param name="sourceMax">Souce range maximum value</param>
        /// <param name="targetMin">Target range minimum value</param>
        /// <param name="targetMax">Target range maximum value</param>
        /// <param name="mode">Rounding mode</param>
        /// <returns>Returns the mapped value</returns>
        public static short Map(this short value, short sourceMin, short sourceMax, short targetMin, short targetMax, MidpointRounding roundingMode)
            => MapImpl(value, sourceMin, sourceMax, targetMin, targetMax, roundingMode);

        private static short MapImpl(short value, short sourceMin, short sourceMax, short targetMin, short targetMax, MidpointRounding roundingMode)
        {
            var mappedAndRoundedValue = MapAndRound(value, sourceMin, sourceMax, targetMin, targetMax, roundingMode);
            var result = Convert.ToInt16(mappedAndRoundedValue);

            return result;
        }


        // ! THIS FILE IS GENERATED !

        /// <summary>
        /// Map a value from one range to another. Utilizes <see cref="MidpointRounding.ToEven"/> when rounding mapped value to integer
        /// </summary>
        /// <param name="value">Value to map</param>
        /// <param name="sourceMin">Source range minimum value</param>
        /// <param name="sourceMax">Souce range maximum value</param>
        /// <param name="targetMin">Target range minimum value</param>
        /// <param name="targetMax">Target range maximum value</param>
        /// <returns>Returns the mapped value</returns>
        public static sbyte Map(this sbyte value, sbyte sourceMin, sbyte sourceMax, sbyte targetMin, sbyte targetMax)
            => value.Map(sourceMin, sourceMax, targetMin, targetMax, MidpointRounding.ToEven);

        /// <summary>
        /// Map a value from one range to another
        /// </summary>
        /// <param name="value">Value to map</param>
        /// <param name="sourceMin">Source range minimum value</param>
        /// <param name="sourceMax">Souce range maximum value</param>
        /// <param name="targetMin">Target range minimum value</param>
        /// <param name="targetMax">Target range maximum value</param>
        /// <param name="mode">Rounding mode</param>
        /// <returns>Returns the mapped value</returns>
        public static sbyte Map(this sbyte value, sbyte sourceMin, sbyte sourceMax, sbyte targetMin, sbyte targetMax, MidpointRounding roundingMode)
            => MapImpl(value, sourceMin, sourceMax, targetMin, targetMax, roundingMode);

        private static sbyte MapImpl(sbyte value, sbyte sourceMin, sbyte sourceMax, sbyte targetMin, sbyte targetMax, MidpointRounding roundingMode)
        {
            var mappedAndRoundedValue = MapAndRound(value, sourceMin, sourceMax, targetMin, targetMax, roundingMode);
            var result = Convert.ToSByte(mappedAndRoundedValue);

            return result;
        }


        // ! THIS FILE IS GENERATED !

        /// <summary>
        /// Map a value from one range to another. Utilizes <see cref="MidpointRounding.ToEven"/> when rounding mapped value to integer
        /// </summary>
        /// <param name="value">Value to map</param>
        /// <param name="sourceMin">Source range minimum value</param>
        /// <param name="sourceMax">Souce range maximum value</param>
        /// <param name="targetMin">Target range minimum value</param>
        /// <param name="targetMax">Target range maximum value</param>
        /// <returns>Returns the mapped value</returns>
        public static byte Map(this byte value, byte sourceMin, byte sourceMax, byte targetMin, byte targetMax)
            => value.Map(sourceMin, sourceMax, targetMin, targetMax, MidpointRounding.ToEven);

        /// <summary>
        /// Map a value from one range to another
        /// </summary>
        /// <param name="value">Value to map</param>
        /// <param name="sourceMin">Source range minimum value</param>
        /// <param name="sourceMax">Souce range maximum value</param>
        /// <param name="targetMin">Target range minimum value</param>
        /// <param name="targetMax">Target range maximum value</param>
        /// <param name="mode">Rounding mode</param>
        /// <returns>Returns the mapped value</returns>
        public static byte Map(this byte value, byte sourceMin, byte sourceMax, byte targetMin, byte targetMax, MidpointRounding roundingMode)
            => MapImpl(value, sourceMin, sourceMax, targetMin, targetMax, roundingMode);

        private static byte MapImpl(byte value, byte sourceMin, byte sourceMax, byte targetMin, byte targetMax, MidpointRounding roundingMode)
        {
            var mappedAndRoundedValue = MapAndRound(value, sourceMin, sourceMax, targetMin, targetMax, roundingMode);
            var result = Convert.ToByte(mappedAndRoundedValue);

            return result;
        }



        // ! THIS FILE IS GENERATED !

        /// <summary>
        /// Map a value contained in a source range to value in a target range.
        /// </summary>
        /// <param name="value">Value to map</param>
        /// <param name="sourceMin">Source range minimum value</param>
        /// <param name="sourceMax">Souce range maximum value</param>
        /// <param name="targetMin">Target range minimum value</param>
        /// <param name="targetMax">Target range maximum value</param>
        /// <returns>Returns the mapped value</returns>
        public static decimal Map(this decimal value, decimal sourceMin, decimal sourceMax, decimal targetMin, decimal targetMax)
            => NumericMapImplementations.MapImpl(value, sourceMin, sourceMax, targetMin, targetMax);

        // ! THIS FILE IS GENERATED !

        /// <summary>
        /// Map a value contained in a source range to value in a target range.
        /// </summary>
        /// <param name="value">Value to map</param>
        /// <param name="sourceMin">Source range minimum value</param>
        /// <param name="sourceMax">Souce range maximum value</param>
        /// <param name="targetMin">Target range minimum value</param>
        /// <param name="targetMax">Target range maximum value</param>
        /// <returns>Returns the mapped value</returns>
        public static double Map(this double value, double sourceMin, double sourceMax, double targetMin, double targetMax)
            => NumericMapImplementations.MapImpl(value, sourceMin, sourceMax, targetMin, targetMax);

        // ! THIS FILE IS GENERATED !

        /// <summary>
        /// Map a value contained in a source range to value in a target range.
        /// </summary>
        /// <param name="value">Value to map</param>
        /// <param name="sourceMin">Source range minimum value</param>
        /// <param name="sourceMax">Souce range maximum value</param>
        /// <param name="targetMin">Target range minimum value</param>
        /// <param name="targetMax">Target range maximum value</param>
        /// <returns>Returns the mapped value</returns>
        public static float Map(this float value, float sourceMin, float sourceMax, float targetMin, float targetMax)
            => NumericMapImplementations.MapImpl(value, sourceMin, sourceMax, targetMin, targetMax);

        // ! THIS FILE IS GENERATED !

        // Helper for integer map extensions
        private static decimal MapAndRound(decimal value, decimal sourceMin, decimal sourceMax, decimal targetMin, decimal targetMax, MidpointRounding roundingMode)
        {
            var mappedValue = NumericMapImplementations.MapImpl(value, sourceMin, sourceMax, targetMin, targetMax);
            var roundedValue = Math.Round(mappedValue, roundingMode);

            return roundedValue;
        }
    }
}