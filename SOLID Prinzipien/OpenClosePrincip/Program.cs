using System;

namespace OpenClosePrincip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    #region BadCode

    public class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }    
    }

    public class ReportGenerator
    {
        public string ReportType { get; set; }

        public void GenerateReport(Employee employee)
        {
            if (ReportType == "CRS")
            {
                //Report for Crystal REport
            }

            if (ReportType == "PDF")
            {
                //
            }
        }
    }

    #endregion


    #region OpenClose with abstract Class 

    public abstract class ReportGeneratorBase
    {
        public abstract void Generate();
    }

    public class PDFGenerator : ReportGeneratorBase
    {
        public override void Generate()
        {
            //Implementierung für  PDF
        }
    }

    public class CrystalREportGenerator : ReportGeneratorBase
    {
        public override void Generate()
        {
            //Implementierung für CR 
        }
    }
    #endregion
}
