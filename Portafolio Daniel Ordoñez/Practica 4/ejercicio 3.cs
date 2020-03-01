using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_4
{
    public partial class ejercicio_3 : Form
    {
        public ejercicio_3()
        {
            InitializeComponent();
        }
        private static int Fibonacci(int n)
        {
            if (n < 2)
                return n;
            else
                return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            try
            {
                int num = Convert.ToInt32(txtNum.Text);
                int fibo = Fibonacci(num);
                txtFibo.Text = string.Format("{0}", fibo);
                txtNum.Focus();
            }
            catch (Exception)
            {
                MessageBox.Show("Ingrese el número para calcular Fibonacci");
            }
        }
    }
}
