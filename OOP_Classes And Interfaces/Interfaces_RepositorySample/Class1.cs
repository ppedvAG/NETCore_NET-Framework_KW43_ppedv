using System;
using System.Collections.Generic;

namespace Interfaces_RepositorySample
{


    // Eine Klasse, die sich um das manipulieren einer Tabelle in einer Datenbank befasst. 

    public interface IOldRepository<T> where T : class
    {
        public void Insert(T entity);

        public void Update(T entity);

        public void Delete(T entity);
        
        public T GetById(int id);

        public IEnumerable<T> GetAll();

        public IEnumerable<T> FindAll();
    }


    public interface IReadonlyRepository <T> where T : class
    {
        public T GetById(int id);

        public IEnumerable<T> GetAll();

        public IEnumerable<T> FindAll();
    }


    public interface IRepository<T>  : IReadonlyRepository<T> where T: class
    {
        public void Insert(T entity);

        public void Update(T entity);

        public void Delete(T entity);



    }




    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public int LastName { get; set; }
        public DateTime Birthday { get; set; }
        public int Salary { get; set; }
    }

    public class EmployeeRepository : IRepository<Employee>
    {
        public void Delete(Employee entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employee> FindAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employee> GetAll()
        {
            throw new NotImplementedException();
        }

        public Employee GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Employee entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Employee entity)
        {
            throw new NotImplementedException();
        }


        //UnitOfWork Ansatz -> EFCore DbContext -> SaveChange
    }




    public class ImplementationSample
    {
        public void ReadOnlyRepositorySample()
        {

        }

    }
}
