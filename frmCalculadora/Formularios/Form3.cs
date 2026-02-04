using frmCalculadora.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace frmCalculadora
{
    public partial class frmBurbuja : Form
    {
        public frmBurbuja()
        {
            InitializeComponent();
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            Ordenamientos ordenamiento = new Ordenamientos();

            int[] ordenado = new int[dataGridView1.RowCount-1];

            for(int i=0; i < dataGridView1.RowCount-1;i++)
            {
                ordenado[i] = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);
            }
            ordenado = ordenamiento.intBurbuja(ordenado);

            //Define el tamaño de las filas del DataGridView de acuerdo al tamaño del arreglo
            dataGridView2.DataSource = ordenado;

            for(int i=0; i<ordenado.Length;i++)
            {
                dataGridView2.Rows[i].Cells[0].Value = ordenado[i];
            }
        }
    }
}
