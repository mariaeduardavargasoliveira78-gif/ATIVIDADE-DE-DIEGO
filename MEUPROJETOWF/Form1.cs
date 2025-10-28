namespace MEUPROJETOWF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void focoPeso(object sender, EventArgs e)
        {
            txtPeso.BackColor = Color.Red;
            txtAltura.BackColor = Color.White;
        }

        private void focoAltura(object sender, EventArgs e)
        {
            txtAltura.BackColor = Color.Red;
            txtPeso.BackColor = Color.White;
        }

        private void gerarNumeros(object sender, EventArgs e)
        {
            if (txtPeso.BackColor == Color.Red)
            {
                txtPeso.Text += ((Button)sender).Text;
            }
            else if (txtAltura.BackColor == Color.Red)
            {
                txtAltura.Text += ((Button)sender).Text;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            float peso = float.Parse(txtPeso.Text);
            float altura = float.Parse(txtAltura.Text);
            float imc = peso / (float)(Math.Pow(altura, 2);

            txtIMC.Text = imc.ToString("N1");

        if (imc < 19.1)
         