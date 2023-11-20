using Comun.Cache;

namespace Presentacion
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            CargarUsuario();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void btnSalirr_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desa salir de la Aplicacion", "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }

        private void CargarUsuario()
        {
            lblNombre.Text = UsuarioLoginCache.Nombre;
            lblPaterno.Text = UsuarioLoginCache.ApellidoPaterno;
            lblMaterno.Text = UsuarioLoginCache.ApellidoMaterno;
            lblDocumento.Text = UsuarioLoginCache.NumDocumento;
            lblCorreo.Text = UsuarioLoginCache.Correo;
            lblRol.Text = UsuarioLoginCache.Rol;

        }

        private void AbrirFormularioEnPanel(object formhija)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form? fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }

        private void btnPersonas_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new FormularioPersonas());
        }

        private void btnCalculadora_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new Calculadora());
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new FormularioProducto());
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}