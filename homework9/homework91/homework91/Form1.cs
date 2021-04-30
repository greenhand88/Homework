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

        }
        private void button1_Click(object sender, EventArgs e)
        {
            //if (textBox1.Text != null) 
            //    simpleCrawler.ResetStartUrl(textBox1.Text);
            if (textBox2.Text != null)
                simpleCrawler.ADD(textBox2.Text);
            simpleCrawler.Crawl();
        }
    }
}
