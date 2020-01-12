using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseConnectionLibrary;
using BaseConnectionLibrary.ConnectionClasses;
using DBNullGenericsSqlServer.Extensions;

namespace DBNullGenericsSqlServer.Classes
{
    public class SqlOperations : SqlServerConnection
    {
        /// <summary>
        /// Define database and default catalog for connection string
        /// to SQL-Server database. Change DatabaseServer to the name
        /// of your server e.g. .\SQLEXPRESS 
        /// </summary>
        public SqlOperations()
        {
            DatabaseServer = "KARENS-PC";
            DefaultCatalog = "TechNetData";
        }
        /// <summary>
        /// Read table with known nulls in all fields except the primary key
        /// Read operation is wrapped in a try catch to avoid known exceptions to be thrown
        /// </summary>
        /// <returns></returns>
        public (List<WorkingWithDbNull> records, List<string> errorList) ReadTableConventionalNoAssertions()
        {
            var results = new List<WorkingWithDbNull>();
            var errorMessages = new List<string>();

            using (var cn = new SqlConnection {ConnectionString = ConnectionString})
            {
                using (var cmd = new SqlCommand {Connection = cn})
                {

                    cmd.CommandText = "SELECT id,FirstName,LastName,AccountNumber,Dues,RenewDate " + 
                                      "FROM dbo.WorkingWithDbNull";

                    cn.Open();

                    var reader = cmd.ExecuteReader();


                        while (reader.Read())
                        {
                            try
                            {
                                results.Add(new WorkingWithDbNull()
                                {
                                    id = reader.GetInt32(0),
                                    FirstName = reader.GetString(1),
                                    LastName = reader.GetString(2),
                                    AccountNumber = reader.GetInt32(3),
                                    Dues = reader.GetDecimal(4),
                                    RenewDate = reader.GetDateTime(5)
                                });
                            }
                            catch (Exception ex)
                            {
                                errorMessages.Add(ex.Message);
                            }
                        }
                    

                }
            }
            
            return (results, errorMessages);
        }
        /// <summary>
        /// Read table with known nulls in all fields except the primary key
        /// Read fields using inline DBNull assertions, try catch not needed in
        /// this case yet no a bad idea to keep in the event a unknown problem rises.
        /// </summary>
        /// <returns></returns>
        public (List<WorkingWithDbNull> records, List<string> errorList) ReadTableWithAssertions()
        {
            var results = new List<WorkingWithDbNull>();
            var errorMessages = new List<string>();

            using (var cn = new SqlConnection { ConnectionString = ConnectionString })
            {
                using (var cmd = new SqlCommand { Connection = cn })
                {

                    cmd.CommandText = "SELECT id,FirstName,LastName,AccountNumber,Dues,RenewDate " + 
                                      "FROM dbo.WorkingWithDbNull";

                    cn.Open();

                    var reader = cmd.ExecuteReader();


                    while (reader.Read())
                    {
                        try
                        {
                            var record = new WorkingWithDbNull
                            {
                                id = reader.GetInt32(0),
                                FirstName = reader["FirstName"] is DBNull ? null : reader["FirstName"].ToString(),
                                LastName = reader["LastName"] is DBNull ? null : reader["LastName"].ToString(),
                                AccountNumber = reader["AccountNumber"] is DBNull ? (int?) null : Convert.ToInt32(reader["AccountNumber"]),
                                Dues = reader["Dues"] is DBNull ? (decimal?)null : Convert.ToDecimal(reader["Dues"]),
                                RenewDate = reader["RenewDate"] is DBNull ? (DateTime?)null : Convert.ToDateTime(reader["RenewDate"])
                            };

                            results.Add(record);

                        }
                        catch (Exception ex)
                        {
                            errorMessages.Add(ex.Message);
                        }
                    }

                }
            }

            return (results, errorMessages);
        }
        /// <summary>
        /// Read table with known nulls in all fields except the primary key
        /// Read fields using generic methods which keeps code uncluttered unlike the method
        /// above using inline DBNull assertions. try catch not needed in
        /// this case yet no a bad idea to keep in the event a unknown problem rises.
        /// </summary>
        /// <returns></returns>
        public (List<WorkingWithDbNull> records, List<string> errorList) ReadTableWithGenerics()
        {
            var results = new List<WorkingWithDbNull>();
            var errorMessages = new List<string>();

            using (var cn = new SqlConnection { ConnectionString = ConnectionString })
            {
                using (var cmd = new SqlCommand { Connection = cn })
                {

                    cmd.CommandText = "SELECT id,FirstName,LastName,AccountNumber,Dues,RenewDate " + 
                                      "FROM dbo.WorkingWithDbNull " + 
                                      "ORDER BY LastName DESC";


                    cn.Open();

                    var reader = cmd.ExecuteReader();


                    while (reader.Read())
                    {
                        try
                        {
                            results.Add(new WorkingWithDbNull()
                            {
                                id = reader.GetInt32(0),
                                FirstName = DbNulls.To<string>(reader["FirstName"]),
                                LastName = DbNulls.To<string>(reader["LastName"]),
                                AccountNumber = DbNulls.To<int>(reader["AccountNumber"]),
                                Dues = DbNulls.To<decimal>(reader["Dues"]),
                                RenewDate = DbNulls.To<DateTime>(reader["RenewDate"])
                            });
                        }
                        catch (Exception ex)
                        {
                            errorMessages.Add(ex.Message);
                        }
                    }
                }
            }

            return (results, errorMessages);
        }
        /// <summary>
        /// Read table with known nulls in all fields except the primary key
        /// Read fields using a generic extension which keeps code uncluttered unlike the method
        /// above using inline DBNull assertions. try catch not needed in
        /// this case yet no a bad idea to keep in the event a unknown problem rises.
        /// </summary>
        /// <returns></returns>
        public async Task<(List<WorkingWithDbNull> records, List<string> errorList)> ReadTableWithGenericsExtensionsAsync()
        {
            var results = new List<WorkingWithDbNull>();
            var errorMessages = new List<string>();

            using (var cn = new SqlConnection { ConnectionString = ConnectionString })
            {
                using (var cmd = new SqlCommand { Connection = cn })
                {

                    cmd.CommandText = 
                        "SELECT id,FirstName,LastName,AccountNumber,Dues,RenewDate " + 
                        "FROM dbo.WorkingWithDbNull " + 
                        "ORDER BY LastName DESC";

                    await cn.OpenAsync();

                    var reader = await cmd.ExecuteReaderAsync();


                    while (await reader.ReadAsync())
                    {
                        try
                        {
                            results.Add(new WorkingWithDbNull()
                            {
                                id = reader.GetInt32(0),
                                FirstName = reader.Get<string>("FirstName"),
                                LastName = DbNulls.To<string>(reader["LastName"]),
                                AccountNumber = reader.Get<int>("AccountNumber"),
                                Dues = reader.Get<decimal>("Dues"),
                                RenewDate = reader.Get<DateTime>("RenewDate")
                            });

                        }
                        catch (Exception ex)
                        {
                            errorMessages.Add(ex.Message);
                        }
                    }
                }
            }

            return (results, errorMessages);
        }

        public List<WorkingWithDbNull> ReaderToList()
        {
            using (var cn = new SqlConnection {ConnectionString = ConnectionString})
            {
                using (var cmd = new SqlCommand {Connection = cn})
                {
                    cmd.CommandText = "SELECT id,FirstName,LastName,AccountNumber,Dues,RenewDate FROM dbo.WorkingWithDbNull ORDER BY LastName DESC";

                    cn.Open();

                    var reader = cmd.ExecuteReader();
                    return Mapper.DataReaderToList<WorkingWithDbNull>(reader);
                }
            }
        }
    }
}
