﻿namespace Ejercicio2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            tbValor = new TextBox();
            btnMostrar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 187);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 0;
            label1.Text = "Valor";
            // 
            // tbValor
            // 
            tbValor.Location = new Point(197, 183);
            tbValor.Name = "tbValor";
            tbValor.Size = new Size(140, 23);
            tbValor.TabIndex = 1;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(423, 183);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(145, 23);
            btnMostrar.TabIndex = 2;
            btnMostrar.Text = "Mostrar Valor";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(672, 347);
            Controls.Add(btnMostrar);
            Controls.Add(tbValor);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Ejemplo modal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbValor;
        private Button btnMostrar;
    }
}
