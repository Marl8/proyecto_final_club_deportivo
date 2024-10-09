namespace proyecto_final_club_deportivo
{
    partial class InscribirSocio
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
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtDni = new TextBox();
            txtEmail = new TextBox();
            txtTelefono = new TextBox();
            cmbEstado = new ComboBox();
            btnVolver = new Button();
            btnInscribir = new Button();
            lblUsuario = new Label();
            btnLimpiar = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox8 = new PictureBox();
            label8 = new Label();
            cmbAptoFisico = new ComboBox();
            pictureBox9 = new PictureBox();
            pictureBox10 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(53, 47, 80);
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(515, 40);
            label1.Name = "label1";
            label1.Size = new Size(211, 32);
            label1.TabIndex = 0;
            label1.Text = "INSCRIBIR SOCIO";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(405, 141);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(165, 23);
            txtNombre.TabIndex = 1;
            txtNombre.Text = "Nombre";
            txtNombre.Enter += txtNombre_Enter;
            txtNombre.Leave += txtNombre_Leave;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(669, 140);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(178, 23);
            txtApellido.TabIndex = 2;
            txtApellido.Text = "Apellido";
            txtApellido.Enter += txtApellido_Enter;
            txtApellido.Leave += txtApellido_Leave;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(405, 206);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(165, 23);
            txtDni.TabIndex = 3;
            txtDni.Text = "DNI";
            txtDni.Enter += txtDni_Enter;
            txtDni.Leave += txtDni_Leave;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(669, 206);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(178, 23);
            txtEmail.TabIndex = 4;
            txtEmail.Text = "Email";
            txtEmail.Enter += txtEmail_Enter;
            txtEmail.Leave += txtEmail_Leave;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(540, 262);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(165, 23);
            txtTelefono.TabIndex = 5;
            txtTelefono.Text = "Telefono";
            txtTelefono.Enter += txtTelefono_Enter;
            txtTelefono.Leave += txtTelefono_Leave;
            // 
            // cmbEstado
            // 
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Items.AddRange(new object[] { "Activo", "Inactivo" });
            cmbEstado.Location = new Point(684, 314);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(99, 23);
            cmbEstado.TabIndex = 6;
            // 
            // btnVolver
            // 
            btnVolver.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolver.Image = Properties.Resources.volver;
            btnVolver.ImageAlign = ContentAlignment.MiddleLeft;
            btnVolver.Location = new Point(711, 393);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(113, 42);
            btnVolver.TabIndex = 7;
            btnVolver.Text = "VOLVER";
            btnVolver.TextAlign = ContentAlignment.MiddleRight;
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnInscribir
            // 
            btnInscribir.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnInscribir.Location = new Point(540, 393);
            btnInscribir.Name = "btnInscribir";
            btnInscribir.Size = new Size(141, 42);
            btnInscribir.TabIndex = 8;
            btnInscribir.Text = "INSCRIBIR";
            btnInscribir.UseVisualStyleBackColor = true;
            btnInscribir.Click += btnInscribir_Click;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.BackColor = Color.FromArgb(53, 47, 80);
            lblUsuario.ForeColor = Color.Snow;
            lblUsuario.Location = new Point(656, 9);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(0, 15);
            lblUsuario.TabIndex = 9;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimpiar.Image = Properties.Resources.limpiar;
            btnLimpiar.ImageAlign = ContentAlignment.BottomLeft;
            btnLimpiar.Location = new Point(383, 393);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(126, 42);
            btnLimpiar.TabIndex = 10;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.TextAlign = ContentAlignment.MiddleRight;
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Snow;
            label2.Location = new Point(344, 145);
            label2.Name = "label2";
            label2.Size = new Size(60, 17);
            label2.TabIndex = 11;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Snow;
            label3.Location = new Point(609, 142);
            label3.Name = "label3";
            label3.Size = new Size(59, 17);
            label3.TabIndex = 12;
            label3.Text = "Apellido:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Snow;
            label4.Location = new Point(374, 208);
            label4.Name = "label4";
            label4.Size = new Size(30, 17);
            label4.TabIndex = 13;
            label4.Text = "Dni:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Snow;
            label5.Location = new Point(626, 208);
            label5.Name = "label5";
            label5.Size = new Size(42, 17);
            label5.TabIndex = 14;
            label5.Text = "Email:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Snow;
            label6.Location = new Point(473, 263);
            label6.Name = "label6";
            label6.Size = new Size(61, 17);
            label6.TabIndex = 15;
            label6.Text = "Telefono:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Snow;
            label7.Location = new Point(632, 315);
            label7.Name = "label7";
            label7.Size = new Size(51, 17);
            label7.TabIndex = 16;
            label7.Text = "Estado:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.asterisk1;
            pictureBox1.Location = new Point(853, 145);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(15, 18);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.asterisk1;
            pictureBox2.Location = new Point(853, 207);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(15, 18);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.asterisk1;
            pictureBox3.Location = new Point(789, 315);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(15, 18);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 19;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.asterisk1;
            pictureBox4.Location = new Point(711, 267);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(15, 18);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 20;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.asterisk1;
            pictureBox5.Location = new Point(576, 212);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(15, 18);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 21;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.asterisk1;
            pictureBox6.Location = new Point(576, 146);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(15, 18);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 22;
            pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.clubDeportivo2;
            pictureBox7.Location = new Point(0, 0);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(334, 476);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 23;
            pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Properties.Resources.asterisk1;
            pictureBox8.Location = new Point(588, 315);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(15, 18);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 66;
            pictureBox8.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Snow;
            label8.Location = new Point(403, 316);
            label8.Name = "label8";
            label8.Size = new Size(75, 17);
            label8.TabIndex = 65;
            label8.Text = "Apto Físico:";
            // 
            // cmbAptoFisico
            // 
            cmbAptoFisico.FormattingEnabled = true;
            cmbAptoFisico.Items.AddRange(new object[] { "Si", "No" });
            cmbAptoFisico.Location = new Point(484, 314);
            cmbAptoFisico.Name = "cmbAptoFisico";
            cmbAptoFisico.Size = new Size(98, 23);
            cmbAptoFisico.TabIndex = 64;
            // 
            // pictureBox9
            // 
            pictureBox9.BackColor = Color.FromArgb(53, 47, 80);
            pictureBox9.Location = new Point(333, 371);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(549, 105);
            pictureBox9.TabIndex = 67;
            pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            pictureBox10.BackColor = Color.FromArgb(53, 47, 80);
            pictureBox10.Location = new Point(333, 0);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(549, 95);
            pictureBox10.TabIndex = 68;
            pictureBox10.TabStop = false;
            // 
            // InscribirSocio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateBlue;
            ClientSize = new Size(881, 475);
            Controls.Add(pictureBox8);
            Controls.Add(label8);
            Controls.Add(cmbAptoFisico);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnLimpiar);
            Controls.Add(lblUsuario);
            Controls.Add(btnInscribir);
            Controls.Add(btnVolver);
            Controls.Add(cmbEstado);
            Controls.Add(txtTelefono);
            Controls.Add(txtEmail);
            Controls.Add(txtDni);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Controls.Add(pictureBox9);
            Controls.Add(pictureBox10);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "InscribirSocio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InscribirSocio";
            Load += RegistrarSocio_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtDni;
        private TextBox txtEmail;
        private TextBox txtTelefono;
        private ComboBox cmbEstado;
        private Button btnVolver;
        private Button btnInscribir;
        private Label lblUsuario;
        private Button btnLimpiar;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private Label label8;
        private ComboBox cmbAptoFisico;
        private PictureBox pictureBox9;
        private PictureBox pictureBox10;
    }
}