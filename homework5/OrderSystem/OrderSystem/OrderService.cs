using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystem
{
   
    class OrderService
    {

       public OrderService()
       {
            list = new List<Order>();

       }
        protected List<Order> list { get; set; }
        
        public void AddOrder(Order a)
        {
            try
            {
                if (a != null) 
                {
                    if (list != null)
                        foreach (Order i in list)
                            if (i.Equals(a))
                            {
                                Console.WriteLine("订单已存在，请勿重复添加订单");
                                return;
                            }

                    list.Add(a);
                }
                
            }catch(Exception e)
            {
                Console.WriteLine("订单添加失败  Error:"+e);
            }
            
        }
        public void DeleteOrder(string command, string p)
        {
            Func<string, Order> action = null;
            try 
            {
                action=ChooseCommand(command);
                Order temp=action(p);
                list.Remove(temp);
            }
            catch(Exception e)
            {
                Console.WriteLine("未查询到该订单  Error:"+e);
            }     
        }
        public Order Select(string command,string message)
        {
            try
            {
                Func<string, Order> temp = ChooseCommand(command);
                return temp(message);
            }
            catch(Exception e)
            {
                Console.WriteLine("输入命令格式错误或是未找到相关订单 Error:" + e);
            }
            return null;
        }
        public void Update(string command, string p, string message)
        {
            try 
            { 
                Order temp = Select(command, message); 

            }
            catch (Exception e)
            {
                Console.WriteLine("输入命令格式错误或是未找到相关订单 Error:" + e);
            }
            

        }
        public void Sort()//默认按照ID排
        {
            list.Sort();
        }
        public Func<string, Order> ChooseCommand(string command)
        {
            Func<string,Order> action=null;
            switch (command)
            {
                case "ID":
                case "id": action=(i)=> { List<Order> select = (from item in list where item.id == i select item as Order).ToList();return select[0]; }; break;
                case "Name":
                case "name": action = (i) => { List<Order> select = (from item in list where item.details.goods.name == i select item as Order).ToList(); return select[0]; }; break;
                case "Customer":
                case "customer": action = (i) => { List<Order> select = (from item in list where item.details.customer.name == i select item as Order).ToList(); return select[0]; }; break;
                case "Price":
                case "price": action = (i) => { List<Order> select = (from item in list where item.details.goods.price == Convert.ToDouble(i) select item as Order).ToList(); return select[0]; }; break;
                default:Console.WriteLine("未找到相关命令");break;
            }
            //var select = list.Where(s => s.id == p);
            //list.Remove((Order)select);
            return action;
        }
        public override string ToString()
        {
            foreach(Order i in list)
            {
                Console.WriteLine(i.ToString());
            }
            return null;
        }
    }
}
