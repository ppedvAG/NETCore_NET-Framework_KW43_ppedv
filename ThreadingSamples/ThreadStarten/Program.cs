using System;
using System.Threading;

namespace ThreadStarten
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread thread = new Thread(MachEtwasInEinemThread);
            thread.Start();
            thread.Join(); //Wir warten bis Thread fertig ist

            

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("*");
            }
        }

        private static void MachEtwasInEinemThread()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("#");
            }
        }
    }
}
