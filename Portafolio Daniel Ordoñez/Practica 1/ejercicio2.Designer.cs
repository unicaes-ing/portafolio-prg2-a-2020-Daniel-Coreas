namespace Practica_1
{
    partial class ejercicio2
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
            this.btnLimp = new System.Windows.Forms.Button();
            this.btnCalc = new System.Windows.Forms.Button();
            this.grpequiv = new System.Windows.Forms.GroupBox();
            this.lblHex = new System.Windows.Forms.Label();
            this.lblOct = new System.Windows.Forms.Label();
            this.lblbin = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblDec = new System.Windows.Forms.Label();
            this.grpequiv.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(194, 213);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnLimp
            // 
            this.btnLimp.Location = new System.Drawing.Point(94, 213);
            this.btnLimp.Name = "btnLimp";
            this.btnLimp.Size = new System.Drawing.Size(75, 23);
            this.btnLimp.TabIndex = 10;
            this.btnLimp.Text = "Limpiar";
            this.btnLimp.UseVisualStyleBackColor = true;
            this.btnLimp.Click += new System.EventHandler(this.btnLimp_Click);
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(13, 213);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 9;
            this.btnCalc.Text = "Calcular";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // grpequiv
            // 
            this.grpequiv.Controls.Add(this.lblHex);
            this.grpequiv.Controls.Add(this.lblOct);
            this.grpequiv.Controls.Add(this.lblbin);
            this.grpequiv.Controls.Add(this.textBox4);
            this.grpequiv.Controls.Add(this.textBox3);
            this.grpequiv.Controls.Add(this.textBox2);
            this.grpequiv.Location = new System.Drawing.Point(43, 73);
            this.grpequiv.Name = "grpequiv";
            this.grpequiv.Size = new System.Drawing.Size(200, 100);
            this.grpequiv.TabIndex = 8;
            this.grpequiv.TabStop = false;
            this.grpequiv.Text = "Equivale a:";
            // 
            // lblHex
            // 
            this.lblHex.AutoSize = true;
            this.lblHex.Location = new System.Drawing.Point(25, 77);
            this.lblHex.Name = "lblHex";
            this.lblHex.Size = new System.Drawing.Size(71, 13);
            this.lblHex.TabIndex = 5;
            this.lblHex.Text = "Hexadecimal:";
            // 
            // lblOct
            // 
            this.lblOct.AutoSize = true;
            this.lblOct.Location = new System.Drawing.Point(25, 50);
            this.lblOct.Name = "lblOct";
            this.lblOct.Size = new System.Drawing.Size(35, 13);
            this.lblOct.TabIndex = 4;
            this.lblOct.Text = "Octal:";
            // 
            // lblbin
            // 
            this.lblbin.AutoSize = true;
            this.lblbin.Location = new System.Drawing.Point(25, 27);
            this.lblbin.Name = "lblbin";
            this.lblbin.Size = new System.Drawing.Size(42, 13);
            this.lblbin.TabIndex = 3;
            this.lblbin.Text = "Binario:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(112, 74);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(112, 47);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(112, 20);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(104, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 7;
            // 
            // lblDec
            // 
            this.lblDec.AutoSize = true;
            this.lblDec.Location = new System.Drawing.Point(40, 26);
            this.lblDec.Name = "lblDec";
            this.lblDec.Size = new System.Drawing.Size(45, 13);
            this.lblDec.TabIndex = 6;
            this.lblDec.Text = "Decimal";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 261);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimp);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.grpequiv);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblDec);
            this.Name = "Form2";
            this.Text = "Form2";
            this.grpequiv.ResumeLayout(false);
            this.grpequiv.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnLimp;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.GroupBox grpequiv;
        private System.Windows.Forms.Label lblHex;
        private System.Windows.Forms.Label lblOct;
        private System.Windows.Forms.Label lblbin;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblDec;
    }
}