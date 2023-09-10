using System.Configuration;

namespace DescuentoCompras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string valorActual = textCompra.Text;
            double valorDesc;
            double total;

            if (EsEntero(valorActual))
            {
                int valor = int.Parse(textCompra.Text);
                if (valor < 100)
                {
                    textDescuento.Text = "No existe descuento";
                    textDesTotal.Text = valor.ToString();
                }
                else if (valor > 100 && valor < 150)
                {
                    textDescuento.Text = "Descento del 5%";
                    valorDesc = valor * 0.05;
                    total = valor - valorDesc;
                    textDesTotal.Text = total.ToString();
                }
                else if (valor > 149 && valor < 200)
                {
                    textDescuento.Text = "Descento del 10%";
                    valorDesc = valor * 0.10;
                    total = valor - valorDesc;
                    textDesTotal.Text = total.ToString();
                }
                else if (valor >= 200)
                {
                    textDescuento.Text = "Descento del 15%";
                    valorDesc = valor * 0.15;
                    total = valor - valorDesc;
                    textDesTotal.Text = total.ToString();
                }


            }
            else
            {
                MessageBox.Show("No es un valor valido");
            }

        }

        static bool EsEntero(string valor)
        {
            int numero;
            return int.TryParse(valor, out numero);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textDescuento.Enabled = false;
            textDesTotal.Enabled = false;
        }
    }
}