namespace Formulario
{
    partial class frmInformes
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
            comboBox1 = new ComboBox();
            label3 = new Label();
            comboBox2 = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            comboBox3 = new ComboBox();
            comboBox4 = new ComboBox();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            panel1 = new Panel();
            salir = new Button();
            btnGenerarInforme = new Button();
            dgvInforme = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInforme).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(214, 9);
            label1.Name = "label1";
            label1.Size = new Size(421, 25);
            label1.TabIndex = 6;
            label1.Text = "GENERADOR DE INFORMES DE FACTURACIÓN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 23);
            label2.Name = "label2";
            label2.Size = new Size(108, 15);
            label2.TabIndex = 7;
            label2.Text = "Seleccione informe";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(151, 18);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(270, 23);
            comboBox1.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(470, 23);
            label3.Name = "label3";
            label3.Size = new Size(74, 15);
            label3.TabIndex = 9;
            label3.Text = "Ordenar por:";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(550, 20);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(106, 78);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 11;
            label4.Text = "Fecha inicio";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(357, 78);
            label5.Name = "label5";
            label5.Size = new Size(64, 15);
            label5.TabIndex = 12;
            label5.Text = "Fecha final";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(427, 75);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(121, 23);
            comboBox3.TabIndex = 13;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(182, 75);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(121, 23);
            comboBox4.TabIndex = 14;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(202, 132);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(84, 19);
            checkBox1.TabIndex = 15;
            checkBox1.Text = "En pantalla";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(328, 132);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(47, 19);
            checkBox2.TabIndex = 16;
            checkBox2.Text = "PDF";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(416, 132);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(52, 19);
            checkBox3.TabIndex = 17;
            checkBox3.Text = "Excel";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(checkBox3);
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(checkBox2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(comboBox3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(comboBox4);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(12, 37);
            panel1.Name = "panel1";
            panel1.Size = new Size(703, 175);
            panel1.TabIndex = 18;
            // 
            // salir
            // 
            salir.BackColor = Color.DarkSlateGray;
            salir.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            salir.ForeColor = SystemColors.ButtonHighlight;
            salir.Location = new Point(445, 279);
            salir.Margin = new Padding(0);
            salir.Name = "salir";
            salir.Size = new Size(75, 37);
            salir.TabIndex = 19;
            salir.Text = "Salir";
            salir.UseVisualStyleBackColor = false;
            salir.Click += salir_Click;
            // 
            // btnGenerarInforme
            // 
            btnGenerarInforme.BackColor = Color.DarkSlateGray;
            btnGenerarInforme.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnGenerarInforme.ForeColor = SystemColors.ButtonHighlight;
            btnGenerarInforme.Location = new Point(224, 279);
            btnGenerarInforme.Margin = new Padding(0);
            btnGenerarInforme.Name = "btnGenerarInforme";
            btnGenerarInforme.Size = new Size(131, 37);
            btnGenerarInforme.TabIndex = 20;
            btnGenerarInforme.Text = "Generar informe";
            btnGenerarInforme.UseVisualStyleBackColor = false;
            // 
            // dgvInforme
            // 
            dgvInforme.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInforme.Location = new Point(12, 329);
            dgvInforme.Name = "dgvInforme";
            dgvInforme.Size = new Size(776, 215);
            dgvInforme.TabIndex = 21;
            // 
            // frmInformes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 556);
            Controls.Add(dgvInforme);
            Controls.Add(btnGenerarInforme);
            Controls.Add(salir);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "frmInformes";
            Text = "Informes";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInforme).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox comboBox1;
        private Label label3;
        private ComboBox comboBox2;
        private Label label4;
        private Label label5;
        private ComboBox comboBox3;
        private ComboBox comboBox4;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private Panel panel1;
        private Button salir;
        private Button btnGenerarInforme;
        private DataGridView dgvInforme;
    }
}