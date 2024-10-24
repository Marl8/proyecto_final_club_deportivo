namespace proyecto_final_club_deportivo.GUI
{
    partial class EditarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarUsuario));
            lblUsuario = new Label();
            pictureBox10 = new PictureBox();
            label1 = new Label();
            btnLimpiar = new Button();
            btnEditar = new Button();
            btnVolver = new Button();
            label10 = new Label();
            pictureBox7 = new PictureBox();
            pictureBox8 = new PictureBox();
            label8 = new Label();
            label9 = new Label();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtTelefono = new TextBox();
            txtEmail = new TextBox();
            txtDni = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            pictureBox9 = new PictureBox();
            cmbRol = new ComboBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.BackColor = Color.FromArgb(53, 47, 80);
            lblUsuario.ForeColor = Color.Snow;
            lblUsuario.Location = new Point(351, 9);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(0, 15);
            lblUsuario.TabIndex = 11;
            // 
            // pictureBox10
            // 
            pictureBox10.BackColor = Color.FromArgb(53, 47, 80);
            pictureBox10.Location = new Point(-1, 0);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(590, 51);
            pictureBox10.TabIndex = 70;
            pictureBox10.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkSlateBlue;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(197, 71);
            label1.Name = "label1";
            label1.Size = new Size(210, 32);
            label1.TabIndex = 71;
            label1.Text = "EDITAR USUARIO";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimpiar.Image = Properties.Resources.limpiar;
            btnLimpiar.ImageAlign = ContentAlignment.BottomLeft;
            btnLimpiar.Location = new Point(83, 437);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(126, 42);
            btnLimpiar.TabIndex = 133;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.TextAlign = ContentAlignment.MiddleRight;
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditar.Image = (Image)resources.GetObject("btnEditar.Image");
            btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditar.Location = new Point(244, 437);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(123, 42);
            btnEditar.TabIndex = 132;
            btnEditar.Text = "EDITAR";
            btnEditar.TextAlign = ContentAlignment.MiddleRight;
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            btnEditar.Enter += txPassword_Enter;
            btnEditar.Leave += txtPassword_Leave;
            // 
            // btnVolver
            // 
            btnVolver.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolver.Image = Properties.Resources.volver;
            btnVolver.ImageAlign = ContentAlignment.MiddleLeft;
            btnVolver.Location = new Point(399, 437);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(113, 42);
            btnVolver.TabIndex = 131;
            btnVolver.Text = "VOLVER";
            btnVolver.TextAlign = ContentAlignment.MiddleRight;
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.Snow;
            label10.Location = new Point(337, 342);
            label10.Name = "label10";
            label10.Size = new Size(30, 17);
            label10.TabIndex = 130;
            label10.Text = "Rol:";
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.asterisk1;
            pictureBox7.Location = new Point(275, 281);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(15, 18);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 128;
            pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Properties.Resources.asterisk1;
            pictureBox8.Location = new Point(554, 281);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(15, 18);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 127;
            pictureBox8.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Snow;
            label8.Location = new Point(302, 277);
            label8.Name = "label8";
            label8.Size = new Size(67, 17);
            label8.TabIndex = 126;
            label8.Text = "Password:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.Snow;
            label9.Location = new Point(33, 277);
            label9.Name = "label9";
            label9.Size = new Size(70, 17);
            label9.TabIndex = 125;
            label9.Text = "Username:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(370, 276);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(178, 23);
            txtPassword.TabIndex = 124;
            txtPassword.Text = "Password";
            txtPassword.Enter += txPassword_Enter;
            txtPassword.Leave += txtPassword_Leave;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(104, 276);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(165, 23);
            txtUsername.TabIndex = 123;
            txtUsername.Text = "Username";
            txtUsername.Enter += textUsername_Enter;
            txtUsername.Leave += txtUsername_Leave;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.asterisk1;
            pictureBox6.Location = new Point(275, 153);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(15, 18);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 122;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.asterisk1;
            pictureBox5.Location = new Point(275, 219);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(15, 18);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 121;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.asterisk1;
            pictureBox4.Location = new Point(275, 342);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(15, 18);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 120;
            pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.asterisk1;
            pictureBox2.Location = new Point(554, 215);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(15, 18);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 118;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.asterisk1;
            pictureBox1.Location = new Point(554, 153);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(15, 18);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 117;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Snow;
            label6.Location = new Point(37, 338);
            label6.Name = "label6";
            label6.Size = new Size(61, 17);
            label6.TabIndex = 115;
            label6.Text = "Telefono:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Snow;
            label5.Location = new Point(327, 216);
            label5.Name = "label5";
            label5.Size = new Size(42, 17);
            label5.TabIndex = 114;
            label5.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Snow;
            label4.Location = new Point(73, 215);
            label4.Name = "label4";
            label4.Size = new Size(30, 17);
            label4.TabIndex = 113;
            label4.Text = "Dni:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Snow;
            label3.Location = new Point(310, 150);
            label3.Name = "label3";
            label3.Size = new Size(59, 17);
            label3.TabIndex = 112;
            label3.Text = "Apellido:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Snow;
            label2.Location = new Point(43, 152);
            label2.Name = "label2";
            label2.Size = new Size(60, 17);
            label2.TabIndex = 111;
            label2.Text = "Nombre:";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(104, 337);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(165, 23);
            txtTelefono.TabIndex = 109;
            txtTelefono.Text = "Telefono";
            txtTelefono.Enter += txtTelefono_Enter;
            txtTelefono.Leave += txtTelefono_Leave;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(370, 214);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(178, 23);
            txtEmail.TabIndex = 108;
            txtEmail.Text = "Email";
            txtEmail.Enter += txtEmail_Enter;
            txtEmail.Leave += txtEmail_Leave;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(104, 213);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(165, 23);
            txtDni.TabIndex = 107;
            txtDni.Text = "DNI";
            txtDni.Enter += txtDni_Enter;
            txtDni.Leave += txtDni_Leave;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(370, 148);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(178, 23);
            txtApellido.TabIndex = 106;
            txtApellido.Text = "Apellido";
            txtApellido.Enter += txtApellido_Enter;
            txtApellido.Leave += txtApellido_Leave;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(104, 148);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(165, 23);
            txtNombre.TabIndex = 105;
            txtNombre.Text = "Nombre";
            txtNombre.Enter += txtNombre_Enter;
            txtNombre.Leave += txtNombre_Leave;
            // 
            // pictureBox9
            // 
            pictureBox9.BackColor = Color.FromArgb(53, 47, 80);
            pictureBox9.Location = new Point(-4, 405);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(593, 105);
            pictureBox9.TabIndex = 135;
            pictureBox9.TabStop = false;
            // 
            // cmbRol
            // 
            cmbRol.FormattingEnabled = true;
            cmbRol.Items.AddRange(new object[] { "Administrador", "Empleado" });
            cmbRol.Location = new Point(373, 339);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(121, 23);
            cmbRol.TabIndex = 136;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.asterisk1;
            pictureBox3.Location = new Point(497, 342);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(15, 18);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 137;
            pictureBox3.TabStop = false;
            // 
            // EditarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateBlue;
            ClientSize = new Size(588, 506);
            Controls.Add(pictureBox3);
            Controls.Add(cmbRol);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEditar);
            Controls.Add(btnVolver);
            Controls.Add(label10);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox8);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtTelefono);
            Controls.Add(txtEmail);
            Controls.Add(txtDni);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(pictureBox9);
            Controls.Add(label1);
            Controls.Add(lblUsuario);
            Controls.Add(pictureBox10);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EditarUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar Usuario";
            Load += EditarUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsuario;
        private PictureBox pictureBox10;
        private Label label1;
        private Button btnLimpiar;
        private Button btnEditar;
        private Button btnVolver;
        private Label label10;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private Label label8;
        private Label label9;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtTelefono;
        private TextBox txtEmail;
        private TextBox txtDni;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private PictureBox pictureBox9;
        private ComboBox cmbRol;
        private PictureBox pictureBox3;
    }
}