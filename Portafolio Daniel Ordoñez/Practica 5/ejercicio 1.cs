using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] vendedores = new string[10];
        private void Form1_Load(object sender, EventArgs e)
        {
            vendedores[0] = "Carlos";
            vendedores[1] = "Martin";
            vendedores[2] = "Amelia";
            vendedores[3] = "Brandon";
            vendedores[4] = "Maria";
            vendedores[5] = "Sara";
            vendedores[6] = "Diego";
            vendedores[7] = "Zacarias";
            vendedores[8] = "José";
            vendedores[9] = "Fabiola";
            listBox1.DataSource = vendedores;
        }
        private void OrdenAZ_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            Array.Sort(vendedores);
            listBox1.DataSource = vendedores;
        }

        private void btnZA_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            Array.Sort(vendedores);
            Array.Reverse(vendedores);
            listBox1.DataSource = vendedores;
        }

        private void btnquitar_Click(object sender, EventArgs e)
        {
            //Forma (1)
            //string[] temp = new string[vendedores.Length];
            //int n = 0;
            //for (int i = 0; i < vendedores.Length; i++)
            //{
            //    if (i!=listBox1.SelectedIndex)
            //    {
            //        temp[n] = vendedores[i];
            //            n++;
            //    }
            //}
            //vendedores = temp;
            //listBox1.DataSource = vendedores;

            //Forma(2)
            //if (listBox1.SelectedIndex>=0)
            //{
            //    List<string> lista = new List<string>(vendedores);
            //    lista.RemoveAt(listBox1.SelectedIndex);
            //    vendedores = lista.ToArray();
            //    listBox1.DataSource = vendedores;
            //    listBox1.SelectedIndex = -1;
            //}
            if (listBox1.SelectedIndex>=0)
            {
                vendedores = vendedores.Where((item, index) => index != listBox1.SelectedIndex).ToArray();
                listBox1.DataSource = vendedores;
                listBox1.SelectedIndex = -1;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtbuscar.TextLength>0)
            {
                int nombre = Array.IndexOf(vendedores, txtbuscar.Text);
                if (nombre >= 0)
                {
                    listBox1.SelectedIndex = nombre;
                }
                else
                {
                    MessageBox.Show("Nombre no encontrado...");
                }
            }
            else
            {
                MessageBox.Show("Ingrese el nombre a buscar");
            }
        }
    }
}
