namespace Practica_3
{
    partial class ejercicio_4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvNumeros = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNumeros)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNumeros
            // 
            this.dgvNumeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNumeros.Location = new System.Drawing.Point(13, 13);
            this.dgvNumeros.Name = "dgvNumeros";
            this.dgvNumeros.Size = new System.Drawing.Size(240, 150);
            this.dgvNumeros.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numero a buscar";
            // 
            // txtNumBuscar
            // 
            this.txtNumBuscar.Location = new System.Drawing.Point(104, 244);
            this.txtNumBuscar.Name = "txtNumBuscar";
            this.txtNumBuscar.Size = new System.Drawing.Size(45, 20);
            this.txtNumBuscar.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(165, 241);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // ejercicio_4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 341);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtNumBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvNumeros);
            this.Name = "ejercicio_4";
            this.Text = "ejercicio_4";
            this.Load += new System.EventHandler(this.ejercicio_4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNumeros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNumeros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumBuscar;
        private System.Windows.Forms.Button btnBuscar;
    }
}