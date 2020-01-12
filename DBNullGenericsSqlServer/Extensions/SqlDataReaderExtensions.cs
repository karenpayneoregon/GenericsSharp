using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBNullGenericsSqlServer.Extensions
{
    public static class SqlDataReaderExtensions
    {
        /// <summary>
        /// Get value for column or default value
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="reader"></param>
        /// <param name="columnName"></param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        public static T Get<T>(this IDataReader reader, string columnName, T defaultValue = default(T))
        {
            var value = reader[columnName];           
            if (value.IsNull())
                return defaultValue;

            return (T)value;
        }
   
        /// <summary>
        /// Assert if value is null or DBNull
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sender"></param>
        /// <returns></returns>
        public static bool IsNull<T>(this T sender) where T : class => sender == null || sender == DBNull.Value;

    }
}
