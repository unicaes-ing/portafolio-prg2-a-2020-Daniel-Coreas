namespace Practica_6
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmpleado = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoLimpiar = new System.Windows.Forms.RadioButton();
            this.rdoOrdenar = new System.Windows.Forms.RadioButton();
            this.rdoQuitar = new System.Windows.Forms.RadioButton();
            this.rdoInsert = new System.Windows.Forms.RadioButton();
            this.rdoBuscar = new System.Windows.Forms.RadioButton();
            this.rdoAgregar = new System.Windows.Forms.RadioButton();
            this.btnEjecutar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Empleado:";
            // 
            // txtEmpleado
            // 
            this.txtEmpleado.Location = new System.Drawing.Point(13, 30);
            this.txtEmpleado.Name = "txtEmpleado";
            this.txtEmpleado.Size = new System.Drawing.Size(120, 20);
            this.txtEmpleado.TabIndex = 1;
            this.txtEmpleado.TextChanged += new System.EventHandler(this.txtEmpleado_TextChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(13, 57);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 147);
            this.listBox1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoLimpiar);
            this.groupBox1.Controls.Add(this.rdoOrdenar);
            this.groupBox1.Controls.Add(this.rdoQuitar);
            this.groupBox1.Controls.Add(this.rdoInsert);
            this.groupBox1.Controls.Add(this.rdoBuscar);
            this.groupBox1.Controls.Add(this.rdoAgregar);
            this.groupBox1.Location = new System.Drawing.Point(139, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(93, 168);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Acción";
            // 
            // rdoLimpiar
            // 
            this.rdoLimpiar.AutoSize = true;
            this.rdoLimpiar.Location = new System.Drawing.Point(7, 138);
            this.rdoLimpiar.Name = "rdoLimpiar";
            this.rdoLimpiar.Size = new System.Drawing.Size(58, 17);
            this.rdoLimpiar.TabIndex = 5;
            this.rdoLimpiar.TabStop = true;
            this.rdoLimpiar.Text = "Limpiar";
            this.rdoLimpiar.UseVisualStyleBackColor = true;
            // 
            // rdoOrdenar
            // 
            this.rdoOrdenar.AutoSize = true;
            this.rdoOrdenar.Location = new System.Drawing.Point(8, 114);
            this.rdoOrdenar.Name = "rdoOrdenar";
            this.rdoOrdenar.Size = new System.Drawing.Size(63, 17);
            this.rdoOrdenar.TabIndex = 4;
            this.rdoOrdenar.TabStop = true;
            this.rdoOrdenar.Text = "Ordenar";
            this.rdoOrdenar.UseVisualStyleBackColor = true;
            // 
            // rdoQuitar
            // 
            this.rdoQuitar.AutoSize = true;
            this.rdoQuitar.Location = new System.Drawing.Point(8, 90);
            this.rdoQuitar.Name = "rdoQuitar";
            this.rdoQuitar.Size = new System.Drawing.Size(53, 17);
            this.rdoQuitar.TabIndex = 3;
            this.rdoQuitar.TabStop = true;
            this.rdoQuitar.Text = "Quitar";
            this.rdoQuitar.UseVisualStyleBackColor = true;
            // 
            // rdoInsert
            // 
            this.rdoInsert.AutoSize = true;
            this.rdoInsert.Location = new System.Drawing.Point(8, 67);
            this.rdoInsert.Name = "rdoInsert";
            this.rdoInsert.Size = new System.Drawing.Size(60, 17);
            this.rdoInsert.TabIndex = 2;
            this.rdoInsert.TabStop = true;
            this.rdoInsert.Text = "Insertar";
            this.rdoInsert.UseVisualStyleBackColor = true;
            // 
            // rdoBuscar
            // 
            this.rdoBuscar.AutoSize = true;
            this.rdoBuscar.Location = new System.Drawing.Point(7, 44);
            this.rdoBuscar.Name = "rdoBuscar";
            this.rdoBuscar.Size = new System.Drawing.Size(58, 17);
            this.rdoBuscar.TabIndex = 1;
            this.rdoBuscar.TabStop = true;
            this.rdoBuscar.Text = "Buscar";
            this.rdoBuscar.UseVisualStyleBackColor = true;
            // 
            // rdoAgregar
            // 
            this.rdoAgregar.AutoSize = true;
            this.rdoAgregar.Location = new System.Drawing.Point(7, 20);
            this.rdoAgregar.Name = "rdoAgregar";
            this.rdoAgregar.Size = new System.Drawing.Size(62, 17);
            this.rdoAgregar.TabIndex = 0;
            this.rdoAgregar.TabStop = true;
            this.rdoAgregar.Text = "Agregar";
            this.rdoAgregar.UseVisualStyleBackColor = true;
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.Location = new System.Drawing.Point(139, 181);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(75, 23);
            this.btnEjecutar.TabIndex = 4;
            this.btnEjecutar.Text = "Ejecutar";
            this.btnEjecutar.UseVisualStyleBackColor = true;
            this.btnEjecutar.Click += new System.EventHandler(this.btnEjecutar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(157, 220);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnEjecutar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 256);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEjecutar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtEmpleado);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmpleado;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoLimpiar;
        private System.Windows.Forms.RadioButton rdoOrdenar;
        private System.Windows.Forms.RadioButton rdoQuitar;
        private System.Windows.Forms.RadioButton rdoInsert;
        private System.Windows.Forms.RadioButton rdoBuscar;
        private System.Windows.Forms.RadioButton rdoAgregar;
        private System.Windows.Forms.Button btnEjecutar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

