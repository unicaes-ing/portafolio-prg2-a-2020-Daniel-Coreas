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

    public partial class ejercicio_2 : Form
    {

        public ejercicio_2()
        {
            InitializeComponent();
        }
        public static int[,] Op1(int[,] A, int[,] B, RadioButton op)
        {
            int[,] total = new int[5, 5];
            if (op.Checked)
            {
                for (int f = 0; f < total.GetLength(0); f++)
                {
                    for (int c = 0; c < total.GetLength(1); c++)
                    {
                        total[f, c] = A[f, c] + B[f, c];
                    }
                }
            }
            return total;
        }
        public static int[,] Op2(int[,] A, int[,] B, RadioButton op)
        {
            int[,] total = new int[5, 5];
            if (op.Checked)
            {
                for (int f = 0; f < total.GetLength(0); f++)
                {
                    for (int c = 0; c < total.GetLength(1); c++)
                    {
                        total[f, c] = A[f, c] * B[f, c];
                    }
                }
            }
            return total;
        }
        int[,] A = new int[5, 5];
        int[,] B = new int[5, 5];
        private void ejercicio_2_Load(object sender, EventArgs e)
        {

            dataGridView1.ColumnCount = 5;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersVisible = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Random n = new Random();
            for (int f = 0; f < A.GetLength(0); f++)
            {
                dataGridView1.Rows.Add();
                for (int c = 0; c < A.GetLength(1); c++)
                {
                    A[f, c] = n.Next(10, 91);
                    dataGridView1.Rows[f].Cells[c].Value = A[f, c];
                }
            }

            dataGridView2.ColumnCount = 5;
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.ColumnHeadersVisible = false;
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            for (int f = 0; f < B.GetLength(0); f++)
            {
                dataGridView2.Rows.Add();
                for (int c = 0; c < B.GetLength(1); c++)
                {
                    B[f, c] = n.Next(10, 91);
                    dataGridView2.Rows[f].Cells[c].Value = B[f, c];
                }
            }
            dataGridView1.ClearSelection();
            dataGridView2.ClearSelection();
            rdoSumar.Checked = true;
        }

        private void rdoSumar_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            dataGridView3.Rows.Clear();
            dataGridView3.Columns.Clear();
            dataGridView3.AllowUserToAddRows = false;
            dataGridView3.ScrollBars = ScrollBars.Both;
            dataGridView3.ColumnCount = 5;
            dataGridView3.ColumnHeadersVisible = false;
            dataGridView3.RowHeadersVisible = false;
            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            int[,] total = new int[5, 5];
            if (rdoSumar.Checked)
            {
                total = Op1(A, B, rdoSumar);
                for (int f = 0; f < A.GetLength(0); f++)
                {
                    dataGridView3.Rows.Add();
                    for (int c = 0; c < B.GetLength(1); c++)
                    {
                        dataGridView3.Rows[f].Cells[c].Value = total[f, c];
                    }
                }
            }
            else
            {
                total = Op2(A, B, rdoMulti);
                for (int f = 0; f < A.GetLength(0); f++)
                {
                    dataGridView3.Rows.Add();
                    for (int c = 0; c < B.GetLength(1); c++)
                    {
                        dataGridView3.Rows[f].Cells[c].Value = total[f, c];
                    }
                }
            }
        }
    }
}
