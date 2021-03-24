using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace homework2
{
    public class Clock
    {
        DateTime alarm;
        public event ClockHandler Tick;
        public event ClockHandler Alarm;
        public void GetTime()
        {
            while (true)
            {
                Console.Write("BeiJing Time:" + DateTime.Now.ToString());
                Tick(this);
                if (DateTime.Now >= alarm)
                {
                    Alarm(this);
                }
                Thread.Sleep(1000);
            }
        }
        public void SetAlarmTime()
        {
            Console.WriteLine("请输入格式为YYYY-MM-DD HH:mm:ss格式的时间");
            string temp = Console.ReadLine();
            if (Convert.ToDateTime(temp).CompareTo(DateTime.Now) >= 0)
                alarm = Convert.ToDateTime(temp);
            else
                Console.WriteLine("设置时间已过");
        }
    }
}
