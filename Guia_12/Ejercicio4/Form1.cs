namespace Ejercicio4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void btnSolicitar_Click(object sender, EventArgs e)
        {
            int[] listado = new int[10];
            int contador = 0;

            Form2 fModal = new Form2();

            int n = 0;

            fModal.ShowDialog();

            while (n<10 && fModal.DialogResult == DialogResult.OK)
            {
                listado[n] = Convert.ToInt32(fModal.tbValor.Text); 
                n++;

            }

            lsbListado.Items.Clear();   
            if (contador >= 10)
            {
                for (int i = 0; i < contador; i++)
                {
                    lsbListado.Items.Add(listado[i]);   
                }
            }
        }
    }
}
