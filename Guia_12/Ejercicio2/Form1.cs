namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            FormModal fDialog = new FormModal();
            fDialog.lbMostrarValor.Text = tbValor.Text;

            fDialog.ShowDialog();
            // Mustro el valor pero como en este lo capturo primero y lo guardo tengo que mostrarlo despues, caso al revez del anterior

            
        }
    }
}
