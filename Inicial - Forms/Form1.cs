using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inicial___Forms
{
    public partial class Form1 : Form
    {
        public string frase = "    Deus é maior";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            label1.Text = frase.Trim();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = frase.Trim().ToUpper();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           if (!frase.EndsWith("."))
            {
                label1.Text = frase.Trim() + ".";
            }
        }
    }
}
