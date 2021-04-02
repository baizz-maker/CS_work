using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmClock
{
    class Button
    {
        public event PushHandler OnPush;



        public void Push(int counter1, string appointment1)
        {
            Console.WriteLine("You have set the counter as "+ counter1);
            PushEventArgs args = new PushEventArgs() { counter = counter1, appointment = appointment1 };
            OnPush(this, args);
        }

        
    }
}
