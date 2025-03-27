using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.Logging;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using static Desafio01.Arbol;

namespace Desafio01
{
    public partial class ListadoPacientes : Form
    {

        private FormMenu formMenu;
        public ListadoPacientes(FormMenu menu)
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string genero = cmbGenero.SelectedItem?.ToString();
            string tipoSangre = cmbSangre.SelectedItem?.ToString();
            string presion = cmbPresion.SelectedItem?.ToString();

            // Si ningún filtro ha sido seleccionado, mostramos un mensaje
            if (string.IsNullOrEmpty(genero) && string.IsNullOrEmpty(tipoSangre) && string.IsNullOrEmpty(presion))
            {
                MessageBox.Show("Por favor, selecciona al menos un filtro.");
                return;
            }

           
            // Obtener pacientes con los filtros seleccionados (pueden ser uno, dos o tres)
            List<string> pacientes = GestorPacientes.Arbol.ObtenerPacientes(genero, tipoSangre, presion);

            lstPacientes.Items.Clear();

            if (pacientes.Count > 0)
            {
                lstPacientes.Items.AddRange(pacientes.ToArray());
            }
            else
            {
                MessageBox.Show("No se encontraron pacientes con los criterios seleccionados.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            switch (tipoSangre)
            {
                case "A":
                    txtPorcentajes.Text = "";
                    txtPorcentajes.Text = "En El Salvador un estimado de personas que poseen sangre tipo A es de el 23%";
                    break;
                case "B":
                    txtPorcentajes.Text = "";
                    txtPorcentajes.Text = "En El Salvador un estimado de personas que poseen sangre tipo B es de el 11.70%";
                    break;
                case "AB":
                    txtPorcentajes.Text = "";
                    txtPorcentajes.Text = "En El Salvador un estimado de personas que poseen sangre tipo AB es de el 1.30%";
                    break;
                case "O":
                    txtPorcentajes.Text = "";
                    txtPorcentajes.Text = "En El Salvador un estimado de personas que poseen sangre tipo O es de el 63%";
                    break;
                default:
                    txtPorcentajes.Text = "";
                    txtPorcentajes.Text = "Por favor Seleccione un tipo de sangre";
                    break;
            }

        }

        private void btnVista_Click(object sender, EventArgs e)
        {
            VistaDatosArbol vistaDatosArbol = new VistaDatosArbol(formMenu);
            vistaDatosArbol.Show();
            this.Hide();
        }

        private void ListadoPacientes_FormClosed(object sender, FormClosedEventArgs e)
        {
            formMenu.Show();
        }

        private void btnCaracteristicas_Click(object sender, EventArgs e)
        {
            string genero = cmbGenero.SelectedItem?.ToString();
            string tipoSangre = cmbSangre.SelectedItem?.ToString();
            string presion = cmbPresion.SelectedItem?.ToString();
            string caracteristicas = genero + " - " + tipoSangre + " - " + presion;
            bool ninguncaso = false;
            string mensaje = "";
            switch (caracteristicas)
            {
                //Combinaciones con los hombres
                case "Hombre - A - Alta":
                    mensaje = $"Los pacientes con género {genero}, tipo de sangre {tipoSangre} y presión {presion} tienen mayor riesgo de problemas cardiovasculares, trombosis y enfermedades renales. Se recomienda control médico regular.";
                    break;
                case "Hombre - A - Media":
                    mensaje = $"Los pacientes con género {genero}, tipo de sangre {tipoSangre} y presión {presion} tienen un riesgo moderado de enfermedades cardiovasculares y coagulación. Se recomienda mantener un estilo de vida saludable.";
                    break;
                case "Hombre - A - Baja":
                    mensaje = $"Los pacientes con género {genero}, tipo de sangre {tipoSangre} y presión {presion} pueden experimentar fatiga, mareos y menor oxigenación cerebral. Se recomienda mantenerse hidratado y consultar al médico si algún sintoma se presenta.";
                    break;
                case "Hombre - B - Alta":
                    mensaje = $"Los pacientes con género {genero}, tipo de sangre {tipoSangre} y presión {presion} tienen mayor riesgo de hipertensión, problemas cardíacos y accidentes cerebrovasculares. Se recomienda control médico y hábitos saludables.";
                    break;
                case "Hombre - B Media":
                    mensaje = $"Los pacientes con género {genero}, tipo de sangre {tipoSangre} y presión {presion} tienen un equilibrio en su circulación, pero deben mantener una alimentación saludable y ejercicio para prevenir futuros problemas.";
                    break;
                case "Hombre - B - Baja":
                    mensaje = $"Los pacientes con género {genero}, tipo de sangre {tipoSangre} y presión {presion} pueden experimentar fatiga y mareos. Se recomienda una hidratación adecuada y chequeos médicos si sintomas surgen.";
                    break;
                case "Hombre - AB - Alta":
                    mensaje = $"Los pacientes con género {genero}, tipo de sangre {tipoSangre} y presión {presion} tienen mayor riesgo de hipertensión, enfermedades cardiovasculares y coágulos. Se recomienda monitoreo médico y hábitos saludables.";
                    break;
                case "Hombre - AB - Media":
                    mensaje = $"Los pacientes con género {genero}, tipo de sangre {tipoSangre} y presión {presion} tienen buena circulación, pero deben mantener una dieta balanceada y actividad física para prevenir problemas futuros.";
                    break;
                case "Hombre - AB - Baja":
                    mensaje = $"Los pacientes con género {genero}, tipo de sangre {tipoSangre} y presión {presion} pueden experimentar debilidad y mala circulación. Se recomienda una hidratación adecuada y chequeos médicos regulares.";
                    break;
                case "Hombre - O - Alta":
                    mensaje = $"Los pacientes con género {genero}, tipo de sangre {tipoSangre} y presión {presion} tienen mayor riesgo de hipertensión y problemas cardíacos. Se recomienda control médico y un estilo de vida saludable.";
                    break;
                case "Hombre - O - Media":
                    mensaje = $"Los pacientes con género {genero}, tipo de sangre {tipoSangre} y presión {presion} tienen buena circulación, pero deben mantener una alimentación equilibrada y ejercicio regular para una salud óptima.";
                    break;
                case "Hombre - O - Baja":
                    mensaje = $"Los pacientes con género {genero}, tipo de sangre {tipoSangre} y presión {presion} pueden presentar fatiga y mareos. Se recomienda una hidratación adecuada y monitoreo médico si los síntomas persisten.";
                    break;
                //Combinaciones con las mujeres
                case "Mujer - A - Alta":
                    mensaje = $"Las pacientes con género {genero}, tipo de sangre {tipoSangre} y presión {presion} tienen mayor riesgo de hipertensión, problemas cardiovasculares y coágulos. Se recomienda monitoreo médico y hábitos saludables.";
                    break;
                case "Mujer - A - Media":
                    mensaje = $"Las pacientes con género {genero}, tipo de sangre {tipoSangre} y presión {presion} tienen buena circulación, pero deben mantener una dieta equilibrada y ejercicio para prevenir futuros problemas.";
                    break;
                case "Mujer - A - Baja":
                    mensaje = $"Las pacientes con género {genero}, tipo de sangre {tipoSangre} y presión {presion} pueden experimentar mareos y fatiga. Se recomienda una hidratación adecuada y control médico si los síntomas son recurrentes.";
                    break;
                case "Mujer - B - Alta":
                    mensaje = $"Las pacientes con género {genero}, tipo de sangre {tipoSangre} y presión {presion} tienen mayor riesgo de hipertensión, enfermedades del corazón y mala circulación. Se recomienda chequeo médico regular.";
                    break;
                case "Mujer - B - Media":
                    mensaje = $"Las pacientes con género {genero}, tipo de sangre {tipoSangre} y presión {presion} tienen una circulación estable, pero deben seguir una alimentación saludable y actividad física.";
                    break;
                case "Mujer - B - Baja":
                    mensaje = $"Las pacientes con género {genero}, tipo de sangre {tipoSangre} y presión {presion} pueden sentir debilidad y mareos. Se recomienda hidratación adecuada y descanso suficiente.";
                    break;
                case "Mujer - AB - Alta":
                    mensaje = $"Las pacientes con género {genero}, tipo de sangre {tipoSangre} y presión {presion} tienen mayor riesgo de coágulos y problemas cardiovasculares. Se recomienda control médico y un estilo de vida saludable.";
                    break;
                case "Mujer - AB - Media":
                    mensaje = $"Las pacientes con género {genero}, tipo de sangre {tipoSangre} y presión {presion} tienen una circulación adecuada, pero deben mantener hábitos saludables para prevenir problemas futuros.";
                    break;
                case "Mujer - AB - Baja":
                    mensaje = $"Las pacientes con género {genero}, tipo de sangre {tipoSangre} y presión {presion} pueden experimentar circulación deficiente y fatiga. Se recomienda hidratación y chequeos médicos periódicos.";
                    break;
                case "Mujer - O - Alta":
                    mensaje = $"Las pacientes con género {genero}, tipo de sangre {tipoSangre} y presión {presion} tienen mayor riesgo de hipertensión y enfermedades cardíacas. Se recomienda control médico y reducción del estrés.";
                    break;
                case "Mujer - O - Media":
                    mensaje = $"Las pacientes con género {genero}, tipo de sangre {tipoSangre} y presión {presion} tienen buena circulación, pero deben mantener una alimentación balanceada y actividad física.";
                    break;
                case "Mujer - O - Baja":
                    mensaje = $"Las pacientes con género {genero}, tipo de sangre {tipoSangre} y presión {presion} pueden presentar fatiga y presión inestable. Se recomienda una hidratación constante y control médico si es necesario.";
                    break;
                default:
                    ninguncaso = true;
                    MessageBox.Show("Por favor, seleccione todas las características.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;

            }
            if (!ninguncaso)
            {
                MessageBox.Show(mensaje, "Estado del Paciente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
