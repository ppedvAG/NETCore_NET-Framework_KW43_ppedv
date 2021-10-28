using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventAndEventHandler
{

    public delegate void Percent(int n);
    public delegate void Notify();

    public class ProcessBusinessLogic
    {
        public event Notify ProcessCompleted; //mit Events können Methoden von ausserhalb drangehongen werden
        public event Percent CurrentPercentStatus;

        public void StartProcess()
        {
            for (int i = 0; i < 100; i++)
            {
                //Irgendwie müssen wir das nach draußen signalisieren, dass wir bei ÜProzent x sind. 
                OnProcessPercentStatus(i);
            }


            //Finish-Meldung -> Callback nach draußen 
            OnProcessCompleted();
        }

        protected virtual void OnProcessCompleted()
        {
            ProcessCompleted?.Invoke(); //Wenn jemand die Property ProcessCompleted als Event-Methode verwendet, wird diese jetzt aufgerufen
        }

        protected virtual void OnProcessPercentStatus(int percent)
        {
            CurrentPercentStatus?.Invoke(percent); //Invoke auf Programm.ProcessBusinessLogic_CurrentPercentStatus(int n)
        }
    }
}
