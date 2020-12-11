
using System;

namespace Wxl.Internal
{
    internal static class ExceptionCreationHelpers
    {
        internal static ArgumentNullException CreateArgumentNullException(string paramName)
            => CreateArgumentNullException(paramName, $"Argument {paramName} cannot be equal to null");

        internal static ArgumentNullException CreateArgumentNullException(string paramName, string message)
        {
            return new ArgumentNullException(paramName, message);
        }

        internal static ArgumentException CreateArgumentException(string paramName, string message)
        {
            return new ArgumentException(message, paramName);
        }
    }
}