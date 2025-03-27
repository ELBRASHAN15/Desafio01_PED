using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio01
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
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

        private void button3_Click(object sender, EventArgs e)
        {
            FormLogin formlogin = new FormLogin();
            formlogin.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAddPaciente formpaciente = new FormAddPaciente(this);
            formpaciente.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListadoPacientes formlistado = new ListadoPacientes(this);
            formlistado.Show();
            this.Hide();
        }

        private void FormMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
