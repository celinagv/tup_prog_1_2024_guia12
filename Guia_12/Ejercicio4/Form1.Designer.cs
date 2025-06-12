namespace Ejercicio4
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
            lbCantidad = new Label();
            lsbListado = new ListBox();
            btnSolicitar = new Button();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // lbCantidad
            // 
            lbCantidad.BackColor = SystemColors.ControlDark;
            lbCantidad.Location = new Point(606, 268);
            lbCantidad.Name = "lbCantidad";
            lbCantidad.Size = new Size(100, 23);
            lbCantidad.TabIndex = 9;
            // 
            // lsbListado
            // 
            lsbListado.FormattingEnabled = true;
            lsbListado.ItemHeight = 15;
            lsbListado.Location = new Point(374, 332);
            lsbListado.Name = "lsbListado";
            lsbListado.Size = new Size(318, 94);
            lsbListado.TabIndex = 8;
            // 
            // btnSolicitar
            // 
            btnSolicitar.Location = new Point(374, 214);
            btnSolicitar.Name = "btnSolicitar";
            btnSolicitar.Size = new Size(176, 23);
            btnSolicitar.TabIndex = 7;
            btnSolicitar.Text = "Solicitar valor";
            btnSolicitar.UseVisualStyleBackColor = true;
            btnSolicitar.Click += btnSolicitar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(532, 268);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 6;
            label2.Text = "Cantidad";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Location = new Point(374, 268);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 5;
            label1.Text = "Listado";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1081, 640);
            Controls.Add(lbCantidad);
            Controls.Add(lsbListado);
            Controls.Add(btnSolicitar);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbCantidad;
        private ListBox lsbListado;
        private Button btnSolicitar;
        private Label label2;
        private Label label1;
    }
}
