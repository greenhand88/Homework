using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 简易计算器_控制台_
{
    class Program
    {
        static void Main(string[] args)
        {
            string temp1, temp2, temp3;
            double number1, number3;
            temp1 = Console.ReadLine(); temp2 = Console.ReadLine(); temp3 = Console.ReadLine();
            number1 = double.Parse(temp1);
            number3 = double.Parse(temp3);
            switch (temp2)
            {
                case "+": temp3 = Convert.ToString(number1 + number3); break;
                case "-": temp3 = Convert.ToString(number1 - number3); break;
                case "*": temp3 = Convert.ToString(number1 * number3); break;
                case "/": temp3 = Convert.ToString(number1 / number3); break;
                default: Console.WriteLine("输入符号错误"); break;
            }
            Console.WriteLine("结果是"+temp3);
            Console.ReadLine();
        }
    }
}
