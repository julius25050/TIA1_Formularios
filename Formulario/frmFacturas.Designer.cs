namespace Formulario
{
    partial class frmFacturas
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            textBox1 = new TextBox();
            panel1 = new Panel();
            comboBox3 = new ComboBox();
            label9 = new Label();
            monthCalendar1 = new MonthCalendar();
            label8 = new Label();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            label11 = new Label();
            salir = new Button();
            btnActualizar = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(232, 9);
            label1.Name = "label1";
            label1.Size = new Size(278, 25);
            label1.TabIndex = 6;
            label1.Text = "ADMINISTRACIÓN FACTURAS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 11);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 7;
            label2.Text = "Nro Factura";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 67);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 8;
            label3.Text = "Cliente";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 98);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 9;
            label4.Text = "Empleado";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 152);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 10;
            label5.Text = "Descuento";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 188);
            label6.Name = "label6";
            label6.Size = new Size(53, 15);
            label6.TabIndex = 11;
            label6.Text = "Total IVA";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(20, 225);
            label7.Name = "label7";
            label7.Size = new Size(73, 15);
            label7.TabIndex = 12;
            label7.Text = "Total factura";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(110, 59);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(214, 23);
            comboBox1.TabIndex = 13;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(110, 98);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(214, 23);
            comboBox2.TabIndex = 14;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(110, 8);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(114, 23);
            textBox1.TabIndex = 15;
            // 
            // panel1
            // 
            panel1.Controls.Add(comboBox3);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(monthCalendar1);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(33, 37);
            panel1.Name = "panel1";
            panel1.Size = new Size(703, 272);
            panel1.TabIndex = 16;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(525, 225);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(117, 23);
            comboBox3.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(543, 207);
            label9.Name = "label9";
            label9.Size = new Size(82, 15);
            label9.TabIndex = 11;
            label9.Text = "Estado factura";
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(467, 41);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(543, 22);
            label8.Name = "label8";
            label8.Size = new Size(78, 15);
            label8.TabIndex = 8;
            label8.Text = "Fecha factura";
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(label11);
            panel2.Location = new Point(33, 341);
            panel2.Name = "panel2";
            panel2.Size = new Size(547, 217);
            panel2.TabIndex = 18;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(16, 17);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(513, 183);
            dataGridView1.TabIndex = 18;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(28, -1);
            label11.Name = "label11";
            label11.Size = new Size(109, 15);
            label11.TabIndex = 17;
            label11.Text = "DETALLE FACTURA";
            // 
            // salir
            // 
            salir.BackColor = Color.DarkSlateGray;
            salir.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            salir.ForeColor = SystemColors.ButtonHighlight;
            salir.Location = new Point(661, 521);
            salir.Margin = new Padding(0);
            salir.Name = "salir";
            salir.Size = new Size(75, 37);
            salir.TabIndex = 19;
            salir.Text = "Salir";
            salir.UseVisualStyleBackColor = false;
            salir.Click += salir_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.DarkSlateGray;
            btnActualizar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnActualizar.ForeColor = SystemColors.ButtonFace;
            btnActualizar.Location = new Point(661, 341);
            btnActualizar.Margin = new Padding(0);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 37);
            btnActualizar.TabIndex = 20;
            btnActualizar.Text = "Actualizar ";
            btnActualizar.UseVisualStyleBackColor = false;
            // 
            // frmFacturas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(774, 589);
            Controls.Add(btnActualizar);
            Controls.Add(salir);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "frmFacturas";
            Text = "Facturas";
            Load += frmFacturas_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private TextBox textBox1;
        private Panel panel1;
        private ComboBox comboBox3;
        private Label label9;
        private MonthCalendar monthCalendar1;
        private Label label8;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Label label11;
        private Button salir;
        private Button btnActualizar;
    }
}