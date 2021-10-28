using System;
using System.Threading;

namespace ThreadBeenden
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread thread = new Thread(MachEtwas);
            thread.Start();
            Thread.Sleep(3000);

            //thread.Abort(); Abort ist obselete

            //Nach 3 Sekunden wird Thread abgebrochen
            thread.Interrupt(); //Thread wird beendet

            Console.WriteLine("Ready");
            Console.ReadLine();
        }


        private static void MachEtwas()
        {
            try
            {
                for (int i = 0; i < 50 ; i++)
                {
                    Console.WriteLine("zzzZZZZzzzzzZZZZZZ");
                    Thread.Sleep(200);
                }
            }
            catch
            {

            }
        }
    }
}
