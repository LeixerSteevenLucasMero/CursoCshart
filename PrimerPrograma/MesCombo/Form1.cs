namespace MesCombo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            textMes.Enabled = false;
            List<String> meses = new List<String>();
            meses.AddRange(new String[] {"1", "2", "3", "4",
                "5", "6", "7", "8",
                "9", "10", "11", "12"});
            comboMes.DataSource = meses;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            int comboValor = int.Parse(comboMes.SelectedItem.ToString());

            switch (comboValor)
            {
                case 1:
                    textMes.Text = "Enero";
                    break;
                case 2:
                    textMes.Text = "Febrero";
                    break;
                case 3:
                    textMes.Text = "Marzo";
                    break;
                case 4:
                    textMes.Text = "Abril";
                    break;
                case 5:
                    textMes.Text = "Mayo";
                    break;
                case 6:
                    textMes.Text = "Junio";
                    break;
                case 7:
                    textMes.Text = "Julio";
                    break;
                case 8:
                    textMes.Text = "Agosto";
                    break;
                case 9:
                    textMes.Text = "Septiembre";
                    break;
                case 10:
                    textMes.Text = "Octubre";
                    break;
                case 11:
                    textMes.Text = "Noviembre";
                    break;
                case 12:
                    textMes.Text = "Diciembre";
                    break;
                default:
                    textMes.Text = "Valor inválido"; // Manejo de caso por si el valor no es válido.
                    break;
            }

        }
    }
}