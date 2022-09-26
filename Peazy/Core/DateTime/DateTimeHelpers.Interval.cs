using System;
using Peazy.Internal;

namespace Peazy.Core
{
    internal static partial class DateTimeHelpers
    {
        /// <summary>
        /// Determines if a DateTime is within an interval, inclusive
        /// </summary>
        /// <param name="dateTime">Value to determine for</param>
        /// <param name="intervalStart">Interval start</param>
        /// <param name="intervalEnd">Interval end</param>
        /// <returns>Whether value exist in interval</returns>
        public static bool IsInInterval(DateTime? dateTime, DateTime intervalStart, DateTime intervalEnd)
            => IsInIntervalCore (dateTime, intervalStart, intervalEnd);

        /// <summary>
        /// Determines if a DateTime is within an interval, inclusive
        /// </summary>
        /// <param name="dateTime">Value to determine for</param>
        /// <param name="intervalStart">Interval start</param>
        /// <param name="intervalEnd">Interval end</param>
        /// <returns>Whether value exist in interval</returns>
        public static bool IsInInterval(DateTime dateTime, DateTime intervalStart, DateTime intervalEnd)
            => IsInIntervalCore (dateTime, intervalStart, intervalEnd);

        private static bool IsInIntervalCore(DateTime? dateTime, DateTime intervalStart, DateTime intervalEnd)
        {
            if (!dateTime.HasValue)
            {
                return false;
            }

            if (intervalStart > intervalEnd)
            {
                var message = $"Value of {nameof(intervalEnd)} must be greater or equal to {nameof(intervalStart)}";
                throw ExceptionCreationHelpers.CreateArgumentNullException(nameof(intervalStart), message);
            }

            return dateTime >= intervalStart && dateTime <= intervalEnd;
        }

        /// <summary>
        /// Determine if two intervals intersect, inclusive
        /// </summary>
        /// <param name="aStart">Start of interval a</param>
        /// <param name="aEnd">End of interval a</param>
        /// <param name="bStart">Start of interval b</param>
        /// <param name="bEnd">End of interval b</param>
        /// <returns>Returns true if the intervals intersect, else false</returns>
        public static bool IntervalsIntersect(
            DateTime aStart,
            DateTime aEnd,
            DateTime bStart,
            DateTime bEnd)
        {
            return aStart <= bEnd && aEnd >= bStart;
        }
    }
}