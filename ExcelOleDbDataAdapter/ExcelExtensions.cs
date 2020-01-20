using System;
using System.Data.OleDb;
using System.IO;

namespace ExcelOleDbDataAdapter
{
    internal static class ExcelExtensions
    {
        public enum UseHeader
        {
            /// <summary>
            /// Indicates that the first row contains column names, no data
            /// </summary>
            /// <remarks></remarks>
            Yes,
            /// <summary>
            /// Indicates that the first row does not contain column names
            /// </summary>
            /// <remarks></remarks>
            No
        }
        public enum ExcelImex
        {
            TryScan = 0,
            Resolve = 1
        }

        public static void SetExcelConnectionString(this OleDbConnection sender, string fileName, UseHeader header, ExcelImex IMEX)
        {

            string mode = Convert.ToInt32(IMEX).ToString();
            var builder = new OleDbConnectionStringBuilder { DataSource = fileName };
            if (Path.GetExtension(fileName).ToUpper() == ".XLSX")
            {
                builder.Provider = "Microsoft.ACE.OLEDB.12.0";
                builder.Add("Extended Properties", "Excel 12.0;IMEX=" + mode + ";HDR=" + header + ";");
            }
            else
            {
                builder.Provider = "Microsoft.Jet.OLEDB.4.0";
                builder.Add("Extended Properties", "Excel 8.0;IMEX=" + mode + ";HDR=" + header + ";");
            }

            sender.ConnectionString = builder.ConnectionString;
        }
    }

}
