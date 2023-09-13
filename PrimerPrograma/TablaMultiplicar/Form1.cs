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
            //for (int i = 1; i <= 5; i++)
            //{
            //    MessageBox.Show("Hola numero de prueba for: " + i);
            //}


        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            string numero = textNum.Text;
            
            if (EsEntero(numero))
            {
                int nuevoNum = int.Parse(numero);

                listBoxTabla.Items.Clear();

                for (int i = 0; i <= 10; i++){
                    listBoxTabla.Items.Add(nuevoNum + "X" + i + "=" + (nuevoNum * i) );

                }

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