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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double exa1, exa2, exa3, promedio;
            exa1 = Convert.ToDouble(textBox1.Text);
            exa2 = Convert.ToDouble(textBox2.Text);
            exa3 = Convert.ToDouble(textBox3.Text);
            promedio = (exa1 + exa2 + exa3) / 3;
            textBox4.Text = String.Format("{0:N1}", promedio);
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
