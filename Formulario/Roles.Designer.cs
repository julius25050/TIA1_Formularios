namespace Formulario
{
    partial class Roles
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
            label3 = new Label();
            textBox1 = new TextBox();
            salir = new Button();
            btnActualizar = new Button();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(263, 9);
            label2.Name = "label2";
            label2.Size = new Size(194, 25);
            label2.TabIndex = 19;
            label2.Text = "ROL DE EMPLEADOS";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(253, 90);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 20;
            label1.Text = "Nombre rol";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(253, 131);
            label3.Name = "label3";
            label3.Size = new Size(137, 15);
            label3.TabIndex = 21;
            label3.Text = "Descripcion detallada rol";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(327, 87);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 22;
            // 
            // salir
            // 
            salir.BackColor = Color.DarkSlateGray;
            salir.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            salir.ForeColor = SystemColors.ButtonHighlight;
            salir.Location = new Point(403, 229);
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
            btnActualizar.Location = new Point(296, 229);
            btnActualizar.Margin = new Padding(0);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(82, 37);
            btnActualizar.TabIndex = 30;
            btnActualizar.Text = "Actualizar ";
            btnActualizar.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(253, 149);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(255, 60);
            textBox2.TabIndex = 32;
            // 
            // Roles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 305);
            Controls.Add(textBox2);
            Controls.Add(salir);
            Controls.Add(btnActualizar);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Name = "Roles";
            Text = "Roles";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Label label3;
        private TextBox textBox1;
        private Button salir;
        private Button btnActualizar;
        private TextBox textBox2;
    }
}