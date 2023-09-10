namespace ParImpar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string valor = ttNumero.Text;


            if (EsEnetero(valor))
            {
                int entero = Int32.Parse(valor);
                if (entero % 2 == 0)
                {
                    MessageBox.Show("El valor es un numero Par");
                }
                else
                {
                    MessageBox.Show("El valor no es un numero Par");
                }
            }
            else
            {
                MessageBox.Show("No es un valor valido");
            }
        }

        static bool EsEnetero(string valor)
        {
            int numero;
            return int.TryParse(valor, out numero);
        }
    }
}