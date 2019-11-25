using System;

namespace Wxl.Extensions.DateTimeExtensions
{
    public static class InIntervalExtensions
    {
        /// <summary>
        /// Determines if a DateTime is within an interval, inclusive
        /// </summary>
        /// <param name="dateTime">Value to determine for</param>
        /// <param name="intervalStart">Interval start</param>
        /// <param name="intervalEnd">Interval end</param>
        /// <returns>Whether value exist in interval</returns>
        public static bool InInterval(this DateTime dateTime, DateTime intervalStart, DateTime intervalEnd)
        {
            if (intervalStart > intervalEnd)
            {
                throw new ArgumentException($"DateTime of argument {nameof(intervalEnd)} must be past or equal to {nameof(intervalStart)}", nameof(intervalStart));
            }

            return dateTime >= intervalStart && dateTime <= intervalEnd;
        }
    }
}
