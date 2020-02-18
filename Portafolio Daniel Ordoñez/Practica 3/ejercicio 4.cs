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
    public partial class ejercicio_4 : Form
    {
        public ejercicio_4()
        {
            InitializeComponent();
        }

        private void ejercicio_4_Load(object sender, EventArgs e)
        {
            dgvNumeros.Size = new Size(210, 220);
            dgvNumeros.AllowUserToAddRows = false;
            dgvNumeros.ScrollBars = ScrollBars.None;
            dgvNumeros.ColumnCount = 10;
            dgvNumeros.ColumnHeadersVisible = false;
            dgvNumeros.RowHeadersVisible = false;
            dgvNumeros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            Random r = new Random();
            for (int f = 0; f < 10; f++)
            {
                dgvNumeros.Rows.Add();
                for (int c = 0; c < 10; c++)
                {
                    dgvNumeros.Rows[f].Cells[c].Value = r.Next(10, 100);
                }
            }
            dgvNumeros.ClearSelection();
        }
    }
}
