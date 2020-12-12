/*******************************************************************************
*                                                                              *
*                            THIS FILE IS GENERATED                            *
*                                                                              *
*******************************************************************************/
using System;
using Peazy.Extensions.NumericalExtensions.Helpers;

namespace Peazy.Extensions.NumericalExtensions
{
	public static class MapExtensions
	{
														
		/// <summary>
        /// Map a value from one range to another
        /// </summary>
        /// <param name="value">Value to map</param>
        /// <param name="sourceMin">From range min value</param>
        /// <param name="sourceMax">From range max value</param>
        /// <param name="targetMin">To range min value</param>
        /// <param name="targetMax">To range max value</param>
        /// <param name="mode">Rounding mode</param>
        /// <returns>Returns the mapped value</returns>
		public static ulong Map(this ulong value, ulong sourceMin, ulong sourceMax, ulong targetMin, ulong targetMax, MidpointRounding mode)
        {
            var mappedAndRoundedValue = MapAndRound(value, sourceMin, sourceMax, targetMin, targetMax, mode);
            var result = Convert.ToUInt64(mappedAndRoundedValue);

            return result;
        }

		/// <summary>
        /// Map a value from one range to another. Utilizes <see cref="MidpointRounding.ToEven"/> when rounding mapped value to integer
        /// </summary>
        /// <param name="value">Value to map</param>
        /// <param name="sourceMin">From range min value</param>
        /// <param name="sourceMax">From range max value</param>
        /// <param name="targetMin">To range min value</param>
        /// <param name="targetMax">To range max value</param>
        /// <returns>Returns the mapped value</returns>
		public static ulong Map(this ulong value, ulong sourceMin, ulong sourceMax, ulong targetMin, ulong targetMax)
        {
            return value.Map(sourceMin, sourceMax, targetMin, targetMax, MidpointRounding.ToEven);
        }

				
		/// <summary>
        /// Map a value from one range to another
        /// </summary>
        /// <param name="value">Value to map</param>
        /// <param name="sourceMin">From range min value</param>
        /// <param name="sourceMax">From range max value</param>
        /// <param name="targetMin">To range min value</param>
        /// <param name="targetMax">To range max value</param>
        /// <param name="mode">Rounding mode</param>
        /// <returns>Returns the mapped value</returns>
		public static long Map(this long value, long sourceMin, long sourceMax, long targetMin, long targetMax, MidpointRounding mode)
        {
            var mappedAndRoundedValue = MapAndRound(value, sourceMin, sourceMax, targetMin, targetMax, mode);
            var result = Convert.ToInt64(mappedAndRoundedValue);

            return result;
        }

		/// <summary>
        /// Map a value from one range to another. Utilizes <see cref="MidpointRounding.ToEven"/> when rounding mapped value to integer
        /// </summary>
        /// <param name="value">Value to map</param>
        /// <param name="sourceMin">From range min value</param>
        /// <param name="sourceMax">From range max value</param>
        /// <param name="targetMin">To range min value</param>
        /// <param name="targetMax">To range max value</param>
        /// <returns>Returns the mapped value</returns>
		public static long Map(this long value, long sourceMin, long sourceMax, long targetMin, long targetMax)
        {
            return value.Map(sourceMin, sourceMax, targetMin, targetMax, MidpointRounding.ToEven);
        }

				
		/// <summary>
        /// Map a value from one range to another
        /// </summary>
        /// <param name="value">Value to map</param>
        /// <param name="sourceMin">From range min value</param>
        /// <param name="sourceMax">From range max value</param>
        /// <param name="targetMin">To range min value</param>
        /// <param name="targetMax">To range max value</param>
        /// <param name="mode">Rounding mode</param>
        /// <returns>Returns the mapped value</returns>
		public static uint Map(this uint value, uint sourceMin, uint sourceMax, uint targetMin, uint targetMax, MidpointRounding mode)
        {
            var mappedAndRoundedValue = MapAndRound(value, sourceMin, sourceMax, targetMin, targetMax, mode);
            var result = Convert.ToUInt32(mappedAndRoundedValue);

            return result;
        }

		/// <summary>
        /// Map a value from one range to another. Utilizes <see cref="MidpointRounding.ToEven"/> when rounding mapped value to integer
        /// </summary>
        /// <param name="value">Value to map</param>
        /// <param name="sourceMin">From range min value</param>
        /// <param name="sourceMax">From range max value</param>
        /// <param name="targetMin">To range min value</param>
        /// <param name="targetMax">To range max value</param>
        /// <returns>Returns the mapped value</returns>
		public static uint Map(this uint value, uint sourceMin, uint sourceMax, uint targetMin, uint targetMax)
        {
            return value.Map(sourceMin, sourceMax, targetMin, targetMax, MidpointRounding.ToEven);
        }

				
		/// <summary>
        /// Map a value from one range to another
        /// </summary>
        /// <param name="value">Value to map</param>
        /// <param name="sourceMin">From range min value</param>
        /// <param name="sourceMax">From range max value</param>
        /// <param name="targetMin">To range min value</param>
        /// <param name="targetMax">To range max value</param>
        /// <param name="mode">Rounding mode</param>
        /// <returns>Returns the mapped value</returns>
		public static int Map(this int value, int sourceMin, int sourceMax, int targetMin, int targetMax, MidpointRounding mode)
        {
            var mappedAndRoundedValue = MapAndRound(value, sourceMin, sourceMax, targetMin, targetMax, mode);
            var result = Convert.ToInt32(mappedAndRoundedValue);

            return result;
        }

		/// <summary>
        /// Map a value from one range to another. Utilizes <see cref="MidpointRounding.ToEven"/> when rounding mapped value to integer
        /// </summary>
        /// <param name="value">Value to map</param>
        /// <param name="sourceMin">From range min value</param>
        /// <param name="sourceMax">From range max value</param>
        /// <param name="targetMin">To range min value</param>
        /// <param name="targetMax">To range max value</param>
        /// <returns>Returns the mapped value</returns>
		public static int Map(this int value, int sourceMin, int sourceMax, int targetMin, int targetMax)
        {
            return value.Map(sourceMin, sourceMax, targetMin, targetMax, MidpointRounding.ToEven);
        }

				
		/// <summary>
        /// Map a value from one range to another
        /// </summary>
        /// <param name="value">Value to map</param>
        /// <param name="sourceMin">From range min value</param>
        /// <param name="sourceMax">From range max value</param>
        /// <param name="targetMin">To range min value</param>
        /// <param name="targetMax">To range max value</param>
        /// <param name="mode">Rounding mode</param>
        /// <returns>Returns the mapped value</returns>
		public static ushort Map(this ushort value, ushort sourceMin, ushort sourceMax, ushort targetMin, ushort targetMax, MidpointRounding mode)
        {
            var mappedAndRoundedValue = MapAndRound(value, sourceMin, sourceMax, targetMin, targetMax, mode);
            var result = Convert.ToUInt16(mappedAndRoundedValue);

            return result;
        }

		/// <summary>
        /// Map a value from one range to another. Utilizes <see cref="MidpointRounding.ToEven"/> when rounding mapped value to integer
        /// </summary>
        /// <param name="value">Value to map</param>
        /// <param name="sourceMin">From range min value</param>
        /// <param name="sourceMax">From range max value</param>
        /// <param name="targetMin">To range min value</param>
        /// <param name="targetMax">To range max value</param>
        /// <returns>Returns the mapped value</returns>
		public static ushort Map(this ushort value, ushort sourceMin, ushort sourceMax, ushort targetMin, ushort targetMax)
        {
            return value.Map(sourceMin, sourceMax, targetMin, targetMax, MidpointRounding.ToEven);
        }

				
		/// <summary>
        /// Map a value from one range to another
        /// </summary>
        /// <param name="value">Value to map</param>
        /// <param name="sourceMin">From range min value</param>
        /// <param name="sourceMax">From range max value</param>
        /// <param name="targetMin">To range min value</param>
        /// <param name="targetMax">To range max value</param>
        /// <param name="mode">Rounding mode</param>
        /// <returns>Returns the mapped value</returns>
		public static short Map(this short value, short sourceMin, short sourceMax, short targetMin, short targetMax, MidpointRounding mode)
        {
            var mappedAndRoundedValue = MapAndRound(value, sourceMin, sourceMax, targetMin, targetMax, mode);
            var result = Convert.ToInt16(mappedAndRoundedValue);

            return result;
        }

		/// <summary>
        /// Map a value from one range to another. Utilizes <see cref="MidpointRounding.ToEven"/> when rounding mapped value to integer
        /// </summary>
        /// <param name="value">Value to map</param>
        /// <param name="sourceMin">From range min value</param>
        /// <param name="sourceMax">From range max value</param>
        /// <param name="targetMin">To range min value</param>
        /// <param name="targetMax">To range max value</param>
        /// <returns>Returns the mapped value</returns>
		public static short Map(this short value, short sourceMin, short sourceMax, short targetMin, short targetMax)
        {
            return value.Map(sourceMin, sourceMax, targetMin, targetMax, MidpointRounding.ToEven);
        }

				
		/// <summary>
        /// Map a value from one range to another
        /// </summary>
        /// <param name="value">Value to map</param>
        /// <param name="sourceMin">From range min value</param>
        /// <param name="sourceMax">From range max value</param>
        /// <param name="targetMin">To range min value</param>
        /// <param name="targetMax">To range max value</param>
        /// <param name="mode">Rounding mode</param>
        /// <returns>Returns the mapped value</returns>
		public static sbyte Map(this sbyte value, sbyte sourceMin, sbyte sourceMax, sbyte targetMin, sbyte targetMax, MidpointRounding mode)
        {
            var mappedAndRoundedValue = MapAndRound(value, sourceMin, sourceMax, targetMin, targetMax, mode);
            var result = Convert.ToSByte(mappedAndRoundedValue);

            return result;
        }

		/// <summary>
        /// Map a value from one range to another. Utilizes <see cref="MidpointRounding.ToEven"/> when rounding mapped value to integer
        /// </summary>
        /// <param name="value">Value to map</param>
        /// <param name="sourceMin">From range min value</param>
        /// <param name="sourceMax">From range max value</param>
        /// <param name="targetMin">To range min value</param>
        /// <param name="targetMax">To range max value</param>
        /// <returns>Returns the mapped value</returns>
		public static sbyte Map(this sbyte value, sbyte sourceMin, sbyte sourceMax, sbyte targetMin, sbyte targetMax)
        {
            return value.Map(sourceMin, sourceMax, targetMin, targetMax, MidpointRounding.ToEven);
        }

				
		/// <summary>
        /// Map a value from one range to another
        /// </summary>
        /// <param name="value">Value to map</param>
        /// <param name="sourceMin">From range min value</param>
        /// <param name="sourceMax">From range max value</param>
        /// <param name="targetMin">To range min value</param>
        /// <param name="targetMax">To range max value</param>
        /// <param name="mode">Rounding mode</param>
        /// <returns>Returns the mapped value</returns>
		public static byte Map(this byte value, byte sourceMin, byte sourceMax, byte targetMin, byte targetMax, MidpointRounding mode)
        {
            var mappedAndRoundedValue = MapAndRound(value, sourceMin, sourceMax, targetMin, targetMax, mode);
            var result = Convert.ToByte(mappedAndRoundedValue);

            return result;
        }

		/// <summary>
        /// Map a value from one range to another. Utilizes <see cref="MidpointRounding.ToEven"/> when rounding mapped value to integer
        /// </summary>
        /// <param name="value">Value to map</param>
        /// <param name="sourceMin">From range min value</param>
        /// <param name="sourceMax">From range max value</param>
        /// <param name="targetMin">To range min value</param>
        /// <param name="targetMax">To range max value</param>
        /// <returns>Returns the mapped value</returns>
		public static byte Map(this byte value, byte sourceMin, byte sourceMax, byte targetMin, byte targetMax)
        {
            return value.Map(sourceMin, sourceMax, targetMin, targetMax, MidpointRounding.ToEven);
        }

		
														
		/// <summary>
        /// Map a value contained in a source range to value in a target range.
        /// </summary>
        /// <param name="value">Value to map</param>
        /// <param name="sourceMin">From range min value</param>
        /// <param name="sourceMax">From range max value</param>
        /// <param name="targetMin">To range min value</param>
        /// <param name="targetMax">To range max value</param>
        /// <returns>Returns the mapped value</returns>
		public static decimal Map(this decimal value, decimal sourceMin, decimal sourceMax, decimal targetMin, decimal targetMax)
        {
            return MapImplementations.MapImpl(value, sourceMin, sourceMax, targetMin, targetMax);
        }

				
		/// <summary>
        /// Map a value contained in a source range to value in a target range.
        /// </summary>
        /// <param name="value">Value to map</param>
        /// <param name="sourceMin">From range min value</param>
        /// <param name="sourceMax">From range max value</param>
        /// <param name="targetMin">To range min value</param>
        /// <param name="targetMax">To range max value</param>
        /// <returns>Returns the mapped value</returns>
		public static double Map(this double value, double sourceMin, double sourceMax, double targetMin, double targetMax)
        {
            return MapImplementations.MapImpl(value, sourceMin, sourceMax, targetMin, targetMax);
        }

				
		/// <summary>
        /// Map a value contained in a source range to value in a target range.
        /// </summary>
        /// <param name="value">Value to map</param>
        /// <param name="sourceMin">From range min value</param>
        /// <param name="sourceMax">From range max value</param>
        /// <param name="targetMin">To range min value</param>
        /// <param name="targetMax">To range max value</param>
        /// <returns>Returns the mapped value</returns>
		public static float Map(this float value, float sourceMin, float sourceMax, float targetMin, float targetMax)
        {
            return MapImplementations.MapImpl(value, sourceMin, sourceMax, targetMin, targetMax);
        }

		
		// Helper for integer map extensions
		private static decimal MapAndRound(decimal value, decimal sourceMin, decimal sourceMax, decimal targetMin, decimal targetMax, MidpointRounding mode)
		{
			var mappedValue = MapImplementations.MapImpl(value, sourceMin, sourceMax, targetMin, targetMax);
			var roundedValue = Math.Round(mappedValue, mode);
            
			return roundedValue;
		}
	}
}