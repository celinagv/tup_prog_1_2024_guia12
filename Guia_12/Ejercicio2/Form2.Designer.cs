namespace Ejercicio2
{
    partial class FormModal
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
            btnCancelar = new Button();
            btnAceptar = new Button();
            label1 = new Label();
            lbMostrarValor = new Label();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(194, 262);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 0;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            btnAceptar.DialogResult = DialogResult.OK;
            btnAceptar.Location = new Point(424, 262);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 1;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(236, 181);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 2;
            label1.Text = "Valor";
            // 
            // lbMostrarValor
            // 
            lbMostrarValor.BackColor = SystemColors.ActiveCaption;
            lbMostrarValor.Location = new Point(325, 173);
            lbMostrarValor.Name = "lbMostrarValor";
            lbMostrarValor.Size = new Size(100, 23);
            lbMostrarValor.TabIndex = 3;
            // 
            // FormModal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbMostrarValor);
            Controls.Add(label1);
            Controls.Add(btnAceptar);
            Controls.Add(btnCancelar);
            Name = "FormModal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button2;
        private Label label1;
        public Button btnCancelar;
        public Button btnAceptar;
        public Label lbMostrarValor;
    }
}