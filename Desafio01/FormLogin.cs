namespace Desafio01
{
    public partial class FormLogin : Form
    {

        private string usuario = "admin";
        private string contraseña = "admin";
        public FormLogin()
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtuser.Text == usuario && txtpassword.Text == contraseña)
            {
                FormMenu formmenu = new FormMenu();
                formmenu.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Error en las credenciales, verifique", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
