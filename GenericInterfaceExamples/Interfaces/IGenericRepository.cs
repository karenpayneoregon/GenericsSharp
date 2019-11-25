using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericInterfaceExamples.Interfaces
{
    public interface IClassActions<T>
    {
        T GetById(decimal id);
        T Update(T entity);
        T Add(T entity);
        T Delete(int id);
        int Commit();
        List<T> GetAll();
    }
}
