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
            label1 = new Label();
            linkLabel1 = new LinkLabel();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            actualizar = new Button();
            salir = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(198, 33);
            label1.Name = "label1";
            label1.Size = new Size(303, 37);
            label1.TabIndex = 0;
            label1.Text = "Nuevo registro cliente";
            label1.Click += label1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(102, 240);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(0, 15);
            linkLabel1.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ScrollBar;
            textBox1.Location = new Point(227, 99);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(236, 23);
            textBox1.TabIndex = 7;
            textBox1.Text = "Nombre cliente";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.ScrollBar;
            textBox2.Location = new Point(227, 137);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(236, 23);
            textBox2.TabIndex = 8;
            textBox2.Text = "Documento";
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.ScrollBar;
            textBox3.Location = new Point(227, 178);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(236, 23);
            textBox3.TabIndex = 9;
            textBox3.Text = "Direccion";
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.ScrollBar;
            textBox4.Location = new Point(227, 219);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(236, 23);
            textBox4.TabIndex = 10;
            textBox4.Text = "Telefono";
            // 
            // textBox5
            // 
            textBox5.BackColor = SystemColors.ScrollBar;
            textBox5.Location = new Point(227, 261);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(236, 23);
            textBox5.TabIndex = 11;
            textBox5.Text = "Email";
            // 
            // actualizar
            // 
            actualizar.BackColor = Color.DarkSlateGray;
            actualizar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            actualizar.ForeColor = SystemColors.ButtonFace;
            actualizar.Location = new Point(172, 319);
            actualizar.Margin = new Padding(0);
            actualizar.Name = "actualizar";
            actualizar.Size = new Size(75, 37);
            actualizar.TabIndex = 12;
            actualizar.Text = "Actualizar ";
            actualizar.UseVisualStyleBackColor = false;
            // 
            // salir
            // 
            salir.BackColor = Color.DarkSlateGray;
            salir.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            salir.ForeColor = SystemColors.ButtonHighlight;
            salir.Location = new Point(482, 319);
            salir.Margin = new Padding(0);
            salir.Name = "salir";
            salir.Size = new Size(75, 37);
            salir.TabIndex = 13;
            salir.Text = "Salir";
            salir.UseVisualStyleBackColor = false;
            salir.Click += salir_Click;
            // 
            // frmClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(salir);
            Controls.Add(actualizar);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(linkLabel1);
            Controls.Add(label1);
            Name = "frmClientes";
            Text = "frmClientes";
            TransparencyKey = Color.Transparent;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private LinkLabel linkLabel1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button actualizar;
        private Button salir;
    }
}