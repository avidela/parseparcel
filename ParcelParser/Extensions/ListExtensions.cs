using System.Collections.Generic;
using System.Linq;

namespace ParcelParser.Extensions
{
    internal static class ListExtensions
    {
        internal static double PopMax(this IList<double> self)
        {
            var max = self.Max();
            self.Remove(max);
            return max;
        }
    }
}
