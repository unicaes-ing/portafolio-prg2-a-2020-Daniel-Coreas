﻿namespace Practica_3
{
    partial class ejercicio_2
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
            this.lstLetras = new System.Windows.Forms.ListBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstLetras
            // 
            this.lstLetras.FormattingEnabled = true;
            this.lstLetras.Location = new System.Drawing.Point(13, 13);
            this.lstLetras.Name = "lstLetras";
            this.lstLetras.Size = new System.Drawing.Size(120, 342);
            this.lstLetras.TabIndex = 0;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(13, 360);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 23);
            this.btnMostrar.TabIndex = 1;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // ejercicio_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(171, 386);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.lstLetras);
            this.Name = "ejercicio_2";
            this.Text = "ejercicio_2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstLetras;
        private System.Windows.Forms.Button btnMostrar;
    }
}