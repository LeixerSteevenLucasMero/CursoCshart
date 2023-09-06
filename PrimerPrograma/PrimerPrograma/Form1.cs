namespace PrimerPrograma
{
    public partial class Form1 : Form
    {
        int valorNumererico = 20;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnVerMensaje_Click(object sender, EventArgs e)
        {
            //Operadore aritmeticos
            int epresionAritmetica = 24;
            epresionAritmetica+=6;
            epresionAritmetica-= 10;
            //int epresionAritmetica1 = 5 - 4;
            //int epresionAritmetica2 = 5 * 4;
            //int epresionAritmetica3 = 5 / 4;

            //Operador relacional
            bool epresionesRelaciones = 9 == 9 && -100>2;
            bool epresionesRelaciones2 = 9 == 9 || -100>2;




            MessageBox.Show("" + epresionesRelaciones);
        }

        private void otraFuncion()
        {
            valorNumererico = 20;
        }
    }
}