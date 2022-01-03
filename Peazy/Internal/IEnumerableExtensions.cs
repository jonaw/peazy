using Peazy.Extensions;
using System.Collections.Generic;
using System.Linq;

namespace Peazy.Internal
{
    internal static class IEnumerableExtensions
    {
        internal static IEnumerable<T> ApplyNullStrategy<T>(this IEnumerable<T> source, StringNullStrategy nullStrategy)
        {
            if (nullStrategy == StringNullStrategy.Skip)
            {
                return source.Where(v => v != null);
            }

            return source;
        }
    }
}