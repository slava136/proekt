using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vagon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int mesto = Convert.ToInt32(textBox1);
            int mestop = Convert.ToInt32(textBox2);
            int mestov = Convert.ToInt32(textBox3);
            int vag = Convert.ToInt32(textBox6);
            int vagv = Convert.ToInt32(textBox4);
            int vagp = Convert.ToInt32(textBox5);
        }
    }
}
