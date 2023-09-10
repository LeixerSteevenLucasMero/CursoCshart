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
            string Nota1 = txtNota1.Text;
            string Nota2 = txtNota2.Text;
            string Nota3 = txtNota3.Text;



            int nota1 = Int32.Parse(Nota1);
            int nota2 = Int32.Parse(Nota2);
            int nota3 = Int32.Parse(Nota3);

            int total = (nota1 + nota2 + nota3) / 3; 
            
            //int Nota2 = txtNota1.Text;
            //int Nota3 = txtNota1.Text;

            MessageBox.Show("" + total);




        }

    }
}