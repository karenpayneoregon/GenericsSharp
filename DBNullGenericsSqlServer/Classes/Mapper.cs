using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DBNullGenericsSqlServer.Classes
{
    public class Mapper
    {
        /// <summary>
        /// Iterate returning records, populate properties by matching fields to
        /// properties via reflection.
        ///
        /// This should be considered fragile, if properties and fields don't match
        /// this will break.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="reader"></param>
        /// <returns></returns>
        public static List<T> DataReaderToList<T>(IDataReader reader) 
        {
            var listBasedOnPassedType = new List<T>();

            // ReSharper disable once SuggestVarOrType_SimpleTypes
            T genericObject = default(T);

            while (reader.Read())
            {
                genericObject = Activator.CreateInstance<T>();

                foreach (var prop in genericObject.GetType().GetProperties())
                {
                    if (!Equals(reader[prop.Name], DBNull.Value))
                    {
                        prop.SetValue(genericObject, reader[prop.Name], null);
                    }
                }

                listBasedOnPassedType.Add(genericObject);
            }

            return listBasedOnPassedType;
        }
    }
}
