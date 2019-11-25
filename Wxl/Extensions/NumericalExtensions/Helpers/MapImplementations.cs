/*******************************************************************************
*                                                                              *
*                            THIS FILE IS GENERATED                            *
*                                                                              *
*******************************************************************************/
using System;

namespace Wxl.Extensions.NumericalExtensions.Helpers
{
	internal static class MapImplementations
	{
		
		internal static decimal MapImpl(decimal value, decimal sourceMin, decimal sourceMax, decimal targetMin, decimal targetMax)
        {
            var exception = MapImplArgumentCheck(value, sourceMin, sourceMax, targetMin, targetMax);
            if (exception != null)
            {
                throw exception;
            }

            var result = targetMin + ((targetMax - targetMin) / (sourceMax - sourceMin)) * (value - sourceMin);

            return result;
        }

		internal static Exception MapImplArgumentCheck(decimal value, decimal sourceMin, decimal sourceMax, decimal targetMin, decimal targetMax)
		{
			var exception = default(Exception);

			if (value < sourceMin || value > sourceMax)
			{
				exception = new ArgumentException($"{nameof(value)} must not be less than {nameof(sourceMin)} or greater than {nameof(sourceMax)}");
			}
			else if (sourceMin > sourceMax)
			{
				exception = new ArgumentException($"{nameof(value)} must not be less than {nameof(sourceMin)} or greater than {nameof(sourceMax)}");
			}
			else if (targetMin > targetMax)
			{
				exception = new ArgumentException($"{nameof(targetMin)} must not be greater than {nameof(targetMax)}");
			}

			return exception;
		}
		
		internal static double MapImpl(double value, double sourceMin, double sourceMax, double targetMin, double targetMax)
        {
            var exception = MapImplArgumentCheck(value, sourceMin, sourceMax, targetMin, targetMax);
            if (exception != null)
            {
                throw exception;
            }

            var result = targetMin + ((targetMax - targetMin) / (sourceMax - sourceMin)) * (value - sourceMin);

            return result;
        }

		internal static Exception MapImplArgumentCheck(double value, double sourceMin, double sourceMax, double targetMin, double targetMax)
		{
			var exception = default(Exception);

			if (value < sourceMin || value > sourceMax)
			{
				exception = new ArgumentException($"{nameof(value)} must not be less than {nameof(sourceMin)} or greater than {nameof(sourceMax)}");
			}
			else if (sourceMin > sourceMax)
			{
				exception = new ArgumentException($"{nameof(value)} must not be less than {nameof(sourceMin)} or greater than {nameof(sourceMax)}");
			}
			else if (targetMin > targetMax)
			{
				exception = new ArgumentException($"{nameof(targetMin)} must not be greater than {nameof(targetMax)}");
			}

			return exception;
		}
		
		internal static float MapImpl(float value, float sourceMin, float sourceMax, float targetMin, float targetMax)
        {
            var exception = MapImplArgumentCheck(value, sourceMin, sourceMax, targetMin, targetMax);
            if (exception != null)
            {
                throw exception;
            }

            var result = targetMin + ((targetMax - targetMin) / (sourceMax - sourceMin)) * (value - sourceMin);

            return result;
        }

		internal static Exception MapImplArgumentCheck(float value, float sourceMin, float sourceMax, float targetMin, float targetMax)
		{
			var exception = default(Exception);

			if (value < sourceMin || value > sourceMax)
			{
				exception = new ArgumentException($"{nameof(value)} must not be less than {nameof(sourceMin)} or greater than {nameof(sourceMax)}");
			}
			else if (sourceMin > sourceMax)
			{
				exception = new ArgumentException($"{nameof(value)} must not be less than {nameof(sourceMin)} or greater than {nameof(sourceMax)}");
			}
			else if (targetMin > targetMax)
			{
				exception = new ArgumentException($"{nameof(targetMin)} must not be greater than {nameof(targetMax)}");
			}

			return exception;
		}
		
	}
}