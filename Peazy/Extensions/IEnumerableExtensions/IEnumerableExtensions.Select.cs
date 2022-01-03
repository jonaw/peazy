using System;
using System.Collections.Generic;
using System.Linq;

namespace Peazy.Extensions
{
    public static partial class IEnumerableExtensions
    {
        public static IEnumerable<E> SelectWhere<T, E>(this IEnumerable<T> elements, Func<T, E> selector, Predicate<T> predicate)
        {
            foreach (var element in elements)
            {
                if (predicate(element))
                {
                    yield return selector(element);
                }
            }

            /* Unmerged change from project 'Peazy (net461)'
            Before:
                    }

                    public static List<E> SelectToList<T, E>(this IEnumerable<T> elements, Func<T, E> selector) 
            After:
                    }

                    public static List<E> SelectToList<T, E>(this IEnumerable<T> elements, Func<T, E> selector) 
            */

            /* Unmerged change from project 'Peazy (net6.0)'
            Before:
                    }

                    public static List<E> SelectToList<T, E>(this IEnumerable<T> elements, Func<T, E> selector) 
            After:
                    }

                    public static List<E> SelectToList<T, E>(this IEnumerable<T> elements, Func<T, E> selector) 
            */
        }

        public static List<E> SelectToList<T, E>(this IEnumerable<T> elements, Func<T, E> selector)
        {
            return elements.Select(selector).ToList();

            /* Unmerged change from project 'Peazy (net461)'
            Before:
                    }

                    public static List<E> SelectToListWhere<T, E>(this IEnumerable<T> elements, Func<T, E> selector, Predicate<T> predicate) 
            After:
                    }

                    public static List<E> SelectToListWhere<T, E>(this IEnumerable<T> elements, Func<T, E> selector, Predicate<T> predicate) 
            */

            /* Unmerged change from project 'Peazy (net6.0)'
            Before:
                    }

                    public static List<E> SelectToListWhere<T, E>(this IEnumerable<T> elements, Func<T, E> selector, Predicate<T> predicate) 
            After:
                    }

                    public static List<E> SelectToListWhere<T, E>(this IEnumerable<T> elements, Func<T, E> selector, Predicate<T> predicate) 
            */
        }

        public static List<E> SelectToListWhere<T, E>(this IEnumerable<T> elements, Func<T, E> selector, Predicate<T> predicate)
        {
            return elements.SelectWhere(selector, predicate).ToList();
        }
    }
}
