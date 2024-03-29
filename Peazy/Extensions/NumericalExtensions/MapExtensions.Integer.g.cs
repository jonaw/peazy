/*******************************************************************************
*                                                                              *
*                            THIS FILE IS GENERATED                            *
*                                                                              *
*******************************************************************************/
using System;
using Peazy.Core;

namespace Peazy.Extensions
{
    public static partial class MapExtensions
    {
                                                /// <summary>
        /// Map a value from one range to another. Utilizes <see cref="MidpointRounding.ToEven"/> when rounding mapped value to integer
        /// </summary>
        /// <param name="value">Value to map</param>
        /// <param name="sourceMin">Source range minimum value</param>
        /// <param name="sourceMax">Source range maximum value</param>
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
        /// <param name="sourceMax">Source range maximum value</param>
        /// <param name="targetMin">Target range minimum value</param>
        /// <param name="targetMax">Target range maximum value</param>
        /// <param name="roundingMode">Rounding mode</param>
        /// <returns>Returns the mapped value</returns>
        public static ulong Map(this ulong value, ulong sourceMin, ulong sourceMax, ulong targetMin, ulong targetMax, MidpointRounding roundingMode)
            => MapCore(value, sourceMin, sourceMax, targetMin, targetMax, roundingMode);

        private static ulong MapCore(ulong value, ulong sourceMin, ulong sourceMax, ulong targetMin, ulong targetMax, MidpointRounding roundingMode)
        {
            var mappedAndRoundedValue = MapAndRoundCore(value, sourceMin, sourceMax, targetMin, targetMax, roundingMode);
            return Convert.ToUInt64(mappedAndRoundedValue);
        }

        /// <summary>
        /// Map a value from one range to another. Utilizes <see cref="MidpointRounding.ToEven"/> when rounding mapped value to integer
        /// </summary>
        /// <param name="value">Value to map</param>
        /// <param name="sourceMin">Source range minimum value</param>
        /// <param name="sourceMax">Source range maximum value</param>
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
        /// <param name="sourceMax">Source range maximum value</param>
        /// <param name="targetMin">Target range minimum value</param>
        /// <param name="targetMax">Target range maximum value</param>
        /// <param name="roundingMode">Rounding mode</param>
        /// <returns>Returns the mapped value</returns>
        public static long Map(this long value, long sourceMin, long sourceMax, long targetMin, long targetMax, MidpointRounding roundingMode)
            => MapCore(value, sourceMin, sourceMax, targetMin, targetMax, roundingMode);

        private static long MapCore(long value, long sourceMin, long sourceMax, long targetMin, long targetMax, MidpointRounding roundingMode)
        {
            var mappedAndRoundedValue = MapAndRoundCore(value, sourceMin, sourceMax, targetMin, targetMax, roundingMode);
            return Convert.ToInt64(mappedAndRoundedValue);
        }

        /// <summary>
        /// Map a value from one range to another. Utilizes <see cref="MidpointRounding.ToEven"/> when rounding mapped value to integer
        /// </summary>
        /// <param name="value">Value to map</param>
        /// <param name="sourceMin">Source range minimum value</param>
        /// <param name="sourceMax">Source range maximum value</param>
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
        /// <param name="sourceMax">Source range maximum value</param>
        /// <param name="targetMin">Target range minimum value</param>
        /// <param name="targetMax">Target range maximum value</param>
        /// <param name="roundingMode">Rounding mode</param>
        /// <returns>Returns the mapped value</returns>
        public static uint Map(this uint value, uint sourceMin, uint sourceMax, uint targetMin, uint targetMax, MidpointRounding roundingMode)
            => MapCore(value, sourceMin, sourceMax, targetMin, targetMax, roundingMode);

        private static uint MapCore(uint value, uint sourceMin, uint sourceMax, uint targetMin, uint targetMax, MidpointRounding roundingMode)
        {
            var mappedAndRoundedValue = MapAndRoundCore(value, sourceMin, sourceMax, targetMin, targetMax, roundingMode);
            return Convert.ToUInt32(mappedAndRoundedValue);
        }

        /// <summary>
        /// Map a value from one range to another. Utilizes <see cref="MidpointRounding.ToEven"/> when rounding mapped value to integer
        /// </summary>
        /// <param name="value">Value to map</param>
        /// <param name="sourceMin">Source range minimum value</param>
        /// <param name="sourceMax">Source range maximum value</param>
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
        /// <param name="sourceMax">Source range maximum value</param>
        /// <param name="targetMin">Target range minimum value</param>
        /// <param name="targetMax">Target range maximum value</param>
        /// <param name="roundingMode">Rounding mode</param>
        /// <returns>Returns the mapped value</returns>
        public static int Map(this int value, int sourceMin, int sourceMax, int targetMin, int targetMax, MidpointRounding roundingMode)
            => MapCore(value, sourceMin, sourceMax, targetMin, targetMax, roundingMode);

        private static int MapCore(int value, int sourceMin, int sourceMax, int targetMin, int targetMax, MidpointRounding roundingMode)
        {
            var mappedAndRoundedValue = MapAndRoundCore(value, sourceMin, sourceMax, targetMin, targetMax, roundingMode);
            return Convert.ToInt32(mappedAndRoundedValue);
        }

        /// <summary>
        /// Map a value from one range to another. Utilizes <see cref="MidpointRounding.ToEven"/> when rounding mapped value to integer
        /// </summary>
        /// <param name="value">Value to map</param>
        /// <param name="sourceMin">Source range minimum value</param>
        /// <param name="sourceMax">Source range maximum value</param>
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
        /// <param name="sourceMax">Source range maximum value</param>
        /// <param name="targetMin">Target range minimum value</param>
        /// <param name="targetMax">Target range maximum value</param>
        /// <param name="roundingMode">Rounding mode</param>
        /// <returns>Returns the mapped value</returns>
        public static ushort Map(this ushort value, ushort sourceMin, ushort sourceMax, ushort targetMin, ushort targetMax, MidpointRounding roundingMode)
            => MapCore(value, sourceMin, sourceMax, targetMin, targetMax, roundingMode);

        private static ushort MapCore(ushort value, ushort sourceMin, ushort sourceMax, ushort targetMin, ushort targetMax, MidpointRounding roundingMode)
        {
            var mappedAndRoundedValue = MapAndRoundCore(value, sourceMin, sourceMax, targetMin, targetMax, roundingMode);
            return Convert.ToUInt16(mappedAndRoundedValue);
        }

        /// <summary>
        /// Map a value from one range to another. Utilizes <see cref="MidpointRounding.ToEven"/> when rounding mapped value to integer
        /// </summary>
        /// <param name="value">Value to map</param>
        /// <param name="sourceMin">Source range minimum value</param>
        /// <param name="sourceMax">Source range maximum value</param>
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
        /// <param name="sourceMax">Source range maximum value</param>
        /// <param name="targetMin">Target range minimum value</param>
        /// <param name="targetMax">Target range maximum value</param>
        /// <param name="roundingMode">Rounding mode</param>
        /// <returns>Returns the mapped value</returns>
        public static short Map(this short value, short sourceMin, short sourceMax, short targetMin, short targetMax, MidpointRounding roundingMode)
            => MapCore(value, sourceMin, sourceMax, targetMin, targetMax, roundingMode);

        private static short MapCore(short value, short sourceMin, short sourceMax, short targetMin, short targetMax, MidpointRounding roundingMode)
        {
            var mappedAndRoundedValue = MapAndRoundCore(value, sourceMin, sourceMax, targetMin, targetMax, roundingMode);
            return Convert.ToInt16(mappedAndRoundedValue);
        }

        /// <summary>
        /// Map a value from one range to another. Utilizes <see cref="MidpointRounding.ToEven"/> when rounding mapped value to integer
        /// </summary>
        /// <param name="value">Value to map</param>
        /// <param name="sourceMin">Source range minimum value</param>
        /// <param name="sourceMax">Source range maximum value</param>
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
        /// <param name="sourceMax">Source range maximum value</param>
        /// <param name="targetMin">Target range minimum value</param>
        /// <param name="targetMax">Target range maximum value</param>
        /// <param name="roundingMode">Rounding mode</param>
        /// <returns>Returns the mapped value</returns>
        public static sbyte Map(this sbyte value, sbyte sourceMin, sbyte sourceMax, sbyte targetMin, sbyte targetMax, MidpointRounding roundingMode)
            => MapCore(value, sourceMin, sourceMax, targetMin, targetMax, roundingMode);

        private static sbyte MapCore(sbyte value, sbyte sourceMin, sbyte sourceMax, sbyte targetMin, sbyte targetMax, MidpointRounding roundingMode)
        {
            var mappedAndRoundedValue = MapAndRoundCore(value, sourceMin, sourceMax, targetMin, targetMax, roundingMode);
            return Convert.ToSByte(mappedAndRoundedValue);
        }

        /// <summary>
        /// Map a value from one range to another. Utilizes <see cref="MidpointRounding.ToEven"/> when rounding mapped value to integer
        /// </summary>
        /// <param name="value">Value to map</param>
        /// <param name="sourceMin">Source range minimum value</param>
        /// <param name="sourceMax">Source range maximum value</param>
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
        /// <param name="sourceMax">Source range maximum value</param>
        /// <param name="targetMin">Target range minimum value</param>
        /// <param name="targetMax">Target range maximum value</param>
        /// <param name="roundingMode">Rounding mode</param>
        /// <returns>Returns the mapped value</returns>
        public static byte Map(this byte value, byte sourceMin, byte sourceMax, byte targetMin, byte targetMax, MidpointRounding roundingMode)
            => MapCore(value, sourceMin, sourceMax, targetMin, targetMax, roundingMode);

        private static byte MapCore(byte value, byte sourceMin, byte sourceMax, byte targetMin, byte targetMax, MidpointRounding roundingMode)
        {
            var mappedAndRoundedValue = MapAndRoundCore(value, sourceMin, sourceMax, targetMin, targetMax, roundingMode);
            return Convert.ToByte(mappedAndRoundedValue);
        }

        // Helper for map extensions
        private static decimal MapAndRoundCore(decimal value, decimal sourceMin, decimal sourceMax, decimal targetMin, decimal targetMax, MidpointRounding roundingMode)
        {
            var mappedValue = NumericHelpers.Map(value, sourceMin, sourceMax, targetMin, targetMax);
            return Math.Round(mappedValue, roundingMode);
        }
    }
}