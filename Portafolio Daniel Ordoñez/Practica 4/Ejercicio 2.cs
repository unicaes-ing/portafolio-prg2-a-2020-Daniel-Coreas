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
    public partial class Ejercicio_2 : Form
    {
        public Ejercicio_2()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                int numero = Convert.ToInt32(txtNumAgre.Text);
                listBox1.Items.Add(numero);
                txtNumAgre.Clear();
                txtNumAgre.Focus();
            }
            catch (Exception)
            {
                MessageBox.Show("Ingrese un número");
                txtNumAgre.SelectAll();
                txtNumAgre.Focus();
            }
        }
        public static int Buscar(int numBuscar, ListBox lista)
        {
            int cont = 0;
            foreach (int n in lista.Items)
            {
                if (n == numBuscar) cont++;
            }
            return cont;
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                int num = Convert.ToInt32(txtNumBuscar.Text);
                int cant = Buscar(num, listBox1);
                MessageBox.Show("Se encuentra " + cant + " veces");
            }
            catch (Exception)
            {

                MessageBox.Show("Ingrese un número");
                txtNumAgre.SelectAll();
                txtNumAgre.Focus();
            }
        }
    }
}
