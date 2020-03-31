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
    public partial class ejercicio_2 : Form
    {
        public ejercicio_2()
        {
            InitializeComponent();
        }
        string patronNombre = @"^(([A-Z[ÄËÏÖÜ][a-zñ[áéíóú]{2,})(\s)?)*[^\s]$";
        string patronTel = @"^([2|6|7][0-9]{3})-([0-9]{4})$";
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        Dictionary<string, string> registroClientes = new Dictionary<string, string>();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtTelefono.Text == "" || !Regex.IsMatch(txtTelefono.Text, patronTel))
            {

                MessageBox.Show("El teléfono es un campo obligatorio");
                txtTelefono.Focus();
            }
            else if (txtNombre.Text == "" || !Regex.IsMatch(txtNombre.Text, patronNombre))
            {
                MessageBox.Show("El nombre es un campo obligatorio");
                txtNombre.Focus();
            }
            else if (registroClientes.ContainsKey(txtTelefono.Text))
            {
                MessageBox.Show("Ingrese un nuevo numero de teléfono.");
            }
            else
            {
                registroClientes.Add(txtTelefono.Text, txtNombre.Text);
                ListViewItem lista = new ListViewItem(txtTelefono.Text);
                lista.SubItems.Add(txtNombre.Text);
                listView1.Items.Add(lista);
            }
        }
        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtTelefono.Text, patronTel))
            {
                errorProvider1.SetError(txtTelefono, "El número debe iniciar con 2, 6 o 7...\nFormato (0000-0000)");
            }
            else
            {
                errorProvider1.Clear();
            }
        }
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
        private void btnBuscar_Click(object sender, EventArgs e)
        {

            if (txtTelefono.TextLength > 0)
            {
                if (!registroClientes.ContainsKey(txtTelefono.Text))
                {
                    MessageBox.Show("Numero inexistente");
                    txtNombre.Clear();
                    txtTelefono.Focus();
                    txtTelefono.SelectAll();
                }
                else
                {
                    MessageBox.Show("Número perteneciente al contacto: " + registroClientes[txtTelefono.Text].ToString());
                }
            }
        }
        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (txtTelefono.Text.Equals("") ||  registroClientes.Count == 0)
            {
                MessageBox.Show("No existen datos para borrar");
            }
            else if (listView1.SelectedItems.Count==0)
            {
                MessageBox.Show("Seleccione un elemento para elimitar");
            }
            else
            {
                registroClientes.Remove(txtTelefono.Text);
                foreach (ListViewItem lista in listView1.SelectedItems)
                {
                    lista.Remove();
                }
            }
        }
    }
}
