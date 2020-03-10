namespace Practica_5
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.OrdenAZ = new System.Windows.Forms.Button();
            this.btnZA = new System.Windows.Forms.Button();
            this.btnquitar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // OrdenAZ
            // 
            this.OrdenAZ.Location = new System.Drawing.Point(141, 22);
            this.OrdenAZ.Name = "OrdenAZ";
            this.OrdenAZ.Size = new System.Drawing.Size(75, 23);
            this.OrdenAZ.TabIndex = 0;
            this.OrdenAZ.Text = "Ordenar A-Z";
            this.OrdenAZ.UseVisualStyleBackColor = true;
            this.OrdenAZ.Click += new System.EventHandler(this.OrdenAZ_Click);
            // 
            // btnZA
            // 
            this.btnZA.Location = new System.Drawing.Point(141, 51);
            this.btnZA.Name = "btnZA";
            this.btnZA.Size = new System.Drawing.Size(75, 23);
            this.btnZA.TabIndex = 1;
            this.btnZA.Text = "Ordenar Z-A";
            this.btnZA.UseVisualStyleBackColor = true;
            this.btnZA.Click += new System.EventHandler(this.btnZA_Click);
            // 
            // btnquitar
            // 
            this.btnquitar.Location = new System.Drawing.Point(141, 80);
            this.btnquitar.Name = "btnquitar";
            this.btnquitar.Size = new System.Drawing.Size(75, 23);
            this.btnquitar.TabIndex = 2;
            this.btnquitar.Text = "Quitar";
            this.btnquitar.UseVisualStyleBackColor = true;
            this.btnquitar.Click += new System.EventHandler(this.btnquitar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(141, 174);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Vendedores";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 24);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 173);
            this.listBox1.TabIndex = 6;
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(141, 150);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(75, 20);
            this.txtbuscar.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 227);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnquitar);
            this.Controls.Add(this.btnZA);
            this.Controls.Add(this.OrdenAZ);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OrdenAZ;
        private System.Windows.Forms.Button btnZA;
        private System.Windows.Forms.Button btnquitar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtbuscar;
    }
}

