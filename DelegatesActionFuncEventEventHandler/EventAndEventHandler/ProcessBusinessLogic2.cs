using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventAndEventHandler
{
    public class ProcessBusinessLogic2
    {
        public event EventHandler ProcessCompleted;

        public event EventHandler ProcessCompletedNew;

        public void StartProcess()
        {


            //Machwas


            OnProcessCompleted(EventArgs.Empty);





            MyEventArgs myEventArgs = new MyEventArgs();
            myEventArgs.Uhrzeit = DateTime.Now;

            OnProcessCompletedNew(myEventArgs);
        }

        protected virtual void OnProcessCompleted(EventArgs e)
        {
            ProcessCompleted?.Invoke(this, e);
        }

        protected virtual void OnProcessCompletedNew(MyEventArgs e)
        {
            ProcessCompletedNew?.Invoke(this, e);
        }
    }

    public class MyEventArgs : EventArgs
    {
        public DateTime Uhrzeit { get; set; }
    }
}
