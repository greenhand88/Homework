using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleCrawler;
namespace homework91
{
    public partial class Form1 : Form
    {
        SimpleCrawler.SimpleCrawler simpleCrawler = new SimpleCrawler.SimpleCrawler();
        public Form1()
        {
            InitializeComponent();
            listBox1.Items.Add("http://www.cnblogs.com/");
            listBox2.Items.Add("game-over/p/14731567.html");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.Items != null && listBox2.Items != null)
            {
                for (int i = 0; i < listBox1.SelectedItems.Count; i++)
                    simpleCrawler.ADD(listBox1.SelectedItems[i].ToString(), listBox2.SelectedItems[i].ToString());
            }
            simpleCrawler.Crawl();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != null)
                listBox2.Items.Add(textBox2.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null)
                listBox1.Items.Add(textBox1.Text);
        }
    }
}
