using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            try
            {
                int numero = Convert.ToInt32(txtNum.Text);
                string romano = "";
                if (numero >= 1 && numero <= 10)
                {
                    if (numero == 1)
                    {
                        romano = "I";
                    }
                    else if (numero == 2)
                    {
                        romano = "II";
                    }
                    else if (numero == 3)
                    {
                        romano = "III";
                    }
                    else if (numero == 4)
                    {
                        romano = "IV";
                    }
                    else if (numero == 5)
                    {
                        romano = "V";
                    }
                    else if (numero == 6)
                    {
                        romano = "VI";
                    }
                    else if (numero == 7)
                    {
                        romano = "VII";
                    }
                    else if (numero == 8)
                    {
                        romano = "VIII";
                    }
                    else if (numero == 9)
                    {
                        romano = "IX";
                    }
                    else if (numero == 10)
                    {
                        romano = "X";
                    }
                    lblEquivale.Text = "Equivale a " + romano + " En romano";
                }
                else
                {
                    txtNum.Focus();
                    txtNum.SelectAll();
                    lblEquivale.Text = "Ingrese un numero entre 1 y 10";
                }
            }
            catch (Exception)
            {
                txtNum.Focus();
                txtNum.SelectAll();
                lblEquivale.Text = "Error, sólo números...";
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
