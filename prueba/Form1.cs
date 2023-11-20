namespace prueba
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBoton_Click(object sender, EventArgs e)
        {
            txtTexto.Text = "Brayam Edwin";
        }

        private void btnSaludo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola Brayam Edwin este es una alerta","Prueba");
        }
    }
}