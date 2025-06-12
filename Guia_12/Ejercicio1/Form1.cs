namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSolicitar_Click(object sender, EventArgs e)
        {
            lbMostrarValor.Text = textBox1.Text;

            Form2 fDialog = new Form2();
            if (fDialog.ShowDialog() == DialogResult.OK)//Invocar show dialog me muestra la ventana modal y me devuelve el valor que corresponde al boton presionado
            {
                lbMostrarValor.Text = fDialog.tbValor.Text ;
            }
            else
            {
                lbMostrarValor.Text = "Valor cancelado";
            }
        }

    }
}
