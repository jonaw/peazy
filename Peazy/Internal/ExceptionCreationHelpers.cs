
using System;

namespace Peazy.Internal
{
    internal static class ExceptionCreationHelpers
    {
        internal static ArgumentNullException CreateArgumentNullException(string paramName)
            => CreateArgumentNullException(paramName, $"Argument {paramName} cannot be equal to null");

        internal static ArgumentNullException CreateArgumentNullException(string paramName, string message)
            => new ArgumentNullException(paramName, message);

        internal static ArgumentException CreateArgumentException(string paramName, string message)
            => new ArgumentException(message, paramName);
    }
}