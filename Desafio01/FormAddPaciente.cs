using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Desafio01.Arbol;

namespace Desafio01
{
    public partial class FormAddPaciente : Form
    {
         

        private FormMenu formMenu;
        public FormAddPaciente(FormMenu menu)
        {
            InitializeComponent();
            this.formMenu = menu;  // Guardamos la referencia del FormMenu original
            AplicarEstilos();
        }

        private void AplicarEstilos()
        {
            // Definir colores
            Color colorFondo = Color.FromArgb(230, 230, 250); // Morado claro
            Color colorContraste = Color.FromArgb(75, 0, 130); // Morado oscuro
            Font fuenteEstilizada = new Font("Segoe UI", 10, FontStyle.Bold);

            // Aplicar colores y fuentes al formulario
            this.BackColor = colorFondo;
            this.Font = fuenteEstilizada;

            // Aplicar colores y fuentes a los controles
            foreach (Control control in this.Controls)
            {
                if (control is System.Windows.Forms.Button)
                {
                    control.BackColor = colorContraste;
                    control.ForeColor = Color.White;
                    control.Font = fuenteEstilizada;
                }
                else if (control is Label || control is System.Windows.Forms.TextBox || control is System.Windows.Forms.ComboBox || control is ListBox)
                {
                    control.BackColor = colorFondo;
                    control.ForeColor = colorContraste;
                    control.Font = fuenteEstilizada;
                }
            }
        }

        private void FormAddPaciente_FormClosed(object sender, FormClosedEventArgs e)
        {
            formMenu.Show();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            formMenu.Show();
            this.Close();
        }

        private void txtSoloLetras_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Expresión regular que permite solo letras y vocales con tilde
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), @"^[a-zA-ZáéíóúÁÉÍÓÚ\s\b]$"))
            {
                e.Handled = true; // Cancela la entrada de caracteres no permitidos
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string genero = cmbGenero.Text;
            string tiposangre = cmbSangre.Text;
            string presion = cmbPresion.Text;

            if (nombre == "" || genero == "" || tiposangre == "" || presion == "")
            {
                MessageBox.Show("Todos los campos son obligatorios, por favor verifique", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Paciente nuevoPaciente = new Paciente(nombre, genero, tiposangre, presion);
            GestorPacientes.Arbol.AgregarPaciente(nuevoPaciente);

            MessageBox.Show("Paciente agregado correctamente.");
        }
    }
}
