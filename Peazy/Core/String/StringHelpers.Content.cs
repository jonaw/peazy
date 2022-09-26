using System.Linq;

namespace Peazy.Core
{
    internal static partial class StringHelpers
    {
        public static bool IsIntegerString(string value)
        {
            return value.ToCharArray().All(c => char.IsDigit(c));
        }
    }
}