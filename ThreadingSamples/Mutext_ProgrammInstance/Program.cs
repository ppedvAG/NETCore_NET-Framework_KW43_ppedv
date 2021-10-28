using System;
using System.Threading;

namespace Mutext_ProgrammInstance
{
    internal class Program
    {
        static Mutex _mutex;

        static void Main(string[] args)
        {
            if (!Program.IsSingleInstance2())
            {
                Console.WriteLine("More than one instance");
            }
            else
                Console.WriteLine("one Instance");

            Console.ReadLine();
        }

        static bool IsSingleInstance()
        {
            try
            {
                Mutex.OpenExisting("ABC");
            }
            catch
            {
                Program._mutex = new Mutex(true, "ABC"); //ERste Programm Instanz legt instanziiert das Mutex Object
                return true;
            }


            //Zweite Programm Instance verlässt hier die Methode. 
            return false;
        }


        static bool IsSingleInstance2()
        {
            if (Mutex.TryOpenExisting("ABC", out _mutex))
            {
                return false;
            }
            else
            {
                Program._mutex = new Mutex(true, "ABC");
                return true;
            }
                
        }
    }
}
