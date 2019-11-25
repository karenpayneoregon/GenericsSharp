using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericInterfaceExamples.Interfaces;
using GenericInterfaceExamples.Models;

namespace GenericInterfaceExamples.Classes
{
    public class DmvLicensesWork : IClassActions<DmvLicenses>
    {

        public DmvLicenses GetById(decimal id)
        {
            return null;
        }

        public DmvLicenses Update(DmvLicenses entity)
        {
            return null;
        }

        public DmvLicenses Add(DmvLicenses entity)
        {
            return null;
        }

        public DmvLicenses Delete(int id)
        {
            return null;
        }

        public int Commit()
        {
            return 0;
        }

        public List<DmvLicenses> GetAll()
        {
            return null;
        }
    }
}
