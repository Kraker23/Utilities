using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities.Extensions
{
    public static class LINQExtension
    {
        /// <summary> EJEMPLO</summary>
        /// <param name="source"></param>
        /// <returns></returns>
        /* public static double Median(this IEnumerable<double> source)
         {
             if (!(source?.Any() ?? false))
             {
                 throw new InvalidOperationException("Cannot compute median for a null or empty set.");
             }

             var sortedList = (from number in source
                               orderby number
                               select number).ToList();

             int itemIndex = sortedList.Count / 2;

             if (sortedList.Count % 2 == 0)
             {
                 // Even number of items.
                 return (sortedList[itemIndex] + sortedList[itemIndex - 1]) / 2;
             }
             else
             {
                 // Odd number of items.
                 return sortedList[itemIndex];
             }
         }*/
     


    }
}
