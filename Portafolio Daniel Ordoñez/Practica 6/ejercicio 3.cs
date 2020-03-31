using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_6
{
    public partial class ejercicio_3 : Form
    {
        public ejercicio_3()
        {
            InitializeComponent();
        }
        public struct Datos
        {
            public string Nit;
            public string Nombre;
            public double sueldo;

        }
        Dictionary<string, StructFormat> regisEmp = new Dictionary<string, StructFormat>();
        string patronNombre = @"^(([A-Z[ÄËÏÖÜ][a-zñ[áéíóú]{2,})(\s)?)*[^\s]$";
        string patronNombre2 = @"^(([A-Z[ÄËÏÖÜ][a-zñ[áéíóú]{2,})(\s)?)*[^\s]$";
        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtNombre.Text, patronNombre))
            {
                errorProvider1.SetError(txtNombre, "El nombre debe iniciar con letra mayúscula...");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtSueldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && !txtSueldo.Text.Contains("."))
            {
                e.Handled = false;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || !Regex.IsMatch(txtNombre.Text, patronNombre2))
            {
                MessageBox.Show("Ingrese el nombre..");
                txtNombre.Focus();
            }
            else if (maskedTextBox2.Text == "")
            {
                MessageBox.Show("Ingrese el NIT...");
                maskedTextBox2.Focus();
            }
            else if (txtSueldo.Text == "")
            {
                MessageBox.Show("Ingrese el sueldo...");
                txtNombre.Focus();
            }
            else if (regisEmp.ContainsKey(maskedTextBox2.Text))
            {
                MessageBox.Show("Este número de NIT ya existe en el registo, Ingrese un numero de NIT nuevo...");
            }
            else
            {

            }
        }
    }
}
