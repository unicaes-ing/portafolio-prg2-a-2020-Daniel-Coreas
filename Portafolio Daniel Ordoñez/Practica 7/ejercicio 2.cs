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
using System.Runtime.Serialization.Formatters.Binary;

namespace Practica_7
{
    public partial class ejercicio_2 : Form
    {
        public ejercicio_2()
        {
            InitializeComponent();
        }
        string patronNombre = @"^(([A-Z[ÄËÏÖÜ][a-zñ[áéíóú]{1,})(\s)?)*[^\s]$";
        string patronCodigo = @"^[A-Z]{2}[0-9]{4}$";
        [Serializable]
        public struct Datos
        {
            public string Codigo;
            public string Nombre;
            public string Propietario;
            public string Especie;
            public string FechaNacimiento;
            public double Peso;
            public string Sexo;
        }
        Datos dato = new Datos();
        Dictionary<string, Datos> regisMasc = new Dictionary<string, Datos>();
        BinaryFormatter formatter = new BinaryFormatter();
        const string NOMBRE_ARCHIVO = "mascotas.dat";

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

        private void txtPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (mtxCodigo.Text == "" || !mtxCodigo.MaskFull || !Regex.IsMatch(mtxCodigo.Text, patronCodigo))
            {
                MessageBox.Show("Ingrese el codigo de la mascota...");
                mtxCodigo.Focus();
            }
            else if (txtNombre.Text == "" || !Regex.IsMatch(txtNombre.Text, patronNombre))
            {
                MessageBox.Show("Ingrese el nombre...");
                txtNombre.Focus();
            }
            else if (Convert.ToString(cboPropietario.SelectedItem) == "")
            {
                MessageBox.Show("Seleccione al propietario!");
            }
            else if (Convert.ToString(cboEspecie.SelectedItem) == "")
            {
                MessageBox.Show("Ingrese la especie de su mascota...");
            }
            else if (txtPeso.Text == "")
            {
                MessageBox.Show("Ingrese el peso...");
                txtNombre.Focus();
            }
            else
            {
                dato.Codigo = mtxCodigo.Text;
                dato.Nombre = txtNombre.Text;
                dato.Propietario = cboPropietario.Text;
                dato.Especie = cboEspecie.Text;
                dato.FechaNacimiento = dateTimePicker1.Text;
                dato.Peso = Convert.ToDouble(txtPeso.Text);
                if (rdoMacho.Checked)
                {
                    dato.Sexo = rdoMacho.Text;
                }
                else
                {
                    dato.Sexo = rdoHembra.Text;
                }
                if (regisMasc.ContainsKey(dato.Codigo))
                {
                    MessageBox.Show("El código ya existe...\nIngrese un código nuevo");
                    mtxCodigo.Focus();
                }
                else
                {
                    regisMasc.Add(dato.Codigo, dato);
                    try
                    {
                        FileStream writerFS = new FileStream(NOMBRE_ARCHIVO, FileMode.Create, FileAccess.Write);
                        formatter.Serialize(writerFS, regisMasc);
                        writerFS.Close();
                        MessageBox.Show("Los datos han sido guardados");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("No fue posible guardar los datos");
                        
                    }
                    dataGridView1.Rows.Add(dato.Codigo, dato.Nombre, dato.Propietario, dato.Especie, dato.FechaNacimiento, dato.Peso, dato.Sexo);
                }
            }
        }

        private void mtxCodigo_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (!Regex.IsMatch(mtxCodigo.Text, patronCodigo))
            {
                errorProvider1.SetError(mtxCodigo, "Ingrese un código valido...");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void ejercicio_2_Load(object sender, EventArgs e)
        {
            string Nombre, Correo, Telefono;
            FileStream fs = null;
            BinaryReader br = null;
            try
            {
                fs = new FileStream("propietarios.dat", FileMode.Open, FileAccess.Read);
                br = new BinaryReader(fs);
                cboPropietario.Items.Clear();
                while (true)
                {
                    Nombre = br.ReadString();
                    Correo = br.ReadString();
                    Telefono = br.ReadString();
                    cboPropietario.Items.Add(Nombre);
                }
            }
            catch (Exception)
            {
            }
            finally
            {
                if (br != null)
                {
                    br.Close();
                }
            }
            if (File.Exists(NOMBRE_ARCHIVO))
            {
                try
                {
                    FileStream ReaderFS = new FileStream(NOMBRE_ARCHIVO, FileMode.Open, FileAccess.Read);
                    regisMasc = (Dictionary<string, Datos>)formatter.Deserialize(ReaderFS);
                    ReaderFS.Close();

                }
                catch (Exception)
                {
                    MessageBox.Show("No fue posible leer el archivo...");
                }
                if (regisMasc.Count > 0)
                {
                    dataGridView1.Rows.Clear();

                    foreach (Datos dato in regisMasc.Values)
                    {
                        dataGridView1.Rows.Add(dato.Codigo, dato.Nombre, dato.Propietario, dato.Especie, dato.FechaNacimiento, dato.Peso, dato.Sexo);
                    }
                    dataGridView1.ClearSelection();
                }
                else
                {
                    MessageBox.Show("No Existen datos almacenados en el archivo...");
                }

            }
        }
    }
}
