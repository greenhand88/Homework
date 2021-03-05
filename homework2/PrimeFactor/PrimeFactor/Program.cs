using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeFactor
{
    class Program
    {
        static void Main(string[] args)
        {
            int test = 10;//This is for test
            FindPrimeFactor(test);
            Console.Read();//For pause
        }
        public static void FindPrimeFactor(int target)
        {   int temp = target;
            int[] list = new int[1000];
            int count = 0;
            for(int i = 2; i <=temp; i++)
            {
                if (temp % i == 0&&count<32)
                {
                    temp = temp / i;
                    list[count] = i; 
                    i = 2;
                    count++;
                }
            }
            if(count<1000)
                for (int i = 0; i <count; i++)
                    Console.Write(list[i].ToString() + ' ');
        }
    }
}
