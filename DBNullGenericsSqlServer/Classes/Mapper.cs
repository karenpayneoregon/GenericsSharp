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
            T genericTypeObject = default(T);

            while (reader.Read())
            {
                genericTypeObject = Activator.CreateInstance<T>();

                foreach (var prop in genericTypeObject.GetType().GetProperties())
                {
                    if (!Equals(reader[prop.Name], DBNull.Value))
                    {
                        prop.SetValue(genericTypeObject, reader[prop.Name], null);
                    }
                }

                listBasedOnPassedType.Add(genericTypeObject);
            }

            return listBasedOnPassedType;
        }
    }
}
