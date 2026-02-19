namespace Formulario
{
    partial class frmEmpleados
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
            txtNameClient = new TextBox();
            txtIdClient = new TextBox();
            txtAddressClient = new TextBox();
            txtTelClient = new TextBox();
            txtEmailClient = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            comboBox1 = new ComboBox();
            dtkIngreso = new DateTimePicker();
            dtkRetiro = new DateTimePicker();
            textBox1 = new TextBox();
            btnActualizar = new Button();
            salir = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // txtNameClient
            // 
            txtNameClient.BackColor = SystemColors.ScrollBar;
            txtNameClient.Location = new Point(36, 159);
            txtNameClient.Name = "txtNameClient";
            txtNameClient.Size = new Size(369, 23);
            txtNameClient.TabIndex = 12;
            txtNameClient.Text = "Nombre cliente";
            // 
            // txtIdClient
            // 
            txtIdClient.BackColor = SystemColors.ScrollBar;
            txtIdClient.Location = new Point(36, 198);
            txtIdClient.Name = "txtIdClient";
            txtIdClient.Size = new Size(369, 23);
            txtIdClient.TabIndex = 13;
            txtIdClient.Text = "Documento";
            // 
            // txtAddressClient
            // 
            txtAddressClient.BackColor = SystemColors.ScrollBar;
            txtAddressClient.Location = new Point(36, 239);
            txtAddressClient.Name = "txtAddressClient";
            txtAddressClient.Size = new Size(369, 23);
            txtAddressClient.TabIndex = 14;
            txtAddressClient.Text = "Direccion";
            // 
            // txtTelClient
            // 
            txtTelClient.BackColor = SystemColors.ScrollBar;
            txtTelClient.Location = new Point(36, 280);
            txtTelClient.Name = "txtTelClient";
            txtTelClient.Size = new Size(369, 23);
            txtTelClient.TabIndex = 15;
            txtTelClient.Text = "Telefono";
            // 
            // txtEmailClient
            // 
            txtEmailClient.BackColor = SystemColors.ScrollBar;
            txtEmailClient.Location = new Point(36, 322);
            txtEmailClient.Name = "txtEmailClient";
            txtEmailClient.Size = new Size(369, 23);
            txtEmailClient.TabIndex = 16;
            txtEmailClient.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(246, 45);
            label1.Name = "label1";
            label1.Size = new Size(324, 25);
            label1.TabIndex = 17;
            label1.Text = "ADMINISTRACIÓN DE EMPLEADOS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(510, 137);
            label2.Name = "label2";
            label2.Size = new Size(80, 15);
            label2.TabIndex = 18;
            label2.Text = "Rol Empleado";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(532, 181);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 19;
            label3.Text = "F. Ingreso";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(540, 214);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 20;
            label4.Text = "F. Retiro";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(510, 258);
            label5.Name = "label5";
            label5.Size = new Size(120, 15);
            label5.TabIndex = 21;
            label5.Text = "DATOS ADICIONALES";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(611, 134);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(146, 23);
            comboBox1.TabIndex = 22;
            // 
            // dtkIngreso
            // 
            dtkIngreso.Format = DateTimePickerFormat.Short;
            dtkIngreso.Location = new Point(611, 175);
            dtkIngreso.Name = "dtkIngreso";
            dtkIngreso.Size = new Size(146, 23);
            dtkIngreso.TabIndex = 23;
            // 
            // dtkRetiro
            // 
            dtkRetiro.Format = DateTimePickerFormat.Short;
            dtkRetiro.Location = new Point(611, 211);
            dtkRetiro.Name = "dtkRetiro";
            dtkRetiro.Size = new Size(146, 23);
            dtkRetiro.TabIndex = 24;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(510, 284);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(247, 61);
            textBox1.TabIndex = 25;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.DarkSlateGray;
            btnActualizar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnActualizar.ForeColor = SystemColors.ButtonFace;
            btnActualizar.Location = new Point(323, 379);
            btnActualizar.Margin = new Padding(0);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(82, 37);
            btnActualizar.TabIndex = 26;
            btnActualizar.Text = "Actualizar ";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // salir
            // 
            salir.BackColor = Color.DarkSlateGray;
            salir.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            salir.ForeColor = SystemColors.ButtonHighlight;
            salir.Location = new Point(434, 379);
            salir.Margin = new Padding(0);
            salir.Name = "salir";
            salir.Size = new Size(86, 37);
            salir.TabIndex = 30;
            salir.Text = "Salir";
            salir.UseVisualStyleBackColor = false;
            salir.Click += salir_Click_1;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmEmpleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 440);
            Controls.Add(salir);
            Controls.Add(btnActualizar);
            Controls.Add(textBox1);
            Controls.Add(dtkRetiro);
            Controls.Add(dtkIngreso);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtEmailClient);
            Controls.Add(txtTelClient);
            Controls.Add(txtAddressClient);
            Controls.Add(txtIdClient);
            Controls.Add(txtNameClient);
            Name = "frmEmpleados";
            Text = "frmEmpleados";
            Load += frmEmpleados_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNameClient;
        private TextBox txtIdClient;
        private TextBox txtAddressClient;
        private TextBox txtTelClient;
        private TextBox txtEmailClient;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox comboBox1;
        private DateTimePicker dtkIngreso;
        private DateTimePicker dtkRetiro;
        private TextBox textBox1;
        private Button btnActualizar;
        private Button salir;
        private ErrorProvider errorProvider1;
    }
}