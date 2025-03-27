using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static Desafio01.Arbol;


namespace Desafio01
{
    public partial class VistaDatosArbol : Form
    {
        private FormMenu formMenu;

        public VistaDatosArbol(FormMenu menu)
        {
            this.formMenu = menu;  // Guardamos la referencia del FormMenu original
            InitializeComponent();
            AplicarEstilos();
            CargarDatosEnTreeView();
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

        private void CargarDatosEnTreeView()
        {
            treeView1.Nodes.Clear();
            TreeNode rootNode = new TreeNode("Árbol de Pacientes");

            // 1️⃣ Agregar Género con nodos fijos
            TreeNode generoNode = new TreeNode("Género");
            string[] generosFijos = { "Hombre", "Mujer" };

            foreach (string genero in generosFijos)
            {
                TreeNode nodoGenero = new TreeNode(genero);

                // Agregar pacientes si existen en la categoría
                if (GestorPacientes.Arbol.Genero.ContainsKey(genero))
                {
                    foreach (var paciente in GestorPacientes.Arbol.Genero[genero])
                    {
                        nodoGenero.Nodes.Add(new TreeNode(paciente));
                    }
                }
                generoNode.Nodes.Add(nodoGenero);
            }
            rootNode.Nodes.Add(generoNode);

            // 2️⃣ Agregar Tipo de Sangre con nodos fijos
            TreeNode sangreNode = new TreeNode("Tipo de Sangre");
            string[] sangreFija = { "A", "B", "AB", "O" };

            foreach (string tipo in sangreFija)
            {
                TreeNode nodoSangre = new TreeNode(tipo);

                if (GestorPacientes.Arbol.TipoSangre.ContainsKey(tipo))
                {
                    foreach (var paciente in GestorPacientes.Arbol.TipoSangre[tipo])
                    {
                        nodoSangre.Nodes.Add(new TreeNode(paciente));
                    }
                }
                sangreNode.Nodes.Add(nodoSangre);
            }
            rootNode.Nodes.Add(sangreNode);

            // 3️⃣ Agregar Presión con nodos fijos
            TreeNode presionNode = new TreeNode("Presión");
            string[] presionFija = { "Alta", "Media", "Baja" };

            foreach (string nivel in presionFija)
            {
                TreeNode nodoPresion = new TreeNode(nivel);

                if (GestorPacientes.Arbol.Presion.ContainsKey(nivel))
                {
                    foreach (var paciente in GestorPacientes.Arbol.Presion[nivel])
                    {
                        nodoPresion.Nodes.Add(new TreeNode(paciente));
                    }
                }
                presionNode.Nodes.Add(nodoPresion);
            }
            rootNode.Nodes.Add(presionNode);

            treeView1.Nodes.Add(rootNode);
            treeView1.ExpandAll(); // Expande el árbol para mostrar todo
        }

        private void VistaDatosArbol_FormClosed(object sender, FormClosedEventArgs e)
        { 
            ListadoPacientes listadoPacientes = new ListadoPacientes(formMenu);
            listadoPacientes.Show();
        }
    }
}