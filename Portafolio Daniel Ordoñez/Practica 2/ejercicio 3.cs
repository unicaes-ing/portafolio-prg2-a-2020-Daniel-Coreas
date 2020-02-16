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
    public partial class ejercicio_3 : Form
    {
        public ejercicio_3()
        {
            InitializeComponent();
        }

        private void btnConver_Click(object sender, EventArgs e)
        {
            double longitud = Convert.ToDouble(txtLong.Text);
            double resultado = 0;
            if (lstDe.SelectedItem.Equals("Pulgadas"))
            {
                if (listBox2.SelectedItem.Equals("Pulgadas"))
                {
                    resultado = longitud;
                }
                else if (listBox2.SelectedItem.Equals("Pies"))
                {
                    resultado = longitud / 12;
                }
                else if (listBox2.SelectedItem.Equals("Yardas"))
                {
                    resultado = longitud / 36;
                }
                txtLongConvert.Text = Convert.ToString(resultado);
            }
            else if (lstDe.SelectedItem.Equals("Pies"))
            {
                if (listBox2.SelectedItem.Equals("Pulgadas"))
                {
                    resultado = longitud * 12;
                }
                else if (listBox2.SelectedItem.Equals("Pies"))
                {
                    resultado = longitud;
                }
                else if (listBox2.SelectedItem.Equals("Yardas"))
                {
                    resultado = longitud / 3;
                }
                txtLongConvert.Text= Convert.ToString(resultado);
            }
            else if (lstDe.SelectedItem.Equals("Yardas"))
            {
                if (listBox2.SelectedItem.Equals("Pulgadas"))
                {
                    resultado = longitud / 12;
                }
                else if (listBox2.SelectedItem.Equals("Pies"))
                {
                    resultado = longitud * 3;
                }
                else if (listBox2.SelectedItem.Equals("Yarda"))
                {
                    resultado = longitud;
                }
            }
            else
            {
                MessageBox.Show("Seleccione las longitudes a convertir");
            }
        }
    }
}
