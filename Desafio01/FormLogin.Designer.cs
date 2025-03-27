namespace Desafio01
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnLogin = new Button();
            btnExit = new Button();
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtpassword = new TextBox();
            txtuser = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Plum;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.Location = new Point(151, 270);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(129, 29);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Iniciar sesión";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += button1_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Plum;
            btnExit.Cursor = Cursors.Hand;
            btnExit.Location = new Point(27, 270);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 3;
            btnExit.Text = "Salir";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtpassword);
            panel1.Controls.Add(txtuser);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(btnExit);
            panel1.Location = new Point(240, 58);
            panel1.Name = "panel1";
            panel1.Size = new Size(308, 340);
            panel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Banner", 25.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(29, 15);
            label3.Name = "label3";
            label3.Size = new Size(251, 62);
            label3.TabIndex = 1;
            label3.Text = "BIENVENIDO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 194);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 3;
            label2.Text = "Contraseña:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 128);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 2;
            label1.Text = "Usuario:";
            // 
            // txtpassword
            // 
            txtpassword.Location = new Point(133, 191);
            txtpassword.Name = "txtpassword";
            txtpassword.PasswordChar = '*';
            txtpassword.Size = new Size(158, 27);
            txtpassword.TabIndex = 1;
            // 
            // txtuser
            // 
            txtuser.Location = new Point(131, 121);
            txtuser.Name = "txtuser";
            txtuser.Size = new Size(158, 27);
            txtuser.TabIndex = 0;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnLogin;
        private Button btnExit;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private TextBox txtpassword;
        private TextBox txtuser;
        private Label label3;
    }
}
