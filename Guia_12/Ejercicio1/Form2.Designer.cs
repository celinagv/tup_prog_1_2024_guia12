namespace Ejercicio1
{
    partial class Form2
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
            label1 = new Label();
            tbValor = new TextBox();
            btnCancelar = new Button();
            btnAceptar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(316, 233);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(71, 23);
            label1.TabIndex = 0;
            label1.Text = "Valor";
            // 
            // tbValor
            // 
            tbValor.Location = new Point(498, 228);
            tbValor.Margin = new Padding(6, 5, 6, 5);
            tbValor.Name = "tbValor";
            tbValor.Size = new Size(379, 31);
            tbValor.TabIndex = 1;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(409, 371);
            btnCancelar.Margin = new Padding(6, 5, 6, 5);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(139, 35);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            btnAceptar.DialogResult = DialogResult.OK;
            btnAceptar.Location = new Point(741, 371);
            btnAceptar.Margin = new Padding(6, 5, 6, 5);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(139, 35);
            btnAceptar.TabIndex = 3;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // Form2
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1076, 537);
            Controls.Add(btnAceptar);
            Controls.Add(btnCancelar);
            Controls.Add(tbValor);
            Controls.Add(label1);
            Font = new Font("Showcard Gothic", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            Margin = new Padding(6, 5, 6, 5);
            Name = "Form2";
            StartPosition = FormStartPosition.WindowsDefaultBounds;
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnCancelar;
        private Button btnAceptar;
        public TextBox tbValor;
    }
}