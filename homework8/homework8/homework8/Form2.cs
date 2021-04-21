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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public string Get_ID()
        {
            return order_id.Text;
        }
        private void create_done_button_Click(object sender, EventArgs e)
        {

            new Success().ShowDialog();
            this.Close();
        }
    }
}
