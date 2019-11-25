using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBNullGenericsSqlServer.Classes
{
    public static class DbNulls
    {
        /// <summary>
        /// Handles reading DBNull values from database
        /// </summary>
        /// <typeparam name="T">The type of the value to read</typeparam>
        /// <param name="value">The input value to convert</param>
        /// <returns>A strongly typed result, null if the input value is DBNull</returns>
        /// <remarks>
        /// dr.Item("abc").GetValue(string)
        /// dr.Item("def").GetValue(Nullable(of Date))
        /// </remarks>
        public static T To<T>(object value)
        {
            return value is DBNull ? default(T) : (T) ChangeType(value, typeof(T));
        }
        /// <summary>
        /// Wraps Convert.ChangeType() so it handles Nullable types
        /// </summary>
        /// <param name="value">The value to convert</param>
        /// <param name="conversionType">The type to convert into</param>
        /// <returns>The input value converted to type conversionType</returns>
        private static object ChangeType(object value, Type conversionType)
        {
            if (conversionType.IsGenericType && conversionType.GetGenericTypeDefinition() == typeof(Nullable<>))
            {
                if (value == null)
                {
                    return null;
                }

                conversionType = Nullable.GetUnderlyingType(conversionType);
            }

            // ReSharper disable once AssignNullToNotNullAttribute
            return Convert.ChangeType(value, conversionType);
        }

        /// <summary>
        /// Simplifies setting SqlParameter values by handling null issues
        /// </summary>
        /// <param name="value">The value to return</param>
        /// <returns>DBNull if value == null, otherwise we pass through value</returns>
        public static object From(object value)
        {
            return value ?? DBNull.Value;
        }
    }
}
