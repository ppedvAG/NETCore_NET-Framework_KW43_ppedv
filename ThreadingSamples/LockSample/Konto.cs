using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LockSample
{
    public static class Konto
    {
        public static decimal Kontostand { get; set; } = 5; //Startguthaben bei Kontoeröffnung :-) 
        public static int TransactionsId { get; set; } = 0; //TransactionsId wird pro Transaction um den Wert 1 erhöht. 

        public static object lockObject = new object();

        public static void Einzahlen(decimal betrag)
        {
            try
            {
                lock (lockObject) //Wenn ein Thread, sich gerade innerhalb von Lock befindet, müssen weitere Threads warten, bis Lock-Freigegeben wird
                {
                    TransactionsId++;
                    Kontostand += betrag;
                    Console.WriteLine($"Id{TransactionsId}:  Kontostand nach dem Einzahlen: {Kontostand}");
                } //Thread verlässt den Lock-Bereich und gibt Lock-Bereich wieder frei
            }
            catch (Exception ex)
            {

            }
        }

        public static void Abheben(decimal betrag)
        {
            try
            {
                TransactionsId++;
                Kontostand -= betrag;


                Console.WriteLine($"Id{TransactionsId}:  Kontostand nach dem Auszahlen: {Kontostand}");
            }
            catch (Exception ex)
            {

            }
        }
    }
}
