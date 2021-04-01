using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*写一个订单管理的控制台程序，能够实现添加订单、删除订单、修改订单、查询订单（按照订单号、商品名称、客户、订单金额等进行查询）功能。
提示：主要的类有Order（订单）、OrderDetails（订单明细），OrderService（订单服务），订单数据可以保存在OrderService中一个List中。在Program里面可以调用OrderService的方法完成各种订单操作。
要求：
（1）使用LINQ语言实现各种查询功能，查询结果按照订单总金额排序返回。partly done 目前不清楚‘查询结果按照订单总金额排序返回’啥意思 测试成功
（2）在订单删除、修改失败时，能够产生异常并显示给客户错误信息。done 测试成功
（3）作业的订单和订单明细类需要重写Equals方法，确保添加的订单不重复，每个订单的订单明细不重复。done
（4）订单、订单明细、客户、货物等类添加ToString方法，用来显示订单信息。done
（5） OrderService提供排序方法对保存的订单进行排序。默认按照订单号排序，也可以使用Lambda表达式进行自定义排序。 done
*/
namespace OrderSystem
{
    class Program
    {
        static void Main(string[] args)//测试done
        {
            string address1 = "武汉大学";
            Goods goods1 = new Goods("RTX3090", 20999, "深圳", address1);
            Goods goods2 = new Goods("RTX3080", 15999, "深圳", address1);
            Goods goods3 = new Goods("RTX3070", 10999, "深圳", address1);
            Customer customer1 = new Customer("Mr.X", "123456", address1);
            Customer customer2 = new Customer("Mr.Y", "123456", address1);
            Customer customer3 = new Customer("Mr.Z", "123456", address1);
            OrderService test = new OrderService();
            Order first = new Order("1",goods1,customer1);
            Order second = new Order("2", goods2, customer2);
            Order third = new Order("3", goods3, customer3);
            test.AddOrder(first);
            test.AddOrder(third);
            test.AddOrder(second);
            //test.ToString();//OderAdd测试和ToString()测试
            //test.Sort();//Sort测试
            Console.WriteLine(test.Select("ID", "1").ToString());//test.Select();//Select测试
            //test.ToString();
            Console.Read();
            
        }
    }
}
