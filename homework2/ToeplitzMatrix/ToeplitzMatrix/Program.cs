using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToeplitzMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] test1 = new int[3, 3] { { 1, 2, 3 },{ 1, 2, 3 },{ 1, 2, 3 } };//For test
            int[,] test2 = new int[3, 3] { { 1, 2, 3 }, { 4, 1, 2 }, { 5, 4, 1 } };//For test
            Console.WriteLine("Test1:" + ToeplitzMatrix(test1));
            Console.WriteLine("Test2:" + ToeplitzMatrix(test2));
            Console.ReadLine();
        }
        private static bool ToeplitzMatrix(int[,]target)
        {
            if (target.GetLength(0) != target.GetLength(1))//进行行和列的长度比较
                Console.WriteLine("输入非矩阵");
            else
            {
                for(int i=0;i< target.GetLength(0)-1;i++)//右侧无需进行
                    for(int j = 0; j < target.GetLength(1)-1; j++)//下侧无需进行
                    {
                        if (target[i, j] != target[i + 1, j + 1])
                            return false;
                    }
            }
            return true;
        }
    }
}
