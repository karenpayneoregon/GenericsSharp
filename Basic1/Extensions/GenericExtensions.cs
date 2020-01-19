using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic1.Extensions
{
    public static class GenericExtensions
    {
        /// <summary>
        /// Determine if T is between lower and upper
        /// </summary>
        /// <typeparam name="T">Data type</typeparam>
        /// <param name="actual">Value to determine if between lower and upper</param>
        /// <param name="lower">Lower of range</param>
        /// <param name="upper">Upper of range</param>
        /// <returns>True if in range, false if not in range</returns>
        /// <example>
        /// <code>
        /// var startDate = new DateTime(2018, 12, 2, 1, 12, 0);
        /// var endDate = new DateTime(2018, 12, 15, 1, 12, 0);
        /// var theDate = new DateTime(2018, 12, 13, 1, 12, 0);
        /// Assert.IsTrue(theDate.Between(startDate,endDate));
        /// </code>
        /// </example>
        public static bool Between<T>(this T actual, T lower, T upper) where T : IComparable<T>
        {
            return actual.CompareTo(lower) >= 0 && actual.CompareTo(upper) < 0;
        }
    }
}
