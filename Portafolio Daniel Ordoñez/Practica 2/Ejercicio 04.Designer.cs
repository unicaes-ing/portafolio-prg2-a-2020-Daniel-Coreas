namespace Practica_2
{
    partial class Ejercicio_04
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.txtValidContra = new System.Windows.Forms.TextBox();
            this.btnAcept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-1, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Correo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-1, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-1, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Confirmación\r\nde contraseña";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(77, 13);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(190, 20);
            this.txtCorreo.TabIndex = 3;
            this.txtCorreo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtCorreo.Validating += new System.ComponentModel.CancelEventHandler(this.txtCorreo_Validating);
            this.txtCorreo.Validated += new System.EventHandler(this.txtCorreo_Validated);
            // 
            // txtContra
            // 
            this.txtContra.Location = new System.Drawing.Point(77, 54);
            this.txtContra.Name = "txtContra";
            this.txtContra.Size = new System.Drawing.Size(135, 20);
            this.txtContra.TabIndex = 4;
            this.txtContra.Validating += new System.ComponentModel.CancelEventHandler(this.txtContra_Validating);
            this.txtContra.Validated += new System.EventHandler(this.txtContra_Validated);
            // 
            // txtValidContra
            // 
            this.txtValidContra.Location = new System.Drawing.Point(77, 91);
            this.txtValidContra.Name = "txtValidContra";
            this.txtValidContra.Size = new System.Drawing.Size(135, 20);
            this.txtValidContra.TabIndex = 5;
            this.txtValidContra.Validating += new System.ComponentModel.CancelEventHandler(this.txtValidContra_Validating);
            this.txtValidContra.Validated += new System.EventHandler(this.txtValidContra_Validated);
            // 
            // btnAcept
            // 
            this.btnAcept.Location = new System.Drawing.Point(77, 130);
            this.btnAcept.Name = "btnAcept";
            this.btnAcept.Size = new System.Drawing.Size(75, 23);
            this.btnAcept.TabIndex = 6;
            this.btnAcept.Text = "Aceptar";
            this.btnAcept.UseVisualStyleBackColor = true;
            this.btnAcept.Click += new System.EventHandler(this.btnAcept_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(170, 129);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Ejercicio_04
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 169);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAcept);
            this.Controls.Add(this.txtValidContra);
            this.Controls.Add(this.txtContra);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Ejercicio_04";
            this.Text = "Ejercicio_04";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtContra;
        private System.Windows.Forms.TextBox txtValidContra;
        private System.Windows.Forms.Button btnAcept;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}