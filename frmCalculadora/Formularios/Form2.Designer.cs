namespace frmCalculadora
{
    partial class frmCalculadora
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
            label1 = new Label();
            label2 = new Label();
            btnCalcular = new Button();
            txtVariable1 = new TextBox();
            txtVariable2 = new TextBox();
            btnReset = new Button();
            groupBox1 = new GroupBox();
            rdbSuma = new RadioButton();
            rdbResta = new RadioButton();
            rdbMultiplicacion = new RadioButton();
            rdbDivision = new RadioButton();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 24);
            label1.Name = "label1";
            label1.Size = new Size(120, 32);
            label1.TabIndex = 2;
            label1.Text = "Variable A";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 244);
            label2.Name = "label2";
            label2.Size = new Size(119, 32);
            label2.TabIndex = 3;
            label2.Text = "Variable B";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(709, 146);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(150, 46);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.UseWaitCursor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtVariable1
            // 
            txtVariable1.Location = new Point(41, 59);
            txtVariable1.Name = "txtVariable1";
            txtVariable1.Size = new Size(200, 39);
            txtVariable1.TabIndex = 5;
            // 
            // txtVariable2
            // 
            txtVariable2.Location = new Point(41, 279);
            txtVariable2.Name = "txtVariable2";
            txtVariable2.Size = new Size(200, 39);
            txtVariable2.TabIndex = 6;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(709, 214);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(150, 46);
            btnReset.TabIndex = 7;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdbDivision);
            groupBox1.Controls.Add(rdbMultiplicacion);
            groupBox1.Controls.Add(rdbResta);
            groupBox1.Controls.Add(rdbSuma);
            groupBox1.Location = new Point(316, 72);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(343, 246);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Operaciones";
            // 
            // rdbSuma
            // 
            rdbSuma.AutoSize = true;
            rdbSuma.Location = new Point(22, 38);
            rdbSuma.Name = "rdbSuma";
            rdbSuma.Size = new Size(111, 36);
            rdbSuma.TabIndex = 0;
            rdbSuma.TabStop = true;
            rdbSuma.Text = "SUMA";
            rdbSuma.UseVisualStyleBackColor = true;
            // 
            // rdbResta
            // 
            rdbResta.AutoSize = true;
            rdbResta.Location = new Point(22, 80);
            rdbResta.Name = "rdbResta";
            rdbResta.Size = new Size(110, 36);
            rdbResta.TabIndex = 1;
            rdbResta.TabStop = true;
            rdbResta.Text = "RESTA";
            rdbResta.UseVisualStyleBackColor = true;
            // 
            // rdbMultiplicacion
            // 
            rdbMultiplicacion.AutoSize = true;
            rdbMultiplicacion.Location = new Point(22, 134);
            rdbMultiplicacion.Name = "rdbMultiplicacion";
            rdbMultiplicacion.Size = new Size(228, 36);
            rdbMultiplicacion.TabIndex = 2;
            rdbMultiplicacion.TabStop = true;
            rdbMultiplicacion.Text = "MULTIPLICACION";
            rdbMultiplicacion.UseVisualStyleBackColor = true;
            // 
            // rdbDivision
            // 
            rdbDivision.AutoSize = true;
            rdbDivision.Location = new Point(22, 188);
            rdbDivision.Name = "rdbDivision";
            rdbDivision.Size = new Size(144, 36);
            rdbDivision.TabIndex = 3;
            rdbDivision.TabStop = true;
            rdbDivision.Text = "DIVISION";
            rdbDivision.UseVisualStyleBackColor = true;
            // 
            // frmCalculadora
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 568);
            Controls.Add(groupBox1);
            Controls.Add(btnReset);
            Controls.Add(txtVariable2);
            Controls.Add(txtVariable1);
            Controls.Add(btnCalcular);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmCalculadora";
            Text = "Calculadora";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnCalcular;
        private TextBox txtVariable1;
        private TextBox txtVariable2;
        private Button btnReset;
        private GroupBox groupBox1;
        private RadioButton rdbDivision;
        private RadioButton rdbMultiplicacion;
        private RadioButton rdbResta;
        private RadioButton rdbSuma;
    }
}