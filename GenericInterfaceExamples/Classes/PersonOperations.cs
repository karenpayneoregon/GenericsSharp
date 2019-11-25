using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericInterfaceExamples.Interfaces;
using GenericInterfaceExamples.Models;

namespace GenericInterfaceExamples.Classes
{
    public class PersonOperations : IClassActions<Person>
    {
        public Person GetById(decimal id)
        {
            return null;
        }

        public Person Update(Person entity)
        {
            return null;
        }

        public Person Add(Person entity)
        {
            return null;
        }

        public Person Delete(int id)
        {
            return null;
        }

        public int Commit()
        {
            return 0;
        }

        public List<Person> GetAll()
        {
            return null;
        }
    }
}
