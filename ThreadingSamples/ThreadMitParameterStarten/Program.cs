using System;
using System.Threading;
namespace ThreadMitParameterStarten
{
    public class Program
    {
        static void Main(string[] args)
        {
            ParameterizedThreadStart parameterizedThreadStart = new ParameterizedThreadStart(MachEtwasInEinemThread);

            Thread thread = new Thread(parameterizedThreadStart);
            thread.Start(600);

            thread.Join();

            for (int i = 0; i < 100; i++)
                Console.WriteLine("*");
            Console.ReadLine();


        }


        private static void MachEtwasInEinemThread(object obj)
        {
            if (obj is int until) //Ist es der Typ -> dann caste nach -> until 
            {
                for (int i = 0; i < until; i++)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
