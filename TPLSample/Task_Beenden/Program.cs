using System;
using System.Threading;
using System.Threading.Tasks;

namespace Task_Beenden
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CancellationTokenSource cts = new CancellationTokenSource(); //Ab .NET 4.0 
            Task easyTask = new Task(MeineMethodeMitAbbrechen, cts);
            easyTask.Start();


            Thread.Sleep(5000);
            cts.Cancel();


        }

        private static void MeineMethodeMitAbbrechen(object param)
        {
            CancellationTokenSource source = (CancellationTokenSource)param;

            while (true)
            {
                Console.WriteLine("zzzzZZZzzzZZZzzzZZZzzzZZZZZ");
                Thread.Sleep(50);

                if (source.IsCancellationRequested)
                    break;
            }
        }
    }
}
