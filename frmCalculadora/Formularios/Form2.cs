using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace frmCalculadora
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {

                int a, b;
                int resultado;
                a = 0;
                b = 0;
                a = Convert.ToInt32(txtVariable1);
                b = int.Parse(txtVariable2.Text);

                if (rdbSuma.Checked)
                    resultado = a + b;
                if(rdbResta.Checked)
                    resultado = a - b;
                if(rdbMultiplicacion.Checked)
                    resultado = a * b;
                if(rdbDivision.Checked)
                    resultado = a / b;

                resultado = a + b;
                MessageBox.Show("El resultado es: " + resultado.ToString(), "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Error en la conversión de datos", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void reset()
        {
            txtVariable1.Clear();
            txtVariable2.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
