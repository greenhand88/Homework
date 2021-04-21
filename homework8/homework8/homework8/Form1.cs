using OrderSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework8
{
    public partial class number : Form//创建订单和搜索,删除订单功能成功
    {
        //由于时间限制，简化了许多功能
        OrderService order = new OrderService();
        public number()
        {
            InitializeComponent();
        }



        private void change_details_button_Click(object sender, EventArgs e)//暂时有点问题
        {
            Form2 temp=new Form2();
            temp.ShowDialog();
            string id = temp.Get_ID();
            order.Update("id",id,new Order(id,
                        new Goods(goods_name.Text,Convert.ToDouble(goods_price.Text), null, null),
                        new Customer(customer_name.Text, telenumber.Text, null),
                        (int)numer.Value));
            Clear();
        }

        private void delete_order_button_Click(object sender, EventArgs e)
        {
            Form2 temp = new Form2();
            temp.ShowDialog();
            order.DeleteOrder("id", temp.Get_ID());
        }//成功

        private void creat_order_button_Click(object sender, EventArgs e)//成功
        {
            if (goods_id.Text != null
                   && goods_name.Text != null
                   && goods_price.Text != null
                   && customer_name.Text != null
                   && telenumber.Text != null)
            {
                order.AddOrder(new Order(goods_id.Text,
                                      new Goods(goods_name.Text,
                                      Convert.ToDouble(goods_price.Text), null, null),
                                      new Customer(customer_name.Text, telenumber.Text, null),
                                      (int)numer.Value));
                new Success().ShowDialog();
            }
            Clear();
        }

        private void input_order_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = true;//该值确定是否可以选择多个文件
            dialog.Title = "请选择文件夹";
            dialog.Filter = "所有文件(*.*)|*.*";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                order.Import(dialog.FileName);
            }
            
        }

        private void output_order_button_Click(object sender, EventArgs e)//成功
        {
            FolderBrowserDialog path = new FolderBrowserDialog();
            path.ShowDialog();
            order.Export(path.SelectedPath+"/data.xml");
        }

        private void search_order_button_Click(object sender, EventArgs e)
        {
            Form2 temp =new Form2();
            temp.ShowDialog();
            goods_name.Clear();
            if (order.Select("id", temp.Get_ID()) != null)
            {
                Order a = order.Select("id", temp.Get_ID());
                goods_name.Text = a.details.goods.name;
                goods_price.Text = a.details.goods.price.ToString();
                goods_id.Text = a.id.ToString();
                customer_name.Text = a.details.customer.name;
                telenumber.Text = a.details.customer.telephone;
            }
            else
                goods_id.Text = "无法找到相应订单";
        }

        
        private void Clear()
        {
            goods_id.Clear();
            goods_name.Clear();
            goods_price.Clear();
            customer_name.Clear();
            telenumber.Clear();
        }

        private void show_all_order_button_Click(object sender, EventArgs e)//还在测试中
        {

        }
    }

}
