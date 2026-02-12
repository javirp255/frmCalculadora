using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Media;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Media;
using CSCore.SoundOut;


namespace frmCalculadora.Formularios
{
    public partial class frmTemporizadores : Form
    {
        String alarma = "";
        public frmTemporizadores()
        {
            InitializeComponent();
        }

        private void trmHora_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
            if (label1.Text == alarma)
            {
                SoundPlayer player = new SoundPlayer(@"C:\Users\Javier\source\repos\frmCalculadora\frmCalculadora\Sonidos\u_4x5im7t8ci-gallo-cantando-292945.wav");
                    player.Play();
            }
        }

        private void alarma1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            alarma = Interaction.InputBox("Ingrese la hora","Sistema","00:00:00.x.x");
        }
    }
}
