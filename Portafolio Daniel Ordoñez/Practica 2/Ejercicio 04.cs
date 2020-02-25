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

namespace Practica_2
{
    public partial class Ejercicio_04 : Form
    {
        public Ejercicio_04()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCorreo_Validating(object sender, CancelEventArgs e)
        {
            string patron = @"^[_a-z0-9-]+(.[_a-z0-9-]+)*@[_a-z0-9-]+(.[_a-z0-9-]+)*(.[a-z]{2,4})\S$";
            if (!Regex.IsMatch(txtCorreo.Text, patron))
            {
                e.Cancel = true;
                txtCorreo.SelectAll();
                errorProvider1.SetError(txtCorreo, "Ingrese un correo válido");
            }
            else
            {
                e.Cancel = false;
            }
        }

        private void txtCorreo_Validated(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void txtContra_Validating(object sender, CancelEventArgs e)
        {
            string patron2 = @"(?=\w*\d)(?=\w[A-Z])(?=\w*[a-z])\S{8,16}$";
            if (txtContra.TextLength<8)
            {
                e.Cancel = true;
                txtContra.SelectAll();
                errorProvider1.SetError(txtContra, "La contraseña no puede tener menos de 8 caracteres");
            }
            else if (!Regex.IsMatch(txtContra.Text, patron2))
            {
                e.Cancel = true;
                txtContra.SelectAll();
                errorProvider1.SetError(txtContra, "La contraseña debe iniciar con minúscula, luego mayúscula o caracter");
            }
        }

        private void txtContra_Validated(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void txtValidContra_Validating(object sender, CancelEventArgs e)
        {
            string patron3 = @"(?=\w*\d)(?=\w[A-Z])(?=\w*[a-z])\S{8,16}$";
            if (txtContra.TextLength < 8)
            {
                e.Cancel = true;
                txtContra.SelectAll();
                errorProvider1.SetError(txtContra, "La contraseña no puede tener menos de 8 caracteres");
            }
            else if (!Regex.IsMatch(txtContra.Text, patron3))
            {
                e.Cancel = true;
                txtContra.SelectAll();
                errorProvider1.SetError(txtContra, "La contraseña debe iniciar con minúscula, luego mayúscula o caracter");
            }
        }

        private void txtValidContra_Validated(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void btnAcept_Click(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "")
            {
                txtCorreo.Focus();
                MessageBox.Show("El correo es un campo obligatorio", "Aviso", MessageBoxButtons.OK);
            }
            else if (txtContra.Text == "")
            {
                txtContra.Focus();
                MessageBox.Show("La contraseña es un campo obligatorio", "Aviso", MessageBoxButtons.OK);
            }
            else if (txtValidContra.Text == "")
            {
                txtValidContra.Focus();
                MessageBox.Show("La contraseña de confirmación es un campo obligatorio", "Aviso", MessageBoxButtons.OK);
            }
            else if (txtValidContra.Text != txtValidContra.Text)
            {
                txtValidContra.Focus();
                txtValidContra.SelectAll();
                MessageBox.Show("Las contraseñas son distintas", "Aviso", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Los datos son correctos!!", "Mensaje", MessageBoxButtons.OK);
                Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
