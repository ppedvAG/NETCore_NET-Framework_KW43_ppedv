using System;

namespace DelegatesActionFuncSamples
{
    public class Program
    {
        //mithilfe von delegates kann man einen Datentyp Delegate-Typ definieren

        //Delegate kann mit Methoden zusammenarbeiten, die die selbe Methoden-Signature besitzen
        //Was ist eine Methoden Signature: Rückgabewert und Parameterliste in Kombination. 


        delegate int NumbChange(int n);
        delegate int CalculationDelegate(int zahl1, int zahl2);


        static void Main(string[] args)
        {
            #region Delegates
            NumbChange n = new NumbChange(AddNumber);   // Methoden-Zeiger wird übergeben  
            Console.WriteLine(n(15) ); //Wert 20 wird ausgegben 

            n += SubNumber; //weitere Methode dem NumbChange hinzufügen

            int result = n(30);

            n -= SubNumber;
            result = n(33); //38 werden zurück gegeben


            //CalculationDelgate 
            CalculationDelegate calc = new CalculationDelegate(Addition);
            result = calc(11, 22); //33
            #endregion

            //Action arbeitet mit Methoden zusammen, die ein VOID zurückgeben
            Action a1 = new Action(A);
            a1(); //Wir rufen via Action die Methode A auf 
            a1 += B;
            a1(); //Wir rufen die Methoden A und B auf 

            Action<int> actionWithParameter = new Action<int>(C);
            actionWithParameter(11);


            //Func bietet Rückgabewerte an

            Func<int, int> func = new Func<int, int>(AddNumber);
            result = func(123);

            //128
        }

        #region Delegate-Beispiele
        public static int AddNumber(int number)
        {
            return number + 5;
        }

        public static int SubNumber(int number)
        {
            return number - 5;
        }
        public static int Addition(int z1, int z2)
        {
            return z1 + z2;
        }
        #endregion
        #region Action-Beispiele

        public static void A()
        {
            Console.WriteLine("A");
        }

        public static void B()
        {
            Console.WriteLine("B");
        }

        public static void C(int zahl)
        {
            Console.WriteLine(zahl);
        }
        #endregion
    }
}
