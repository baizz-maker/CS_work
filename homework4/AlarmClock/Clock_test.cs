using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmClock
{
    class Clock_test
    {
        static void Main(string[] args)
        {
            Alarm_form form = new Alarm_form();
            form.button.Push(12, "Date!");
            Console.ReadKey();
        }
    }
}
