namespace frmCalculadora.Formularios
{
    partial class frmTemporizadores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            tmrHora = new System.Windows.Forms.Timer(components);
            menuStrip1 = new MenuStrip();
            nmsAlarma = new ToolStripMenuItem();
            alarma1 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AccessibleRole = AccessibleRole.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F);
            label1.Location = new Point(152, 130);
            label1.Name = "label1";
            label1.Size = new Size(543, 128);
            label1.TabIndex = 0;
            label1.Text = "00:00:00 x.x";
            // 
            // tmrHora
            // 
            tmrHora.Enabled = true;
            tmrHora.Interval = 10000;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { nmsAlarma });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 42);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // nmsAlarma
            // 
            nmsAlarma.DropDownItems.AddRange(new ToolStripItem[] { alarma1 });
            nmsAlarma.Name = "nmsAlarma";
            nmsAlarma.Size = new Size(141, 38);
            nmsAlarma.Text = "Establecer";
            // 
            // alarma1
            // 
            alarma1.Name = "alarma1";
            alarma1.Size = new Size(359, 44);
            alarma1.Text = "Alarma 1";
            alarma1.Click += alarma1ToolStripMenuItem_Click;
            // 
            // frmTemporizadores
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 562);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmTemporizadores";
            Text = "frmTemporizadores";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private System.Windows.Forms.Timer tmrHora;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem nmsAlarma;
        private ToolStripMenuItem alarma1;
    }
}