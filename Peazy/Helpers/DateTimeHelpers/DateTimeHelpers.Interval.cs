using System;

namespace Peazy.Helpers
{
    public static partial class DateTimeHelpers
    {
        /// <summary>
        /// Determine if two intervals intersect, inclusive
        /// </summary>
        /// <param name="aStart">Start of interval a</param>
        /// <param name="aEnd">End of interval a</param>
        /// <param name="bStart">Start of interval b</param>
        /// <param name="bEnd">End of interval b</param>
        /// <returns>Whether the intervals intersect</returns>
        public static bool IntervalsIntersect(
            DateTime aStart,
            DateTime aEnd,
            DateTime bStart,
            DateTime bEnd)
        {
            return aStart <= bEnd && aEnd >= bStart;
        }

        /// <summary>
        /// Determine if two intervals intersect, inclusive
        /// </summary>
        /// <param name="a">Interval a</param>
        /// <param name="b">Interval b</param>
        /// <returns>Whether the intervals intersect</returns>
        public static bool IntervalsIntersect(DateInterval a, DateInterval b)
        {
            return a.Start <= b.End && a.End >= b.Start;
        }
    }

    public struct DateInterval
    {
        public DateTime Start { get; }
        public DateTime End { get; }

        public DateInterval(DateTime start, DateTime end)
        {
            if (start > end)
            {
                throw new ArgumentException($"Argument {nameof(start)} must be later or equal to {nameof(end)}");
            }

            Start = start;
            End = end;
        }
    }
}
