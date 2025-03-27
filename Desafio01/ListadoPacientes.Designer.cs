namespace Desafio01
{
    partial class ListadoPacientes
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
        //update v2
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lstPacientes = new ListBox();
            btnBuscar = new Button();
            cmbPresion = new ComboBox();
            cmbSangre = new ComboBox();
            cmbGenero = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnVista = new Button();
            btnCaracteristicas = new Button();
            txtPorcentajes = new TextBox();
            SuspendLayout();
            // 
            // lstPacientes
            // 
            lstPacientes.BackColor = Color.LightCyan;
            lstPacientes.FormattingEnabled = true;
            lstPacientes.Location = new Point(12, 88);
            lstPacientes.Name = "lstPacientes";
            lstPacientes.Size = new Size(265, 244);
            lstPacientes.TabIndex = 12;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.DeepSkyBlue;
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.Location = new Point(507, 330);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(94, 45);
            btnBuscar.TabIndex = 13;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // cmbPresion
            // 
            cmbPresion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPresion.FormattingEnabled = true;
            cmbPresion.Items.AddRange(new object[] { "", "Alta", "Media", "Baja" });
            cmbPresion.Location = new Point(479, 239);
            cmbPresion.Name = "cmbPresion";
            cmbPresion.Size = new Size(214, 28);
            cmbPresion.TabIndex = 19;
            // 
            // cmbSangre
            // 
            cmbSangre.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSangre.FormattingEnabled = true;
            cmbSangre.Items.AddRange(new object[] { "", "A", "B", "AB", "O" });
            cmbSangre.Location = new Point(479, 181);
            cmbSangre.Name = "cmbSangre";
            cmbSangre.Size = new Size(214, 28);
            cmbSangre.TabIndex = 18;
            // 
            // cmbGenero
            // 
            cmbGenero.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGenero.FormattingEnabled = true;
            cmbGenero.Items.AddRange(new object[] { "", "Hombre", "Mujer" });
            cmbGenero.Location = new Point(479, 120);
            cmbGenero.Name = "cmbGenero";
            cmbGenero.Size = new Size(214, 28);
            cmbGenero.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(333, 247);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 16;
            label4.Text = "Presión:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(333, 189);
            label3.Name = "label3";
            label3.Size = new Size(111, 20);
            label3.TabIndex = 15;
            label3.Text = "Tipo de sangre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(333, 128);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 14;
            label2.Text = "Genero:";
            // 
            // btnVista
            // 
            btnVista.BackColor = Color.LightSkyBlue;
            btnVista.Cursor = Cursors.Hand;
            btnVista.Location = new Point(636, 330);
            btnVista.Name = "btnVista";
            btnVista.Size = new Size(123, 45);
            btnVista.TabIndex = 20;
            btnVista.Text = "Cambiar vista";
            btnVista.UseVisualStyleBackColor = false;
            btnVista.Click += btnVista_Click;
            // 
            // btnCaracteristicas
            // 
            btnCaracteristicas.BackColor = Color.DeepSkyBlue;
            btnCaracteristicas.Cursor = Cursors.Hand;
            btnCaracteristicas.Location = new Point(317, 330);
            btnCaracteristicas.Name = "btnCaracteristicas";
            btnCaracteristicas.Size = new Size(169, 45);
            btnCaracteristicas.TabIndex = 21;
            btnCaracteristicas.Text = "Generar caracteristicas";
            btnCaracteristicas.UseVisualStyleBackColor = false;
            btnCaracteristicas.Click += btnCaracteristicas_Click;
            // 
            // txtPorcentajes
            // 
            txtPorcentajes.BackColor = Color.LightCyan;
            txtPorcentajes.Location = new Point(12, 354);
            txtPorcentajes.Multiline = true;
            txtPorcentajes.Name = "txtPorcentajes";
            txtPorcentajes.ReadOnly = true;
            txtPorcentajes.Size = new Size(265, 73);
            txtPorcentajes.TabIndex = 23;
            txtPorcentajes.Text = " ";
            // 
            // ListadoPacientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(txtPorcentajes);
            Controls.Add(btnCaracteristicas);
            Controls.Add(btnVista);
            Controls.Add(cmbPresion);
            Controls.Add(cmbSangre);
            Controls.Add(cmbGenero);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnBuscar);
            Controls.Add(lstPacientes);
            Name = "ListadoPacientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Listado de pcientes";
            FormClosed += ListadoPacientes_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstPacientes;
        private Button btnBuscar;
        private ComboBox cmbPresion;
        private ComboBox cmbSangre;
        private ComboBox cmbGenero;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnVista;
        private Button btnCaracteristicas;
        private ListBox lstPorcentajes;
        private TextBox txtPorcentajes;
    }
}