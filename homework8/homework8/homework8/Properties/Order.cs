using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystem
{
    public class Order:IComparable//按照订单号、商品名称、客户、订单金额等进行查询
    {
        internal string id { get; set; }
        internal int number { get; set; }
        internal OrderDetails details { get; set; }

        public Order(string id, Goods goods, Customer customer,int number=1) 
        {
            this.id = id;
            details=new OrderDetails(goods,customer);
        }
        public void Update( string command, string infor)
        {
            Action<string> action= ChooseCommand(command);//方便之后再添加处理的事件
            action(infor);
        }
        public Action<string> ChooseCommand(string command)
        {
            Action<string> action = null;
            try
            {
                
                switch (command)
                {
                    case "ID":
                    case "id": action = (i) => {id = i; }; break;
                    case "Name":
                    case "name": action = (i) => { details.goods.name = i; }; break;
                    case "Customer":
                    case "customer": action = (i) => { details.customer.name = i; }; break;
                    case "Price":
                    case "price": action = (i) => { details.goods.price = Convert.ToDouble(i); }; break;
                    case "Number":
                    case "number": action = (i) => { number = Convert.ToInt32(i); }; break;
                    default: Console.WriteLine("未找到相关命令"); break;
                }
            }catch(Exception e)
            {
                Console.WriteLine("命令格式错误或相关数据输入格式错误\n" + e);
            }
            return action;
        }
        public override bool Equals(object obj)
        {
            Order temp = obj as Order;
            return (obj != null && id == temp.id&& details.Equals(temp.details));
        }
        
        public override int GetHashCode()
        {
            return Convert.ToInt32(id);
        }

        public int CompareTo(object obj)
        {
            if(obj is Order)
            {
                Order temp = obj as Order;
                return id.CompareTo(temp.id);//此处可进行修改
            }
            else { throw new NotImplementedException(); } 
        }
        public override string ToString()
        {
            Console.WriteLine("ID:"+id);
            Console.WriteLine("Number:" + number);
            Console.WriteLine(details.goods.ToString());
            Console.WriteLine(details.customer.ToString());
            return null;
        }
    }
}
