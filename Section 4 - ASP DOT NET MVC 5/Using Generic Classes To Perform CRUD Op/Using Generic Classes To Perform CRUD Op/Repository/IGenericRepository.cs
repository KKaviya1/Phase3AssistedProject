
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Using_Generic_Classes_To_Perform_CRUD_Op.Models;

namespace Using_Generic_Classes_To_Perform_CRUD_Op.Repository
{
    public interface IGenericRepository<t> where T : class
    {
        IEnumerable<t> SelectAll();
        T SelectByID(object id);
        void Insert(T obj);
        void Update(T obj);
        void Delete(object id);
        void Save();
        void Insert(Student student);
        void Update(Student student);
    }
}

