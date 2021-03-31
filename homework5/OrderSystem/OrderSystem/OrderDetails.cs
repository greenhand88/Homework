using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystem
{
    class OrderDetails
    {
        internal Goods  goods { get; set; }
        internal Customer customer { get; set; }

        internal OrderDetails(Goods goods, Customer customer)
        {
            this.goods = goods;
            this.customer = customer;
        }
        public override bool Equals(object obj)
        {
            OrderDetails temp = obj as OrderDetails;
            return (goods==temp.goods
                    &&customer==temp.customer);
        }


        public override string ToString()
        {
            return goods.ToString()+customer.ToString();
        }
    }
}
