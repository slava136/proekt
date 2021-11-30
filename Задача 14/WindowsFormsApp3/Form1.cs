using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int z1 = 0;
            if (radioButton1.Checked == true)
            { z1 = 750; }

            string hub = textBox1.Text;
            int hub1 = Convert.ToInt32(hub);
            int vivod = hub1 * 50 + z1;

            label3.Text = Convert.ToString(vivod);
        }
    }
}
