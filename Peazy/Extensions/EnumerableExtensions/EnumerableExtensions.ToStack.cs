using Peazy.Core;
using System;
using System.Collections.Generic;

namespace Peazy.Extensions
{
    public static partial class EnumerableExtensions
    {
        /// <summary>
        /// Create a new Stack from an enumerable
        /// </summary>
        /// <param name="source">Source items</param>
        /// <typeparam name="T">The type of elements in enumerable and stack</typeparam>
        /// <returns>Returns a new stack containing elements from enumerable</returns>
        public static IEnumerable<T> ToStack<T>(this IEnumerable<T> source)
            => EnumerableHelpers.ToStack(source);
    }
}
