namespace frmCalculadora
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mnsStripPrincipal = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            aplicacionesToolStripMenuItem = new ToolStripMenuItem();
            calculadoraSimpleToolStripMenuItem = new ToolStripMenuItem();
            ordenamientosToolStripMenuItem = new ToolStripMenuItem();
            burbujaSimpleToolStripMenuItem = new ToolStripMenuItem();
            registrosToolStripMenuItem = new ToolStripMenuItem();
            temporizadorToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            editorToolStripMenuItem = new ToolStripMenuItem();
            contadorToolStripMenuItem = new ToolStripMenuItem();
            xmlDirectorioToolStripMenuItem = new ToolStripMenuItem();
            mnsStripPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // mnsStripPrincipal
            // 
            mnsStripPrincipal.ImageScalingSize = new Size(32, 32);
            mnsStripPrincipal.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, aplicacionesToolStripMenuItem });
            mnsStripPrincipal.Location = new Point(0, 0);
            mnsStripPrincipal.Name = "mnsStripPrincipal";
            mnsStripPrincipal.Size = new Size(1092, 42);
            mnsStripPrincipal.TabIndex = 0;
            mnsStripPrincipal.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salirToolStripMenuItem });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(114, 38);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(192, 44);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // aplicacionesToolStripMenuItem
            // 
            aplicacionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { calculadoraSimpleToolStripMenuItem, ordenamientosToolStripMenuItem, registrosToolStripMenuItem, temporizadorToolStripMenuItem, editorToolStripMenuItem, contadorToolStripMenuItem, xmlDirectorioToolStripMenuItem });
            aplicacionesToolStripMenuItem.Name = "aplicacionesToolStripMenuItem";
            aplicacionesToolStripMenuItem.Size = new Size(166, 38);
            aplicacionesToolStripMenuItem.Text = "Aplicaciones";
            // 
            // calculadoraSimpleToolStripMenuItem
            // 
            calculadoraSimpleToolStripMenuItem.Name = "calculadoraSimpleToolStripMenuItem";
            calculadoraSimpleToolStripMenuItem.Size = new Size(359, 44);
            calculadoraSimpleToolStripMenuItem.Text = "Calculadora Simple";
            // 
            // ordenamientosToolStripMenuItem
            // 
            ordenamientosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { burbujaSimpleToolStripMenuItem });
            ordenamientosToolStripMenuItem.Name = "ordenamientosToolStripMenuItem";
            ordenamientosToolStripMenuItem.Size = new Size(359, 44);
            ordenamientosToolStripMenuItem.Text = "Ordenamientos";
            ordenamientosToolStripMenuItem.Click += ordenamientosToolStripMenuItem_Click;
            // 
            // burbujaSimpleToolStripMenuItem
            // 
            burbujaSimpleToolStripMenuItem.Name = "burbujaSimpleToolStripMenuItem";
            burbujaSimpleToolStripMenuItem.Size = new Size(309, 44);
            burbujaSimpleToolStripMenuItem.Text = "Burbuja Simple";
            burbujaSimpleToolStripMenuItem.Click += burbujaSimpleToolStripMenuItem_Click;
            // 
            // registrosToolStripMenuItem
            // 
            registrosToolStripMenuItem.Name = "registrosToolStripMenuItem";
            registrosToolStripMenuItem.Size = new Size(359, 44);
            registrosToolStripMenuItem.Text = "Registros";
            registrosToolStripMenuItem.Click += registrosToolStripMenuItem_Click;
            // 
            // temporizadorToolStripMenuItem
            // 
            temporizadorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            temporizadorToolStripMenuItem.Name = "temporizadorToolStripMenuItem";
            temporizadorToolStripMenuItem.Size = new Size(359, 44);
            temporizadorToolStripMenuItem.Text = "reloj";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(133, 44);
            // 
            // editorToolStripMenuItem
            // 
            editorToolStripMenuItem.Name = "editorToolStripMenuItem";
            editorToolStripMenuItem.Size = new Size(359, 44);
            editorToolStripMenuItem.Text = "Editor";
            editorToolStripMenuItem.Click += editorToolStripMenuItem_Click;
            // 
            // contadorToolStripMenuItem
            // 
            contadorToolStripMenuItem.Name = "contadorToolStripMenuItem";
            contadorToolStripMenuItem.Size = new Size(359, 44);
            contadorToolStripMenuItem.Text = "Contador";
            contadorToolStripMenuItem.Click += contadorToolStripMenuItem_Click;
            // 
            // xmlDirectorioToolStripMenuItem
            // 
            xmlDirectorioToolStripMenuItem.Name = "xmlDirectorioToolStripMenuItem";
            xmlDirectorioToolStripMenuItem.Size = new Size(359, 44);
            xmlDirectorioToolStripMenuItem.Text = "XmlDirectorio";
            xmlDirectorioToolStripMenuItem.Click += xmlDirectorioToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1092, 564);
            Controls.Add(mnsStripPrincipal);
            MainMenuStrip = mnsStripPrincipal;
            Name = "Form1";
            Text = "Menu";
            mnsStripPrincipal.ResumeLayout(false);
            mnsStripPrincipal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnsStripPrincipal;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem aplicacionesToolStripMenuItem;
        private ToolStripMenuItem calculadoraSimpleToolStripMenuItem;
        private ToolStripMenuItem ordenamientosToolStripMenuItem;
        private ToolStripMenuItem burbujaSimpleToolStripMenuItem;
        private ToolStripMenuItem registrosToolStripMenuItem;
        private ToolStripMenuItem temporizadorToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem editorToolStripMenuItem;
        private ToolStripMenuItem contadorToolStripMenuItem;
        private ToolStripMenuItem xmlDirectorioToolStripMenuItem;
    }
}
