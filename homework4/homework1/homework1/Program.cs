using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework1
{/*1、为示例中的泛型链表类添加类似于List<T>类的ForEach(Action<T> action)方法。
  * 通过调用这个方法打印链表元素，求最大值、最小值和求和（使用lambda表达式实现）。*/
    
    public class Test
    {
        
        public static void  Main(string[] args)
        {
            double[] collection = { 0,0,0 };
            double[] temp = { 1.5, 2.6, 3.8 };
            GenericList<double> a=new GenericList<double>();
            foreach(double i in temp)
            {
                a.Add(i);
            }
            Action<Node<double>, double[]> action;
            action=(s,record) =>
            {
                Console.Write(s.Data + "  ");
                if (s.Data > record[0])
                    record[0] = s.Data;
                if (s.Data < record[1])
                    record[1] = s.Data;
                record[2] += s.Data;
            };
            a.ForEach(action,ref collection);
            Console.WriteLine();
            Console.WriteLine("MAX:" + collection[0]);
            Console.WriteLine("MIN:" + collection[1]);
            Console.WriteLine("SUM:" + collection[2]);
            Console.Read();
        }

    }
    
 
}
