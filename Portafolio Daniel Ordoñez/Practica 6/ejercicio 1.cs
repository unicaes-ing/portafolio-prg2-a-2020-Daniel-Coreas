using System;
using System.Collections;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> ListaEmpleados = new List<string>();
        string patronNombre = @"^(([A-Z[ÄËÏÖÜ][a-zñ[áéíóú]{2,})(\s)?)*[^\s]$";
        private void Form1_Load(object sender, EventArgs e)
        {
            rdoAgregar.Checked = true;
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            if (rdoAgregar.Checked)
            {
                listBox1.Items.Clear();
                txtEmpleado.SelectAll();
                txtEmpleado.Focus();
                if (txtEmpleado.Text != "" && Regex.IsMatch(txtEmpleado.Text, patronNombre))
                {
                    ListaEmpleados.Add(txtEmpleado.Text);
                    foreach (string empleado in ListaEmpleados)
                    {
                        listBox1.Items.Add(empleado);
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese un nombre.");
                }
            }

            else if (rdoBuscar.Checked)
            {
                if (txtEmpleado.Text != "" && Regex.IsMatch(txtEmpleado.Text, patronNombre) && listBox1.Items.Count >= 0)
                {
                    foreach (string empleado in ListaEmpleados)
                    {
                        if (txtEmpleado.Text == empleado)
                        {
                            listBox1.SelectedItem = empleado;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("El nombre no existe en la lista.");
                }
            }
            else if (rdoInsert.Checked)
            {
                if (txtEmpleado.Text != "" && Regex.IsMatch(txtEmpleado.Text, patronNombre) && listBox1.Items.Count >= 0)
                {
                    listBox1.Items.Insert(listBox1.SelectedIndex, txtEmpleado.Text);
                    ListaEmpleados.Insert(listBox1.SelectedIndex, txtEmpleado.Text);

                }
                else
                {
                    MessageBox.Show("Error al insertar el nombre.");
                }
            }
            else if (rdoQuitar.Checked)
            {
                if (txtEmpleado.Text != "" && Regex.IsMatch(txtEmpleado.Text, patronNombre) && listBox1.Items.Count > 0)
                {
                    ListaEmpleados.RemoveAt(listBox1.SelectedIndex);
                    listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                }
                else
                {
                    MessageBox.Show("Error al quitar el nombre.");
                }
            }
            
            else if (rdoOrdenar.Checked)
            {
                ListaEmpleados.Sort();
                if (listBox1.Items.Count >= 1)
                {
                    listBox1.DataSource = ListaEmpleados;
                }
                else
                {
                    MessageBox.Show("No se puede ordenar la lista.");
                }
            }
            else
            {
                if (listBox1.Items.Count >= 1)
                {
                    listBox1.Items.Clear();
                    ListaEmpleados.Clear();
                }
                else
                {
                    MessageBox.Show("No hay elementos para borrar.");
                }
            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtEmpleado_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtEmpleado.Text, patronNombre))
            {
                errorProvider1.SetError(txtEmpleado, "El nombre debe iniciar con letra mayúscula...");
            }
            else
            {
                errorProvider1.Clear();
            }
        }
    }
}
