using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            textBox2.Text = Convert.ToString(Convert.ToInt32(textBox1.Text), 2);
            textBox3.Text = Convert.ToString(Convert.ToInt32(textBox1.Text), 8);
            textBox4.Text = Convert.ToString(Convert.ToInt32(textBox1.Text), 16);
        }

        private void btnLimp_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close()
;        }
    }
}
