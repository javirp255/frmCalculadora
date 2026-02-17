using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace frmCalculadora.Formularios
{
    public partial class frmEditor : Form
    {
        bool saved = false;
        string path = "";
        string texto;
        public frmEditor()
        {
            InitializeComponent();
        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ofpEditor.ShowDialog() == DialogResult.OK)
                if (File.Exists(ofpEditor.FileName))
                {
                    rtbEditor.Text = File.ReadAllText(ofpEditor.FileName);

                }

        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Guardar();

        }

        private void Guardar()
        {

            if (sfdEditor.ShowDialog() == DialogResult.OK)
            {
                path = sfdEditor.FileName;
                using (StreamWriter sw = new StreamWriter(sfdEditor.FileName))
                {
                    sw.WriteLine(rtbEditor.Text);
                }
            }
        }

        private void frmEditor_Load(object sender, EventArgs e)
        {

        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbEditor.Clear();
            path = "";
            saved = false;
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saved == false)
            {
                Guardar();
                saved = true;

            }
            else
            {
                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.WriteLine(rtbEditor.Text);
                }

            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rtbEditor_TextChanged(object sender, EventArgs e)
        {
            texto = rtbEditor.Text;
            string[] palabras = texto.Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            tssStatus.Text = palabras.Length.ToString() + " palabras";
        }

        private void tssStatus_Click(object sender, EventArgs e)
        {
            string[] palabras = texto.Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            string[] parrafos = texto.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
            MessageBox.Show("Estadisticas: \n\nPalabras: " + palabras.Length.ToString() + "\nLetras: " + texto.Length.ToString()
                + "\nParrafos: "
                + texto.Length.ToString(), "Contador de Palabras");
        }

        private void fuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbEditor.Font = ftdEditor.Font;
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cldEditor.Color = cldEditor.Color;
        }
    }

}
