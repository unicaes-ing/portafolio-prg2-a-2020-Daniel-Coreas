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
    public partial class ejercicio_4 : Form
    {
        public ejercicio_4()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double totalPago, subtotal, iva;
            subtotal = Convert.ToDouble(txtPrecio.Text) * Convert.ToDouble(txtCant.Text);
            iva = subtotal * 0.13;
            totalPago = subtotal + iva;
            txtSubtotal.Text = "$ " + Convert.ToString(Convert.ToDouble(txtPrecio.Text) * Convert.ToDouble(txtCant.Text));
            txtIva.Text = "$ " + Convert.ToString(iva);
            txtTotal.Text = "$ " + Convert.ToString(subtotal + iva);
        }

        private void btnNueva_Click(object sender, EventArgs e)
        {
            txtCant.Clear();
            txtIva.Clear();
            txtPrecio.Clear();
            txtSubtotal.Clear();
            txtTotal.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
