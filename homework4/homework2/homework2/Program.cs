using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace homework2
{
    /*2、使用事件机制，模拟实现一个闹钟功能。闹钟可以有嘀嗒（Tick）事件和响铃（Alarm）两个事件。
     * 在闹钟走时时或者响铃时，在控制台显示提示信息。*/
    class Test
    {
        static void Main(string[] args)
        {
            form form1 = new form();
            form1.clock1.SetAlarmTime();
            form1.clock1.GetTime();
        }
    }
}
