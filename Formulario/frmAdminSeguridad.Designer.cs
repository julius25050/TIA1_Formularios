namespace Formulario
{
    partial class frmAdminSeguridad
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
            label2 = new Label();
            label1 = new Label();
            comboBox1 = new ComboBox();
            txtUsuario = new TextBox();
            txtClave = new TextBox();
            salir = new Button();
            btnActualizar = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(112, 33);
            label2.Name = "label2";
            label2.Size = new Size(431, 25);
            label2.TabIndex = 19;
            label2.Text = "ADMINISTRACIÓN DE USUARIOS DEL SISTEMA";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(112, 129);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 20;
            label1.Text = "Empleado";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(193, 126);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(381, 23);
            comboBox1.TabIndex = 21;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(242, 206);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(163, 23);
            txtUsuario.TabIndex = 22;
            txtUsuario.Text = "Usuario";
            // 
            // txtClave
            // 
            txtClave.Location = new Point(242, 256);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(163, 23);
            txtClave.TabIndex = 23;
            txtClave.Text = "Clave";
            // 
            // salir
            // 
            salir.BackColor = Color.DarkSlateGray;
            salir.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            salir.ForeColor = SystemColors.ButtonHighlight;
            salir.Location = new Point(341, 387);
            salir.Margin = new Padding(0);
            salir.Name = "salir";
            salir.Size = new Size(86, 37);
            salir.TabIndex = 31;
            salir.Text = "Salir";
            salir.UseVisualStyleBackColor = false;
            salir.Click += salir_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.DarkSlateGray;
            btnActualizar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnActualizar.ForeColor = SystemColors.ButtonFace;
            btnActualizar.Location = new Point(242, 387);
            btnActualizar.Margin = new Padding(0);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(82, 37);
            btnActualizar.TabIndex = 30;
            btnActualizar.Text = "Actualizar ";
            btnActualizar.UseVisualStyleBackColor = false;
            // 
            // frmAdminSeguridad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 450);
            Controls.Add(salir);
            Controls.Add(btnActualizar);
            Controls.Add(txtClave);
            Controls.Add(txtUsuario);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(label2);
            Name = "frmAdminSeguridad";
            Text = "frmAdminSeguridad";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private ComboBox comboBox1;
        private TextBox txtUsuario;
        private TextBox txtClave;
        private Button salir;
        private Button btnActualizar;
    }
}