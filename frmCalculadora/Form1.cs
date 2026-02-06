using frmCalculadora.Formularios;

namespace frmCalculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ordenamientosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void burbujaSimpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBurbuja burbuja = new frmBurbuja();
            burbuja.Show();
        }

        private void registrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistros registros = new frmRegistros();
            registros.Show();
        }
    }
}
