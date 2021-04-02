using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmClock
{
    public delegate void PushHandler(object sender, PushEventArgs args);
    public class PushEventArgs
    {
        public int counter { get; set; }

        public string appointment { get; set; }
    }
}
