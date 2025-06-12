namespace Ejercicio3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lsbListado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSolicitar_Click(object sender, EventArgs e)
        {
            Form2 fModel = new Form2();



            //while ( i < 10 && fModel.ShowDialog()==DialogResult.OK )
            //{

            //  i++;
            //}

            int i = 0;


            fModel.ShowDialog();
            lsbListado.Items.Clear();
            while (i < 10 && fModel.DialogResult == DialogResult.OK)
            {



                lsbListado.Items.Add($"{fModel.tbValor.Text}");


                fModel.tbValor.Clear();
                fModel.ShowDialog();
                i++;
            }




            // para modificar la ventana uso start position y form border style


            lbCantidad.Text = i.ToString();
            //Para mostrar la cantidad en el label tengo que hacer esto
        }

     
    }
}
