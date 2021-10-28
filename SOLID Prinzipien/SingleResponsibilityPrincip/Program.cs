using System;

namespace SingleResponsibilityPrincip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }


    #region Schlechtes Beispiel
    public class EmployeeBad
    {
        public int Employee_Id { get; set; }
        public string Employee_Name { get; set; }

        /// <summary>
        /// This method used to insert into employee table
        /// </summary>
        /// <param name="em">Employee object</param>
        /// <returns>Successfully inserted or not</returns>
        public bool InsertIntoEmployeeTable(EmployeeBad em)
        {
            // Insert into employee table.
            return true;
        }

        /// <summary>
        /// Method to generate report
        /// </summary>
        /// <param name="em"></param>
        public void GenerateReport(EmployeeBad em)
        {
            // Report generation with employee data using crystal report.
        }
    }
    #endregion

    #region GoodCode
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }


    //Wir speichern ein Employee in die DB 


    public class EmployeeRepository
    {
        public void Insert(Employee employee)
        {
            //Emplyoee wird in die Tabelle (DB) eingefügt
        }

        ///..Update Delete Read
    }

    public class ReportGenerator
    {
        public void GenerateReport(EmployeeBad em)
        {
            // Report generation with employee data using crystal report.
        }
    }
    #endregion
}
