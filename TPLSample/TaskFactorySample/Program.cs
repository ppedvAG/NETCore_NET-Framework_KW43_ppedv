using System;
using System.Threading.Tasks;

namespace TaskFactorySample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Variante 1 -> Definiere einen Task und rufe expliziet task.Start auf 
            Task task = new Task(MachEtwasInEinemThread);

            task.Start(); //thread.start
            task.Wait(); //thread.join
            #endregion

            #region Task.Factory.StartNew Sample
            Task task2 = Task.Factory.StartNew(MachEtwasInEinemThread); //Der Task startet sofort
            task2.Wait();
            #endregion
            
            #region Task.Run(MachEtwasInEinemThread);
            Task task3 = Task.Run(MachEtwasInEinemThread); //verkürzte Schreibweise -> intern wird Task.Factory.StartNew verwendet
            task3.Wait();
            #endregion
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
