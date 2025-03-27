namespace Desafio01
{
    partial class FormAddPaciente
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtNombre = new TextBox();
            cmbGenero = new ComboBox();
            cmbSangre = new ComboBox();
            cmbPresion = new ComboBox();
            btnRegresar = new Button();
            btnRegistrar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(210, 89);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(210, 147);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 1;
            label2.Text = "Genero:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(210, 208);
            label3.Name = "label3";
            label3.Size = new Size(111, 20);
            label3.TabIndex = 2;
            label3.Text = "Tipo de sangre:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(210, 266);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 3;
            label4.Text = "Presión:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(356, 86);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(214, 27);
            txtNombre.TabIndex = 4;
            txtNombre.KeyPress += txtSoloLetras_KeyPress;
            // 
            // cmbGenero
            // 
            cmbGenero.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGenero.FormattingEnabled = true;
            cmbGenero.Items.AddRange(new object[] { "Hombre", "Mujer" });
            cmbGenero.Location = new Point(356, 139);
            cmbGenero.Name = "cmbGenero";
            cmbGenero.Size = new Size(214, 28);
            cmbGenero.TabIndex = 5;
            // 
            // cmbSangre
            // 
            cmbSangre.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSangre.FormattingEnabled = true;
            cmbSangre.Items.AddRange(new object[] { "A", "B", "AB", "O" });
            cmbSangre.Location = new Point(356, 200);
            cmbSangre.Name = "cmbSangre";
            cmbSangre.Size = new Size(214, 28);
            cmbSangre.TabIndex = 6;
            // 
            // cmbPresion
            // 
            cmbPresion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPresion.FormattingEnabled = true;
            cmbPresion.Items.AddRange(new object[] { "Alta", "Media", "Baja" });
            cmbPresion.Location = new Point(356, 258);
            cmbPresion.Name = "cmbPresion";
            cmbPresion.Size = new Size(214, 28);
            cmbPresion.TabIndex = 7;
            // 
            // btnRegresar
            // 
            btnRegresar.BackColor = Color.LightSkyBlue;
            btnRegresar.Cursor = Cursors.Hand;
            btnRegresar.Location = new Point(210, 324);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(94, 29);
            btnRegresar.TabIndex = 8;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = false;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.DeepSkyBlue;
            btnRegistrar.Cursor = Cursors.Hand;
            btnRegistrar.Location = new Point(476, 324);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(94, 29);
            btnRegistrar.TabIndex = 9;
            btnRegistrar.Text = "Registrar paciente";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // FormAddPaciente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRegistrar);
            Controls.Add(btnRegresar);
            Controls.Add(cmbPresion);
            Controls.Add(cmbSangre);
            Controls.Add(cmbGenero);
            Controls.Add(txtNombre);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormAddPaciente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Añadir Paciente";
            FormClosed += FormAddPaciente_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNombre;
        private ComboBox cmbGenero;
        private ComboBox cmbSangre;
        private ComboBox cmbPresion;
        private Button btnRegresar;
        private Button btnRegistrar;
    }
}