namespace frmCalculadora.Formularios
{
    partial class frmRegistros
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            splitContainer1 = new SplitContainer();
            dgvPersonas = new DataGridView();
            btnEliminar = new Button();
            tabPage2 = new TabPage();
            btnRegistrar = new Button();
            dtpFecha = new DateTimePicker();
            label2 = new Label();
            txtApellidos = new TextBox();
            txtNombre = new TextBox();
            lable1 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPersonas).BeginInit();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(865, 528);
            tabControl1.TabIndex = 0;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(splitContainer1);
            tabPage1.Location = new Point(8, 46);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(849, 474);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Mostrar";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(3, 3);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(dgvPersonas);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(btnEliminar);
            splitContainer1.Size = new Size(843, 468);
            splitContainer1.SplitterDistance = 234;
            splitContainer1.TabIndex = 1;
            // 
            // dgvPersonas
            // 
            dgvPersonas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPersonas.Dock = DockStyle.Fill;
            dgvPersonas.Location = new Point(0, 0);
            dgvPersonas.Name = "dgvPersonas";
            dgvPersonas.RowHeadersWidth = 82;
            dgvPersonas.Size = new Size(843, 234);
            dgvPersonas.TabIndex = 1;
            // 
            // btnEliminar
            // 
            btnEliminar.Enabled = false;
            btnEliminar.Location = new Point(346, 151);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(150, 46);
            btnEliminar.TabIndex = 0;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnRegistrar);
            tabPage2.Controls.Add(dtpFecha);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(txtApellidos);
            tabPage2.Controls.Add(txtNombre);
            tabPage2.Controls.Add(lable1);
            tabPage2.Location = new Point(8, 46);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(849, 474);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Registrar";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(604, 320);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(150, 46);
            btnRegistrar.TabIndex = 5;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(53, 320);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(400, 39);
            dtpFecha.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 190);
            label2.Name = "label2";
            label2.Size = new Size(112, 32);
            label2.TabIndex = 3;
            label2.Text = "Apellidos";
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(53, 234);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(200, 39);
            txtApellidos.TabIndex = 2;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(53, 86);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(200, 39);
            txtNombre.TabIndex = 1;
            // 
            // lable1
            // 
            lable1.AutoSize = true;
            lable1.Location = new Point(53, 42);
            lable1.Name = "lable1";
            lable1.Size = new Size(102, 32);
            lable1.TabIndex = 0;
            lable1.Text = "Nombre";
            // 
            // frmRegistros
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 542);
            Controls.Add(tabControl1);
            Name = "frmRegistros";
            Text = "RegistrosAlumnos";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPersonas).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button btnRegistrar;
        private DateTimePicker dtpFecha;
        private Label label2;
        private TextBox txtApellidos;
        private TextBox txtNombre;
        private Label lable1;
        private SplitContainer splitContainer1;
        private DataGridView dgvPersonas;
        private Button btnEliminar;
    }
}