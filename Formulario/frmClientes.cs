using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario
{
    public partial class frmClientes : Form
    {

        private ErrorProvider errorProvider = new ErrorProvider();
        public frmClientes()
        {
            InitializeComponent();
        }

        private bool ValidateFields()
        {
            bool isValid = true;
            string errorMessage = "El campo no puede estar vacío";

            var fields = new[]
            {
        txtNameClient,
        txtIdClient,
        txtAddressClient,
        txtTelClient,
        txtEmailClient
    };

            foreach (var field in fields)
            {
                if (string.IsNullOrWhiteSpace(field.Text))
                {
                    errorProvider.SetError(field, errorMessage);
                    isValid = false;
                }
                else
                {
                    errorProvider.SetError(field, string.Empty); // Limpia el error si ya fue corregido
                }
            }

            return isValid;
        }

        private void label1_Click(object sender, EventArgs e)
        { }




        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void salir_Click(object sender, EventArgs e)
        {
            frmPrincipal principal = new frmPrincipal();
            principal.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                // Lógica principal si todo está correcto
            }
        }
    }
}
