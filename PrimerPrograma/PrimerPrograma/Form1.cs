namespace PrimerPrograma
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

        private void btnVerMensaje_Click(object sender, EventArgs e)
        {
            //video3:variable
            int valorNumerico = 20;
            valorNumerico = 15;
            //constante: el valor inicial no se puede modificar despues por qe es una constante
            //const int valorNumeroo = 20;
            //valorNumericoo = 15;

            //Mesage en ventana emergenete
            MessageBox.Show("El valor de la variable numerica es:" + valorNumerico);
        }
    }
}