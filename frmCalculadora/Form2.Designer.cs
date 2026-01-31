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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 24);
            label1.Name = "label1";
            label1.Size = new Size(118, 32);
            label1.TabIndex = 2;
            label1.Text = "Variable 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 244);
            label2.Name = "label2";
            label2.Size = new Size(118, 32);
            label2.TabIndex = 3;
            label2.Text = "Variable 2";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(493, 156);
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
            btnReset.Location = new Point(493, 272);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(150, 46);
            btnReset.TabIndex = 7;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // frmCalculadora
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnReset);
            Controls.Add(txtVariable2);
            Controls.Add(txtVariable1);
            Controls.Add(btnCalcular);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmCalculadora";
            Text = "Calculadora";
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
    }
}