using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomethingAboutArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] test = { 7,6,5,4,2,8,7};//This is for test
            Console.WriteLine("Max:"+GetMax(test));
            Console.WriteLine("Min:"+GetMin(test));
            Console.WriteLine("Ave:"+GetAve(test));
            Console.WriteLine("Sum:"+GetSum(test));
            Console.Read();//For pause
        }
        public static int GetMax(int[]array)
        {
            Array.Sort(array);
            return array[array.Length - 1];
        }
        public static int GetMin(int[] array)
        {
            Array.Sort(array);
            return array[0];
        }
        public static double GetAve(int[] array)
        {
            return GetSum(array) / (double)array.Length;
        }
        public static int GetSum(int[] array)
        {   int sum = 0;
            foreach (int i in array)
                sum += i;
            return sum;
        }
    }
}
