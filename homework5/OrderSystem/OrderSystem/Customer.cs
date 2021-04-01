using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystem
{
    class Customer
    {
        public Customer(string name,string telephone,string address)
        {
            this.name = name;
            this.telephone = telephone;
            this.address = address;
        }
        internal string name { get; set; }
        internal string telephone { get; set; }
        internal string address { get; set; }
        public override bool Equals(object obj)
        {
            Customer temp = obj as Customer;
            return temp.name == name
                && temp.address == address
                && temp.telephone == telephone;
        }
        public override int GetHashCode()
        {
            return Convert.ToInt32(telephone);
        }
        public override string ToString()
        {
            return  "Customer:" + name + "\n"
                  + "Telephone :" + telephone.ToString() + "\n"
                  + "address :" + address + "\n";
        }
    }

}
