using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystem
{
   
    class OrderService
    {
        
          
        protected List<Order> list { get; set; }
        
        OrderService()
        {

        }
        public void AddOrder(Order a)
        {
            try 
            {
                foreach (Order i in list)
                    if (i.Equals(a))
                    {
                        Console.WriteLine("订单已存在，请勿重复添加订单");
                        return;
                    }
                        
                list.Add(a); 
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
                action=ChooseCommand(command,p);
                Order temp=action(p);
                list.Remove(temp);
            }
            catch(Exception e)
            {
                Console.WriteLine("未查询到该订单  Error:"+e);
            }     
        }
        public Order Select(string command, string p,string message)
        {
            try
            {
                Func<string, Order> temp = ChooseCommand(command, p);
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
                Order temp = Select(command, p, message); 

            }
            catch (Exception e)
            {

            }
            

        }
        public void Sort()//默认按照ID排
        {
            list.Sort();
        }
        public Func<string, Order> ChooseCommand(string command,string p)
        {
            Func<string,Order> action=null;
            switch (command)
            {
                case "ID":
                case "id": action=(i)=> { Order select = (Order)list.Where(s => s.id == i);return select; }; break;
                case "Name":
                case "name": action = (i) => { Order select = (Order)list.Where(s => s.details.goods.name == i); return select; }; break;
                case "Customer":
                case "customer": action = (i) => { Order select = (Order)list.Where(s => s.details.customer.name == i); return select; }; break;
                case "Price":
                case "price": action = (i) => { Order select = (Order)list.Where(s => s.details.goods.price.ToString() == i); return select; }; break;
                default:Console.WriteLine("未找到相关命令");break;
            }
            //var select = list.Where(s => s.id == p);
            //list.Remove((Order)select);
            return action;
        }
    }
}
