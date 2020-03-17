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
    public partial class ejercicio_3 : Form
    {
        public ejercicio_3()
        {
            InitializeComponent();
        }
        string[][] ven = new string[7][];
        private void ejercicio_3_Load(object sender, EventArgs e)
        {
            ven[0] = new string[6] { "40", "50", "70", "79", "28", "{52}" };
            ven[1] = new string[3] { "70", "0","90"};
            ven[2] = new string[2] { "120", "100" };
            ven[3] = new string[1] { "90" };
            ven[4] = new string[4] { "75", "79", "50", "0" };
            ven[5] = new string[3] { "80", "89", "38" };
            ven[6] = new string[2] { "39", "110" };
            lstSucursal.Items.Clear();
            for (int i = 0; i < ven.GetLength(0); i++)
            {
                lstSucursal.Items.Add("Sucursal N°" + (i + 1));
            }
        }

        private void lstSucursal_SelectedIndexChanged(object sender, EventArgs e)
        {
            int total = 0;
            if (lstSucursal.SelectedIndex>=0)
            {
                lstVentas.Items.Clear();
                foreach (string ventas in ven[lstSucursal.SelectedIndex])
                {
                    lstVentas.Items.Add(ventas);
                    total += Convert.ToInt32(ventas);
                }
            }
            lblVentas.Text = string.Format("Total ventas: "+"{0}{1}", "$", total);
        }
    }
}
