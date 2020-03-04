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
    public partial class ejercicio_4 : Form
    {
        public ejercicio_4()
        {
            InitializeComponent();
        }
        public static int numeroM(int n1, int n2, int n3)
        {
            int N = 0;
            if (n1 > n2 && n1 > 3)
            {
                N = n1;
            }
            if (n2 > n1 && n2 > n3)
            {
                N = n2;
            }
            if (n3 > n1 && n3 > n2)
            {
                N = n3;
            }
            return N;
        }

        private void btnMayor_Click(object sender, EventArgs e)
        {
            int n1, n2, n3;
            if (txtNum1.Text.Length < 1 && txtNum2.Text.Length < 1 || txtNum1.Text.Length < 1 && txtNum3.Text.Length < 1 || txtNum2.Text.Length < 1 && txtNum3.Text.Length < 1)
            {
                MessageBox.Show("Ingrese 2 o 3 numeros");
            }
            else
            {
                if (txtNum1.Text.Length < 1)
                {
                    n1 = 0;
                }
                else
                {
                    n1 = Convert.ToInt32(txtNum1.Text);
                }
                if (txtNum2.Text.Length < 1)
                {
                    n2 = 0;
                }
                else
                {
                    n2 = Convert.ToInt32(txtNum2.Text);
                }
                if (txtNum3.Text.Length < 1)
                {
                    n3 = 0;
                }
                else
                {
                    n3 = Convert.ToInt32(txtNum3.Text);
                }
                int mayor = numeroM(n1, n2, n3);
                lblMayor.Text = string.Format("El numero mayor es: {0}", mayor);
            }
        }
    }
}
