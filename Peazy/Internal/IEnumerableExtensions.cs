using System.Collections.Generic;
using System.Linq;
using Peazy.Extensions.IEnumerableExtensions;

namespace Peazy.Internal
{
    internal static class IEnumerableExtensions
    {
        internal static IEnumerable<T> ApplyNullStrategy<T>(this IEnumerable<T> source, StringNullStrategy nullStrategy)
        {
            if (nullStrategy == StringNullStrategy.Ignore)
            {
                return source.Where(v => v != null);
            }

            return source;
        }
    }
}