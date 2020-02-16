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
    public partial class Ejercicio_3 : Form
    {
        public Ejercicio_3()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double num1, num2, num3, total;
            num1 = Convert.ToDouble(textBox1.Text);
            num2 = Convert.ToDouble(textBox2.Text);
            num3 = Convert.ToDouble(textBox3.Text);
            total = num1 + num2 + num3;
            txtPorcentaje1.Text = String.Format("{0:N1}", (num1 / total) * 100) + "%";
            txtPorcentaje2.Text = String.Format("{0:N1}", (num2 / total) * 100) + "%";
            txtPorcentaje3.Text = String.Format("{0:N1}", (num3 / total) * 100) + "%";
            txtTotalInv.Text = String.Format("$" + "{0:N}", total);
        }

        private void btnLimp_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            txtPorcentaje1.Clear();
            txtPorcentaje2.Clear();
            txtPorcentaje3.Clear();
            txtTotalInv.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
