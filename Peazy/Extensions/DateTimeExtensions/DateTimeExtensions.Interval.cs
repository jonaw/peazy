using Peazy.Core;
using System;

namespace Peazy.Extensions
{
    public static partial class DateTimeExtensions
    {
        /// <summary>
        /// Determines if a DateTime is within an interval, inclusive
        /// </summary>
        /// <param name="dateTime">Value to determine for</param>
        /// <param name="intervalStart">Interval start</param>
        /// <param name="intervalEnd">Interval end</param>
        /// <returns>Whether value exist in interval</returns>
        public static bool IsInInterval(this DateTime dateTime, DateTime intervalStart, DateTime intervalEnd)
            => DateTimeHelpers.IsInInterval(dateTime, intervalStart, intervalEnd);

        /// <summary>
        /// Determines if a DateTime is within an interval, inclusive
        /// </summary>
        /// <param name="dateTime">Value to determine for</param>
        /// <param name="intervalStart">Interval start</param>
        /// <param name="intervalEnd">Interval end</param>
        /// <returns>Whether value exist in interval</returns>
        public static bool IsInInterval(this DateTime? dateTime, DateTime intervalStart, DateTime intervalEnd)
            => DateTimeHelpers.IsInInterval(dateTime, intervalStart, intervalEnd);
    }
}
