namespace Formulario
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void facturacionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientes clientes = new frmClientes();
            clientes.Show();
            this.Hide();

        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProductos productos = new frmProductos();
            productos.Show();
            this.Hide();
        }

        private void facturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFacturas Facturas = new frmFacturas();
            Facturas.Show();
            this.Hide();
        }

        private void informesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInformes Informes = new frmInformes();
            Informes.Show();
            this.Hide();
        }
    }
}
