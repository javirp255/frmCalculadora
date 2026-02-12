using frmCalculadora.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace frmCalculadora.Formularios
{
    public partial class frmRegistros : Form
    {

        List<Persona> persona = new List<Persona>();
        public frmRegistros()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            persona.Add(new Persona() { Nombre = txtNombre.Text, Apellido = txtApellidos.Text, Fecha = dtpFecha.Value });

            MessageBox.Show("Datos Registrados", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {

                dgvPersonas.DataSource = null;
                dgvPersonas.DataSource = persona;
                verificarRegistros();
            }
        }

        private void verificarRegistros()
        {
            if(persona.Count() == 0)
            {
                btnEliminar.Enabled = false;
            }
            else
                btnEliminar.Enabled = true;


        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            persona.RemoveAt(dgvPersonas.CurrentRow.Index);
            dgvPersonas.DataSource = null; //Limpia el dataGridview
            dgvPersonas.DataSource = persona; //Vuelve a cargar el dataGridview
            verificarRegistros();//verificar el dataGridView para habilitar o deshabilitar el boton eliminar
        }
    }
}


