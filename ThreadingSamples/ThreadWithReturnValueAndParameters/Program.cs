using System;
using System.Threading;

namespace ThreadWithReturnValueAndParameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string retStr = string.Empty;
            string meinText = "Hello World";


            Thread thread = new Thread(() =>
            {
                retStr = StringToUpper(meinText);
            });

            thread.Start();
            thread.Join();


            Console.WriteLine(retStr);
            Console.ReadLine();
        }


        public static string StringToUpper(string param1)
        {
            return param1.ToUpper(); //Alles wird in Großbuchstaben zurückgegeben
        }
    }
}
