namespace Practica_2
{
    partial class ejercicio_3
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnConver = new System.Windows.Forms.Button();
            this.txtLongConvert = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lstA = new System.Windows.Forms.GroupBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstDe = new System.Windows.Forms.ListBox();
            this.txtLong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstA.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(161, 216);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 15;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnConver
            // 
            this.btnConver.Location = new System.Drawing.Point(43, 216);
            this.btnConver.Name = "btnConver";
            this.btnConver.Size = new System.Drawing.Size(75, 23);
            this.btnConver.TabIndex = 14;
            this.btnConver.Text = "Convertir";
            this.btnConver.UseVisualStyleBackColor = true;
            this.btnConver.Click += new System.EventHandler(this.btnConver_Click);
            // 
            // txtLongConvert
            // 
            this.txtLongConvert.Location = new System.Drawing.Point(136, 182);
            this.txtLongConvert.Name = "txtLongConvert";
            this.txtLongConvert.ReadOnly = true;
            this.txtLongConvert.Size = new System.Drawing.Size(100, 20);
            this.txtLongConvert.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Longitud convertida";
            // 
            // lstA
            // 
            this.lstA.Controls.Add(this.listBox2);
            this.lstA.Location = new System.Drawing.Point(156, 78);
            this.lstA.Name = "lstA";
            this.lstA.Size = new System.Drawing.Size(118, 100);
            this.lstA.TabIndex = 11;
            this.lstA.TabStop = false;
            this.lstA.Text = "a";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Items.AddRange(new object[] {
            "Pulgadas",
            "Pies",
            "Yardas"});
            this.listBox2.Location = new System.Drawing.Point(10, 20);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(90, 56);
            this.listBox2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstDe);
            this.groupBox1.Location = new System.Drawing.Point(17, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(133, 100);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "De:";
            // 
            // lstDe
            // 
            this.lstDe.FormattingEnabled = true;
            this.lstDe.Items.AddRange(new object[] {
            "Pulgadas",
            "Pies",
            "Yardas"});
            this.lstDe.Location = new System.Drawing.Point(7, 20);
            this.lstDe.Name = "lstDe";
            this.lstDe.Size = new System.Drawing.Size(94, 56);
            this.lstDe.TabIndex = 0;
            // 
            // txtLong
            // 
            this.txtLong.Location = new System.Drawing.Point(174, 21);
            this.txtLong.Name = "txtLong";
            this.txtLong.Size = new System.Drawing.Size(100, 20);
            this.txtLong.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Introduzca longitud a convertir";
            // 
            // ejercicio_3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 254);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnConver);
            this.Controls.Add(this.txtLongConvert);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstA);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtLong);
            this.Controls.Add(this.label1);
            this.Name = "ejercicio_3";
            this.Text = "ejercicio_3";
            this.lstA.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnConver;
        private System.Windows.Forms.TextBox txtLongConvert;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox lstA;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstDe;
        private System.Windows.Forms.TextBox txtLong;
        private System.Windows.Forms.Label label1;
    }
}