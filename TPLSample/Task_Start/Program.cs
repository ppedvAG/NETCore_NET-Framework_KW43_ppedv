using System;

using System.Threading; //Ab 4.x gab es hier auch erweiterung
using System.Threading.Tasks; //Main Feature 

namespace Task_Start
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task task = new Task(MachEtwasInEinemThread);
            
            task.Start(); //thread.start
            task.Wait(); //thread.join

            for (int i = 0; i < 100; i++)
            {
                Console.Write("*");
            }

            Console.ReadKey();
        }

        private static void MachEtwasInEinemThread()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.Write("#");
            }
        }
    }
}
