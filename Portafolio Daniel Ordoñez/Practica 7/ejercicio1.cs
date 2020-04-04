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
using System.IO;

namespace Practica_7
{
    public partial class ejercicio1 : Form
    {
        public ejercicio1()
        {
            InitializeComponent();
        }
        string patronNombre = @"^(([A-Z[ÄËÏÖÜ][a-zñ[áéíóú]{1,})(\s)?)*$";
        string patronCorreo = @"^\S[_a-zA-Z0-9-]+(.[_a-zA-Z0-9-]+)*@\S[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{1,4})$";
        string patronTel = @"^([2|6|7][0-9]{3})-([0-9]{4})$";
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

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtCorreo.Text, patronCorreo) || txtCorreo.Text.Contains(";") || txtCorreo.Text.Contains(":"))
            {
                errorProvider1.SetError(txtCorreo, "Ingrese un correo valido...");
            }
            else
            {
                errorProvider1.Clear();
            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mskTelefono_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (!Regex.IsMatch(mtxTelefono.Text, patronTel))
            {
                errorProvider1.SetError(mtxTelefono, "El número debe iniciar con 2, 6 o 7...");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || !Regex.IsMatch(txtNombre.Text, patronNombre))
            {
                MessageBox.Show("Ingrese el nombre...");
                txtNombre.Focus();
            }
            else if (txtCorreo.Text == "" || !Regex.IsMatch(txtCorreo.Text, patronCorreo) || txtCorreo.Text.Contains(";") || txtCorreo.Text.Contains(":"))
            {
                MessageBox.Show("El correo es un campo obligatorio...");
                txtNombre.Focus();
            }
            if (mtxTelefono.Text == "" || !Regex.IsMatch(mtxTelefono.Text, patronTel))
            {
                MessageBox.Show("El teléfono es un campo obligatorio...");
                mtxTelefono.Focus();
            }
            else
            {
                dataGridView1.Rows.Add(txtNombre.Text, txtCorreo.Text, mtxTelefono.Text);
                dataGridView1.ClearSelection();

                FileStream fs = null;
                BinaryWriter bw = null;
                try
                {
                    fs = new FileStream("propietarios.dat", FileMode.Append, FileAccess.Write);
                    bw = new BinaryWriter(fs);
                    bw.Write(txtNombre.Text);
                    bw.Write(txtCorreo.Text);
                    bw.Write(mtxTelefono.Text);
                    MessageBox.Show("Los datos fueron almacenados");
                    txtCorreo.Clear();
                    txtNombre.Clear();
                    mtxTelefono.Clear();
                    txtNombre.Focus();
                }
                catch (Exception)
                {
                    MessageBox.Show("Ingrese los datos correctamente");
                }
                finally
                {
                    if (bw != null) bw.Close();
                }
            }
        }

        private void ejercicio1_Load(object sender, EventArgs e)
        {
            string nombre, correo, telefono;
            FileStream fs = null;
            BinaryReader br = null;
            try
            {
                fs = new FileStream("propietarios.dat", FileMode.Open, FileAccess.Read);
                br = new BinaryReader(fs);
                dataGridView1.Rows.Clear();
                while (true)
                {
                    nombre = br.ReadString();
                    correo = br.ReadString();
                    telefono = br.ReadString();
                    dataGridView1.Rows.Add(nombre, correo, telefono);
                }
            }
            catch (Exception)
            {

               
            }
            finally
            {
                if (br!=null)
                {
                    br.Close();
                    dataGridView1.ClearSelection();
                }
            }
        }

        private void btnMascotas_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count>0)
            {
                ejercicio_2 ejer2 = new ejercicio_2();
                ejer2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Ingrese propietarios para poder \npasar al siguiente formulario...");
                txtNombre.Focus();
            }
            
        }
    }
}
