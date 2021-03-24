using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2
{
    public delegate void ClockHandler(object sender);
    public class form
    {
        public Clock clock1 = new Clock();
        
        public form()
        {
            clock1.Tick += Tick;
            clock1.Alarm +=Alarm;
        }
        void Tick(object sender)
        {
            Console.WriteLine("             Tick");
            System.Media.SystemSounds.Exclamation.Play();
        }
        void Alarm(object sender)
        {
            Console.WriteLine("时间到了");
        }
       
    }
}
