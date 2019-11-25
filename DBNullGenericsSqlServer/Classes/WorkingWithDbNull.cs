using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBNullGenericsSqlServer.Classes
{
    public class WorkingWithDbNull
    {
        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? AccountNumber { get; set; }
        public decimal? Dues { get; set; }
        public DateTime? RenewDate { get; set; }
        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
