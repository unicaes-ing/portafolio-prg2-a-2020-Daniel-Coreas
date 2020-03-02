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
        public static int numero(int n1, int n2, int n3)
        {
            int num1 = n1;
            int num2 = n2;
            int num3 = n3;
            if (num1 > num2 && num1 > num3)
            {
                return num1;
            }
            else if (num2 > num1 && num2 > num3)
            {
                return num2;
            }
            else
            {
                return num3;
            }
        }
        private void btnMayor_Click(object sender, EventArgs e)
        {
            try
            {
                int n1, n2, n3, nMayor;
                n1 = Convert.ToInt32(txtNum1.Text);
                n2 = Convert.ToInt32(txtNum2.Text);
                n3 = Convert.ToInt32(txtNum3.Text);
                nMayor = numero(n1, n2, n3);
                lblMayor.Text = string.Format("El mayor es:{0}", nMayor);
            }
            catch (Exception)
            {

                MessageBox.Show("Ingrese los 3 numeros");
            }
        }
    }
}
