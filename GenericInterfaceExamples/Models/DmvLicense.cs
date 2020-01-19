using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericInterfaceExamples.Models
{
    public class DmvLicenses : Person
    {
        public int Id { get; set; }
        public string DriversLicenseNumber { get; set; }
        public DateTime? BirthDate { get; set; }
        public string SsnLastFour { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressCity { get; set; }
        public string AddressZipCode { get; set; }
        public string MailingAddressCity { get; set; }
        public string MailingAddressZipCode { get; set; }
        public DateTime? ProcessDate { get; set; }
        public string DeceasedFlag { get; set; }
        public string WorkInLieuFlag { get; set; }
        public string ExpiredFlag { get; set; }
    }
}