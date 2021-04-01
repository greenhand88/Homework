using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystem
{
    class Goods
    {
        internal string name { get; set; }
        internal double price { get; set; }
        internal string from { get; set; }
        internal string to { get; set; }
        public Goods(string name,double price, string from, string to)
        {
            this.name = name;
            this.price = price;
            this.from = from;
            this.to = to;
        }
        public override bool Equals(object obj)
        {
            Goods temp = obj as Goods;
            return temp.name==name
                &&temp.price==price
                &&temp.to==to
                &&temp.from==from;
        }
        public override int GetHashCode()
        {
            return (int)price;
        }
        public override string ToString()
        {
            return "Goods:"+name+"\n"
                  +"Price:￥"+price.ToString() + "\n"
                  +"From:"+from + "\n"
                  +"To:"+to + "\n";
        }
    }
}
