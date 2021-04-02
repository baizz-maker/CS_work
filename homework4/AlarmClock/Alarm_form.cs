using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmClock
{
    class Alarm_form
    {
        public Button button = new Button();

        public Alarm_form()
        {
            button.OnPush += new PushHandler(TickTok);
            button.OnPush += Alarm;
        }

        void TickTok(object sender, PushEventArgs args)
        {
            int times = 0;
            while (times < args.counter)
            {
                Console.Write("TickTok" + " ");
                times++;
            }
        }

        void Alarm(object sender, PushEventArgs args)
        {

            Console.WriteLine("Doololololoooo");
            Console.WriteLine("You have made an appointment: " + args.appointment);
        }
    }
}
