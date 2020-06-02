using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveManagement.Contracts
{
    public interface IRepositoryBase<T> where T : class // constraint - generic identifier where every class that implements this interface should be able to do the specified operations 
    {
        ICollection<T> FindAll(); // returning all from the database - remember that ICollection<T> is the return type
        T FindById(int id);
        bool Create(T entity); // pass in generic type parameter - we can pass in an arbitrary type T to a method at compile time - without specifying a concrete type in the method or class delclaration 
        bool Update(T entity);
        bool Delete(T entity);
        bool Save();
    }
}
