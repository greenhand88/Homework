using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] test = new int[99];//This is for test
            for(int i = 0; i < 99; i++)
            {
                test[i] = i+2;
            }
            FindPrimeNumber(test);
            Console.Read();//For pause
        }
        /*public static void FindPrimeNumber(int[] array)
         {
             Array.Sort(array);
             bool[] temp1=new bool[array.Length];
             for (int i = 0; i < array.Length; i++)
                 temp1[i] = true;
             //Array.Copy(array, copy, array.Length);
             int Max = array[array.Length-1];
             for(int index=0;index<array.Length;index++)
             {
                 for (int number = 2; number < Math.Sqrt(Max); number++)
                 {
                     if (number > array[index] || array[index] % number == 0)
                         temp1[index] = false;
                         break;
                 }
             }
             useForShow(temp1, array);
         }*/

        public static void FindPrimeNumber(int[] array)
        {
            bool[] temp = new bool[array.Length];
            for(int i=0;i<array.Length;i++)
                temp[i] =true;
            for(int i=2;i<=array.Length/2; i++)//可改
            {
                for(int j = 2; i * j <=array.Length+1; j++)
                {
                    temp[i * j -2] = false;
                }
            }
            for(int i=0;i< array.Length; i++)
            {
                if (temp[i] == true)
                    Console.WriteLine(i+2);
            }

        }
        //private static void useForShow(bool[]temp1,int []array)
        //{ int i = 0;
        //    foreach(bool temp in temp1)
        //    {
        //        if (temp == true)
        //            Console.Write(array[i].ToString()+' ');
        //        i++;
        //    }
        //}
    }
}
