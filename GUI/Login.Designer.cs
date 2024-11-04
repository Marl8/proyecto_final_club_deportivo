namespace proyecto_final_club_deportivo
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnIngresar = new Button();
            pictureInicio = new PictureBox();
            lblTitulo = new Label();
            panelLogin = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureInicio).BeginInit();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(251, 113);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(188, 23);
            txtUsername.TabIndex = 3;
            txtUsername.Text = "USUARIO";
            txtUsername.Enter += txtUsername_Enter;
            txtUsername.Leave += txtUsername_Leave;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(251, 183);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(188, 23);
            txtPassword.TabIndex = 4;
            txtPassword.Text = "CONTRASEÑA";
            txtPassword.Enter += txtPassword_Enter;
            txtPassword.Leave += txtPassword_Leave;
            // 
            // btnIngresar
            // 
            btnIngresar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnIngresar.Location = new Point(263, 243);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(159, 44);
            btnIngresar.TabIndex = 5;
            btnIngresar.Text = "INGRESAR";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            btnIngresar.MouseLeave += btnIngresar_MouseLeave;
            btnIngresar.MouseMove += btnIngresar_MouseMove;
            // 
            // pictureInicio
            // 
            pictureInicio.Image = Properties.Resources.login2;
            pictureInicio.InitialImage = (Image)resources.GetObject("pictureInicio.InitialImage");
            pictureInicio.Location = new Point(34, 84);
            pictureInicio.Name = "pictureInicio";
            pictureInicio.Size = new Size(211, 167);
            pictureInicio.SizeMode = PictureBoxSizeMode.Zoom;
            pictureInicio.TabIndex = 6;
            pictureInicio.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.Snow;
            lblTitulo.Location = new Point(137, 30);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(226, 40);
            lblTitulo.TabIndex = 7;
            lblTitulo.Text = "Club Deportivo";
            // 
            // panelLogin
            // 
            panelLogin.Location = new Point(1, -1);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(489, 351);
            panelLogin.TabIndex = 10;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateBlue;
            ClientSize = new Size(487, 347);
            Controls.Add(pictureInicio);
            Controls.Add(lblTitulo);
            Controls.Add(btnIngresar);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(panelLogin);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureInicio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnIngresar;
        private PictureBox pictureInicio;
        private Label lblTitulo;
        private Panel panelLogin;
    }
}
