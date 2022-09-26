using System;
using System.Collections.Generic;
using System.Linq;
using Peazy.Extensions;
using Peazy.Internal;

namespace Peazy.Core
{
    internal static partial class EnumerableHelpers
    {
        private static Exception ValidateArgument<T>(Func<T, string> selector)
        {
            if (selector == null)
            {
                return ExceptionCreationHelpers.CreateArgumentNullException(nameof(selector));
            }

            return null;
        }

        private static Exception ValidateArguments<T>(IEnumerable<T> source, string value)
        {
            if (source == null)
            {
                return ExceptionCreationHelpers.CreateArgumentNullException(nameof(source));
            }

            if (value == null)
            {
                return ExceptionCreationHelpers.CreateArgumentNullException(nameof(value));
            }

            return null;
        }
    }
}