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
            MessageBox.Show("El valor de la variable numerico es: " + valorNumererico);
        }

        private void otraFuncion()
        {
            valorNumererico = 20;
        }
    }
}