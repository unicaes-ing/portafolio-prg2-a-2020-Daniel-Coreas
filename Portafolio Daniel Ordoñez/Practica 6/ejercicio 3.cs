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
            public double Sueldo;
        }
        Dictionary<string, Datos> regisEmp = new Dictionary<string, Datos>();
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
            else if (maskedTextBox1.Text == "" || !maskedTextBox1.MaskFull)
            {
                MessageBox.Show("Ingrese el NIT...");
                maskedTextBox1.Focus();
            }
            else if (txtSueldo.Text == "")
            {
                MessageBox.Show("Ingrese el sueldo...");
                txtNombre.Focus();
            }
            else if (regisEmp.ContainsKey(maskedTextBox1.Text))
            {
                MessageBox.Show("Este número de NIT ya existe en el registo, Ingrese un numero de NIT nuevo...");
            }
            else
            {
                Datos Dato = new Datos();
                Dato.Nit = maskedTextBox1.Text;
                Dato.Nombre = txtNombre.Text;
                Dato.Sueldo = Convert.ToDouble(txtSueldo.Text);
                regisEmp.Add(Dato.Nit, Dato);

                dataGridView1.Rows.Add(Dato.Nit, Dato.Nombre, Dato.Sueldo);
                dataGridView1.ClearSelection();
                double total=0.0;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    total = total + Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value);
                }
                lblTotal.Text = "Total Planilla: $"+ total.ToString();
            }
            MessageBox.Show("Datos almacenados...");
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (maskedTextBox2.Text == "" || !maskedTextBox2.MaskFull)
            {
                MessageBox.Show("Ingrese un codigo para buscar...");
                maskedTextBox2.Focus();
            }
            else if (regisEmp.ContainsKey(maskedTextBox2.Text))
            {
                for (int M = 0; M < dataGridView1.Rows.Count; M++)
                {
                    dataGridView1.Rows[M].DefaultCellStyle.BackColor = Color.White;
                    if (dataGridView1.Rows[M].Cells[0].Value.Equals(maskedTextBox2.Text))
                    {
                        dataGridView1.Rows[M].DefaultCellStyle.BackColor = Color.Yellow;
                    }
                }
                MessageBox.Show("El número NIT  si existe...");
            }
            else
            {
                MessageBox.Show("El número de NIT no existe...");
            }

        }
        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (maskedTextBox2.Text == "" || !maskedTextBox2.MaskFull)
            {
                MessageBox.Show("Ingrese un codigo para eliminar...");
                maskedTextBox2.Focus();
            }
            else if (regisEmp.ContainsKey(maskedTextBox2.Text))
            {
                for (int M = 0; M < dataGridView1.Rows.Count; M++)
                {

                    if (dataGridView1.Rows[M].Cells[0].Value.Equals(maskedTextBox2.Text))
                    {
                        dataGridView1.Rows.RemoveAt(M);
                        regisEmp.Remove(maskedTextBox2.Text);
                    }
                }
            }
            else
            {
                MessageBox.Show("Codigo de paciente no existente...");
            }
        }
    }
}
