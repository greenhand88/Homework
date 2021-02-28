using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 简易计算器
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            string temp1,temp2;
            double number1, number2, number3;
            temp1 = textBox1.Text; temp2 = textBox2.Text;
            try 
            {   number1 = double.Parse(temp1);
                number2 = double.Parse(temp2);
                switch (comboBox1.Text) 
                {
                    case "+": textBox3.Text = Convert.ToString(number1 + number2);break;
                    case "-": textBox3.Text = Convert.ToString(number1 - number2); break;
                    case "*": textBox3.Text = Convert.ToString(number1 * number2); break;
                    case "/": textBox3.Text = Convert.ToString(number1 / number2); break;
                }
                
            }
            catch(ArgumentNullException)
            { Console.WriteLine("文本框为空"); }
            catch (FormatException)
            { Console.WriteLine("输入错误"); }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("+");
            comboBox1.Items.Add("-");
            comboBox1.Items.Add("*");
            comboBox1.Items.Add("/");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
