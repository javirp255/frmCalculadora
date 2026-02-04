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
            tabPage2 = new TabPage();
            lable1 = new Label();
            txtNombre = new TextBox();
            txtApellidos = new TextBox();
            label2 = new Label();
            dtpFecha = new DateTimePicker();
            btnRegistrar = new Button();
            tabControl1.SuspendLayout();
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
            tabControl1.Size = new Size(776, 436);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(8, 46);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(760, 382);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Registro";
            tabPage1.UseVisualStyleBackColor = true;
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
            tabPage2.Size = new Size(760, 382);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Mostrar";
            tabPage2.UseVisualStyleBackColor = true;
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
            // txtNombre
            // 
            txtNombre.Location = new Point(53, 86);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(200, 39);
            txtNombre.TabIndex = 1;
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(53, 234);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(200, 39);
            txtApellidos.TabIndex = 2;
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
            // dtpFecha
            // 
            dtpFecha.Location = new Point(53, 320);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(400, 39);
            dtpFecha.TabIndex = 4;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(604, 320);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(150, 46);
            btnRegistrar.TabIndex = 5;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // frmRegistros
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "frmRegistros";
            Text = "RegistrosAlumnos";
            tabControl1.ResumeLayout(false);
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
    }
}