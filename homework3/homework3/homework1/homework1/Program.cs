using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework1
{/*编写面向对象程序实现长方形、正方形、三角形等形状的类。
  每个形状类都能计算面积、判断形状是否合法。 请尝试合理使用接口/抽象类、属性来实现。
*/
    class Program
    {
           
        static void Main(string[] args)
        {
            int temp;
            Random rand =new Random();
            Shape[] list = new Shape[10];
            for(int i = 0; i < 10; i++)
            {
                temp = rand.Next(1, 4);
                switch (temp)
                {
                    case 1: list[i]=ShapeFactor.GetShape("Rectangle", rand.Next(2, 8), rand.Next(2, 8)); break;
                    case 2: list[i]=ShapeFactor.GetShape("Square", rand.Next(2, 8)); break;
                    case 3: list[i]=ShapeFactor.GetShape("Triangle", rand.Next(2, 8), rand.Next(2, 8), rand.Next(2, 8), rand.Next(2, 8), rand.Next(2, 8)); break;
                    default: break;
                }
            }
            double totalArea = 0;
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(":"+list[i].GetJudge());//先执行内部的方法
                    totalArea += list[i].GetArea();
                }
                Console.WriteLine("Total Area:" + totalArea);
                Console.Read();
            
        }
    }
    public interface Shape
    {
        double GetArea();
        bool   GetJudge();

    }
    public class Rectangle : Shape
    {
        internal double Length { set; get; }
        internal double Width { set; get; }
       public Rectangle(double length,double width)
        {
            if (length >= 0 && width >= 0)
            {
                this.Length = length;
                this.Width = width;
            }
            else
                Console.WriteLine("输入数据错误");
        }
        double Shape.GetArea()
        {    
          return this.Length * this.Width;
        }
        bool Shape.GetJudge()
        {
            Console.Write("Rectangle");
                return true;
        }
    }
    public class Square:Rectangle,Shape
    {
        public Square(double length):base(length, length) {  }
        bool Shape.GetJudge()
        {
            if (this.Length == this.Width)
            {
                Console.Write("Square");
                return true;
            }
            else
            {
                Console.Write("Square");
                return false;
            }
        }
    }
    public class Triangle : Shape
    {
        internal double Height { set; get; }
        internal double Bottom { set; get; }
        internal double Side1 { set; get; }
        internal double Side2 { set; get; }
        internal double Side3 { set; get; }
        public Triangle(double side1, double side2,double side3, double height,double bottom) 
        {
            this.Side1 = side1;
            this.Side2 = side2;
            this.Side3 = side3;
            this.Height = height;
            this.Bottom = bottom;
        }
        public double GetArea()
        {
            return this.Height * this.Bottom / 2;
        }

        public bool GetJudge()
        {
            
            List<double> temp=new List<double>();
            temp.Add(Side1);
            temp.Add(Side2);
            temp.Add(Side3);
            temp.Sort();
            if (temp[0] + temp[1] > temp[2])
            {
                Console.Write("Triangle");
                return true;
            }
            else
            {
                Console.Write("Triangle");
                return false;
            }
        }
    }
    public class ShapeFactor
    {
        public static Shape GetShape(string shape,params double []list)
        {
            int temp;
            Random rand = new Random();
            temp = rand.Next(1, 10);
            if (shape == null)
                return null;
            else
                switch (shape)
                {
                    case "Rectangle":return new Rectangle(list[0],list[1]) ;break;
                    case "Square": return new Square(list[0]); break;
                    case "Triangle": return new Triangle(list[0], list[1], list[2], list[3], list[4]); break;
                    default:break;
                }
            return null;
        }
    }
}
    

   

    

