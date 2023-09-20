namespace TablaMultiplicar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            string numero = textNum.Text;

            if (EsEntero(numero))
            {
                int numNuevo = int.Parse(numero);
                //bucle while se ejucuta siempre y cuando se cumpra su condion
                while (numNuevo > 0)
                {
                    listBoxTabla.Items.Add("Mensaje del bucle while");
                    numNuevo--;
                }
                //bucle do while 1 vez y las otras veces si se cumple su condicion
                do {
                    listBoxTabla.Items.Add("Mensaje del bucle while");
                    numNuevo--;
                } while (numNuevo > 0);

            }
            else
            {
                MessageBox.Show("DEBE INGRESAR UN NUMERO ENTERNO");
            }


        }

        static bool EsEntero(string numero)
        {
            int num;
            return int.TryParse(numero, out num);
        }
    }
}