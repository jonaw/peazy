/*******************************************************************************
*                                                                              *
*                            THIS FILE IS GENERATED                            *
*                                                                              *
*******************************************************************************/
using System;

namespace Peazy.Core
{
    internal static partial class NumericHelpers
    {
        internal static decimal Map(decimal value, decimal sourceMin, decimal sourceMax, decimal targetMin, decimal targetMax)
        {
            var exception = ValidateMapArguments(value, sourceMin, sourceMax, targetMin, targetMax);
            if (exception != null)
            {
                throw exception;
            }

            var result = targetMin + ((targetMax - targetMin) / (sourceMax - sourceMin)) * (value - sourceMin);

            return result;
        }

        private static Exception ValidateMapArguments(decimal value, decimal sourceMin, decimal sourceMax, decimal targetMin, decimal targetMax)
        {
            if (value < sourceMin || value > sourceMax)
            {
                return new ArgumentException($"{nameof(value)} must not be less than {nameof(sourceMin)} or greater than {nameof(sourceMax)}");
            }
            else if (sourceMin > sourceMax)
            {
                return new ArgumentException($"{nameof(value)} must not be less than {nameof(sourceMin)} or greater than {nameof(sourceMax)}");
            }
            else if (targetMin > targetMax)
            {
                return new ArgumentException($"{nameof(targetMin)} must not be greater than {nameof(targetMax)}");
            }

            return default;
        }

        internal static double Map(double value, double sourceMin, double sourceMax, double targetMin, double targetMax)
        {
            var exception = ValidateMapArguments(value, sourceMin, sourceMax, targetMin, targetMax);
            if (exception != null)
            {
                throw exception;
            }

            var result = targetMin + ((targetMax - targetMin) / (sourceMax - sourceMin)) * (value - sourceMin);

            return result;
        }

        private static Exception ValidateMapArguments(double value, double sourceMin, double sourceMax, double targetMin, double targetMax)
        {
            if (value < sourceMin || value > sourceMax)
            {
                return new ArgumentException($"{nameof(value)} must not be less than {nameof(sourceMin)} or greater than {nameof(sourceMax)}");
            }
            else if (sourceMin > sourceMax)
            {
                return new ArgumentException($"{nameof(value)} must not be less than {nameof(sourceMin)} or greater than {nameof(sourceMax)}");
            }
            else if (targetMin > targetMax)
            {
                return new ArgumentException($"{nameof(targetMin)} must not be greater than {nameof(targetMax)}");
            }

            return default;
        }

        internal static float Map(float value, float sourceMin, float sourceMax, float targetMin, float targetMax)
        {
            var exception = ValidateMapArguments(value, sourceMin, sourceMax, targetMin, targetMax);
            if (exception != null)
            {
                throw exception;
            }

            var result = targetMin + ((targetMax - targetMin) / (sourceMax - sourceMin)) * (value - sourceMin);

            return result;
        }

        private static Exception ValidateMapArguments(float value, float sourceMin, float sourceMax, float targetMin, float targetMax)
        {
            if (value < sourceMin || value > sourceMax)
            {
                return new ArgumentException($"{nameof(value)} must not be less than {nameof(sourceMin)} or greater than {nameof(sourceMax)}");
            }
            else if (sourceMin > sourceMax)
            {
                return new ArgumentException($"{nameof(value)} must not be less than {nameof(sourceMin)} or greater than {nameof(sourceMax)}");
            }
            else if (targetMin > targetMax)
            {
                return new ArgumentException($"{nameof(targetMin)} must not be greater than {nameof(targetMax)}");
            }

            return default;
        }

    }
}