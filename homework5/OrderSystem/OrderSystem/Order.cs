using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystem
{
    class Order:IComparable//按照订单号、商品名称、客户、订单金额等进行查询
    {
        internal string id { get; set; }
        internal OrderDetails details { get; set; }

        public Order(string id, Goods goods, Customer customer) 
        {
            this.id = id;
            details=new OrderDetails(goods,customer);
        }
        public void Update(Order target, string command, string p)
        {
            ChooseCommand(target, command, p);//方便之后再添加处理的事件
        }
        public Action<string> ChooseCommand(Order target,string command, string p)
        {
            Action<string> action = null;
            switch (command)
            {
                case "ID":
                case "id": action = (i) => { target.id=i; }; break;
                case "Name":
                case "name": action = (i) => { target.details.goods.name = i; }; break;
                case "Customer":
                case "customer": action = (i) => { target.details.customer.name = i; }; break;
                case "Price":
                case "price": action = (i) => { target.details.goods.price = Convert.ToDouble(i); }; break;
                default: Console.WriteLine("未找到相关命令"); break;
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
            Console.WriteLine(details.goods.ToString());
            Console.WriteLine(details.customer.ToString());
            return null;
        }
    }
}
