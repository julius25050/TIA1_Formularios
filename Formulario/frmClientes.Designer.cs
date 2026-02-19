namespace Formulario
{
    partial class frmClientes
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
            linkLabel1 = new LinkLabel();
            txtNameClient = new TextBox();
            txtIdClient = new TextBox();
            txtAddressClient = new TextBox();
            txtTelClient = new TextBox();
            txtEmailClient = new TextBox();
            btnActualizar = new Button();
            salir = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(93, 29);
            label1.Name = "label1";
            label1.Size = new Size(358, 37);
            label1.TabIndex = 0;
            label1.Text = "NUEVO REGISTRO CLIENTE";
            label1.Click += label1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(23, 248);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(0, 15);
            linkLabel1.TabIndex = 6;
            // 
            // txtNameClient
            // 
            txtNameClient.BackColor = SystemColors.ScrollBar;
            txtNameClient.Location = new Point(93, 107);
            txtNameClient.Name = "txtNameClient";
            txtNameClient.Size = new Size(358, 23);
            txtNameClient.TabIndex = 7;
            txtNameClient.Text = "Nombre cliente";
            txtNameClient.TextChanged += textBox1_TextChanged;
            // 
            // txtIdClient
            // 
            txtIdClient.BackColor = SystemColors.ScrollBar;
            txtIdClient.Location = new Point(93, 146);
            txtIdClient.Name = "txtIdClient";
            txtIdClient.Size = new Size(358, 23);
            txtIdClient.TabIndex = 8;
            txtIdClient.Text = "Documento";
            // 
            // txtAddressClient
            // 
            txtAddressClient.BackColor = SystemColors.ScrollBar;
            txtAddressClient.Location = new Point(93, 187);
            txtAddressClient.Name = "txtAddressClient";
            txtAddressClient.Size = new Size(358, 23);
            txtAddressClient.TabIndex = 9;
            txtAddressClient.Text = "Direccion";
            // 
            // txtTelClient
            // 
            txtTelClient.BackColor = SystemColors.ScrollBar;
            txtTelClient.Location = new Point(93, 228);
            txtTelClient.Name = "txtTelClient";
            txtTelClient.Size = new Size(358, 23);
            txtTelClient.TabIndex = 10;
            txtTelClient.Text = "Telefono";
            // 
            // txtEmailClient
            // 
            txtEmailClient.BackColor = SystemColors.ScrollBar;
            txtEmailClient.Location = new Point(93, 270);
            txtEmailClient.Name = "txtEmailClient";
            txtEmailClient.Size = new Size(358, 23);
            txtEmailClient.TabIndex = 11;
            txtEmailClient.Text = "Email";
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.DarkSlateGray;
            btnActualizar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnActualizar.ForeColor = SystemColors.ButtonFace;
            btnActualizar.Location = new Point(93, 327);
            btnActualizar.Margin = new Padding(0);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(82, 37);
            btnActualizar.TabIndex = 12;
            btnActualizar.Text = "Actualizar ";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // salir
            // 
            salir.BackColor = Color.DarkSlateGray;
            salir.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            salir.ForeColor = SystemColors.ButtonHighlight;
            salir.Location = new Point(365, 327);
            salir.Margin = new Padding(0);
            salir.Name = "salir";
            salir.Size = new Size(86, 37);
            salir.TabIndex = 13;
            salir.Text = "Salir";
            salir.UseVisualStyleBackColor = false;
            salir.Click += salir_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(545, 437);
            Controls.Add(salir);
            Controls.Add(btnActualizar);
            Controls.Add(txtEmailClient);
            Controls.Add(txtTelClient);
            Controls.Add(txtAddressClient);
            Controls.Add(txtIdClient);
            Controls.Add(txtNameClient);
            Controls.Add(linkLabel1);
            Controls.Add(label1);
            Name = "frmClientes";
            Text = "frmClientes";
            TransparencyKey = Color.Transparent;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private LinkLabel linkLabel1;
        private TextBox txtNameClient;
        private TextBox txtIdClient;
        private TextBox txtAddressClient;
        private TextBox txtTelClient;
        private TextBox txtEmailClient;
        private Button btnActualizar;
        private Button salir;
        private ErrorProvider errorProvider1;
    }
}