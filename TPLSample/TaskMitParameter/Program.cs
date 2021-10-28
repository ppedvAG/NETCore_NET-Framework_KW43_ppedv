using System;
using System.Threading.Tasks;

namespace TaskMitParameter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Katze katze = new();

            Task<string> task1 = new Task<string>(() => MachEtwas(katze));
            task1.Start();
            task1.Wait();
            string result = task1.Result;

            //Beispiel mit mehrere Parameter
            Task<string> task2 = new Task<string>(() => MachEtwas(katze, DateTime.Now));


            Task<string> task3 = Task.Factory.StartNew(MachEtwas, katze);
            task3.Wait();
            string result1 = task3.Result;


            // via Task.Run

            Task<string> task4 = Task.Run<string>(() => MachEtwas(katze));
            task4.Wait();
            string result2 = task4.Result;
        }


        private static string MachEtwas(object input)
        {
            if (input is Katze myCat)
                return myCat.Name;


            throw new ArgumentException();
        }

        private static string MachEtwas(object input, DateTime dateTime)
        {

            Console.WriteLine(((Katze)input).Name);
            Console.WriteLine(dateTime.ToShortDateString());

            return dateTime.ToShortDateString();
        }
    }


    public class Katze
    {
        public string Name { get; set; } = "Maya";
    }
}
