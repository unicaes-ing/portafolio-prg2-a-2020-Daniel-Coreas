using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_3
{
    public partial class ejercicio_2 : Form
    {
        public ejercicio_2()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            lstLetras.Items.Clear();
            for (char letra = 'A'; letra <= 'Z'; letra++)
            {
                lstLetras.Items.Add(letra);
            }
            lstLetras.Items.Insert(14, 'Ñ');
        }
    }
}
