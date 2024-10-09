namespace proyecto_final_club_deportivo
{
    partial class InscribirActividad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InscribirActividad));
            label1 = new Label();
            lblUsuario = new Label();
            pictureBox1 = new PictureBox();
            txtNombreAct = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtDniNoSocio = new TextBox();
            buscarActividad = new Button();
            buscarNoSocio = new Button();
            label4 = new Label();
            label5 = new Label();
            txtIdNoSocio = new TextBox();
            btnVolver = new Button();
            btnLimpiar = new Button();
            btnInscribir = new Button();
            txtIdActividad = new TextBox();
            pictureBox10 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(53, 47, 80);
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(421, 34);
            label1.Name = "label1";
            label1.Size = new Size(290, 37);
            label1.TabIndex = 0;
            label1.Text = "Inscribir en Actividad";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.BackColor = Color.FromArgb(53, 47, 80);
            lblUsuario.ForeColor = Color.Snow;
            lblUsuario.Location = new Point(604, 9);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(0, 15);
            lblUsuario.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-2, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(337, 453);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // txtNombreAct
            // 
            txtNombreAct.Location = new Point(495, 141);
            txtNombreAct.Name = "txtNombreAct";
            txtNombreAct.Size = new Size(109, 23);
            txtNombreAct.TabIndex = 10;
            txtNombreAct.Text = "Actividad";
            txtNombreAct.Enter += txtNombreAct_Enter;
            txtNombreAct.Leave += txtNombreAct_Leave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Snow;
            label2.Location = new Point(382, 144);
            label2.Name = "label2";
            label2.Size = new Size(107, 15);
            label2.TabIndex = 11;
            label2.Text = "Nombre Actividad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Snow;
            label3.Location = new Point(421, 203);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 13;
            label3.Text = "Dni Cliente:";
            // 
            // txtDniNoSocio
            // 
            txtDniNoSocio.Location = new Point(495, 200);
            txtDniNoSocio.Name = "txtDniNoSocio";
            txtDniNoSocio.Size = new Size(109, 23);
            txtDniNoSocio.TabIndex = 12;
            txtDniNoSocio.Text = "DNI";
            txtDniNoSocio.Enter += txtDniNoSocio_Enter;
            txtDniNoSocio.Leave += txtDniNoSocio_Leave;
            // 
            // buscarActividad
            // 
            buscarActividad.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buscarActividad.ForeColor = Color.Black;
            buscarActividad.Image = (Image)resources.GetObject("buscarActividad.Image");
            buscarActividad.ImageAlign = ContentAlignment.MiddleLeft;
            buscarActividad.Location = new Point(610, 139);
            buscarActividad.Name = "buscarActividad";
            buscarActividad.Size = new Size(85, 25);
            buscarActividad.TabIndex = 14;
            buscarActividad.Text = "BUSCAR";
            buscarActividad.TextAlign = ContentAlignment.MiddleRight;
            buscarActividad.UseVisualStyleBackColor = true;
            buscarActividad.Click += buscarActividad_Click;
            // 
            // buscarNoSocio
            // 
            buscarNoSocio.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buscarNoSocio.ForeColor = Color.Black;
            buscarNoSocio.Image = (Image)resources.GetObject("buscarNoSocio.Image");
            buscarNoSocio.ImageAlign = ContentAlignment.MiddleLeft;
            buscarNoSocio.Location = new Point(610, 198);
            buscarNoSocio.Name = "buscarNoSocio";
            buscarNoSocio.Size = new Size(85, 25);
            buscarNoSocio.TabIndex = 15;
            buscarNoSocio.Text = "BUSCAR";
            buscarNoSocio.TextAlign = ContentAlignment.MiddleRight;
            buscarNoSocio.UseVisualStyleBackColor = true;
            buscarNoSocio.Click += buscarNoSocio_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Snow;
            label4.Location = new Point(416, 273);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 17;
            label4.Text = "Id Actividad:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Snow;
            label5.Location = new Point(572, 273);
            label5.Name = "label5";
            label5.Size = new Size(68, 15);
            label5.TabIndex = 19;
            label5.Text = "Id NoSocio:";
            // 
            // txtIdNoSocio
            // 
            txtIdNoSocio.BackColor = Color.LightGray;
            txtIdNoSocio.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtIdNoSocio.Location = new Point(646, 268);
            txtIdNoSocio.Name = "txtIdNoSocio";
            txtIdNoSocio.Size = new Size(60, 28);
            txtIdNoSocio.TabIndex = 18;
            txtIdNoSocio.TextAlign = HorizontalAlignment.Center;
            // 
            // btnVolver
            // 
            btnVolver.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolver.Image = Properties.Resources.volver;
            btnVolver.ImageAlign = ContentAlignment.MiddleLeft;
            btnVolver.Location = new Point(658, 379);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(113, 36);
            btnVolver.TabIndex = 30;
            btnVolver.Text = "VOLVER";
            btnVolver.TextAlign = ContentAlignment.MiddleRight;
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            btnVolver.MouseLeave += btnVolver_MouseLeave;
            btnVolver.MouseMove += btnVolver_MouseMove;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimpiar.Image = Properties.Resources.limpiar;
            btnLimpiar.ImageAlign = ContentAlignment.BottomLeft;
            btnLimpiar.Location = new Point(366, 379);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(123, 36);
            btnLimpiar.TabIndex = 32;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.TextAlign = ContentAlignment.MiddleRight;
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            btnLimpiar.MouseLeave += btnLimpiar_MouseLeave;
            btnLimpiar.MouseMove += btnLimpiar_MouseMove;
            // 
            // btnInscribir
            // 
            btnInscribir.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnInscribir.Location = new Point(512, 379);
            btnInscribir.Name = "btnInscribir";
            btnInscribir.Size = new Size(117, 36);
            btnInscribir.TabIndex = 33;
            btnInscribir.Text = "INSCRIBIR";
            btnInscribir.UseVisualStyleBackColor = true;
            btnInscribir.Click += btnInscribir_Click;
            btnInscribir.MouseLeave += btnInscribir_MouseLeave;
            btnInscribir.MouseMove += btnInscribir_MouseMove;
            // 
            // txtIdActividad
            // 
            txtIdActividad.BackColor = Color.LightGray;
            txtIdActividad.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtIdActividad.Location = new Point(495, 268);
            txtIdActividad.Name = "txtIdActividad";
            txtIdActividad.Size = new Size(60, 28);
            txtIdActividad.TabIndex = 34;
            txtIdActividad.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBox10
            // 
            pictureBox10.BackColor = Color.FromArgb(53, 47, 80);
            pictureBox10.Location = new Point(331, 351);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(471, 103);
            pictureBox10.TabIndex = 70;
            pictureBox10.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(53, 47, 80);
            pictureBox2.Location = new Point(331, 1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(471, 95);
            pictureBox2.TabIndex = 71;
            pictureBox2.TabStop = false;
            // 
            // InscribirActividad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(txtIdActividad);
            Controls.Add(btnInscribir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnVolver);
            Controls.Add(label5);
            Controls.Add(txtIdNoSocio);
            Controls.Add(label4);
            Controls.Add(buscarNoSocio);
            Controls.Add(buscarActividad);
            Controls.Add(label3);
            Controls.Add(txtDniNoSocio);
            Controls.Add(label2);
            Controls.Add(txtNombreAct);
            Controls.Add(pictureBox1);
            Controls.Add(lblUsuario);
            Controls.Add(label1);
            Controls.Add(pictureBox10);
            Controls.Add(pictureBox2);
            ForeColor = Color.Black;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "InscribirActividad";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InscribirActividad";
            Load += InscribirActividad_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblUsuario;
        private PictureBox pictureBox1;
        private TextBox txtNombreAct;
        private Label label2;
        private Label label3;
        private TextBox txtDniNoSocio;
        private Button buscarActividad;
        private Button buscarNoSocio;
        private Label label4;
        private Label label5;
        private TextBox txtIdNoSocio;
        private Button btnVolver;
        private Button btnLimpiar;
        private Button btnInscribir;
        private TextBox txtIdActividad;
        private PictureBox pictureBox10;
        private PictureBox pictureBox2;
    }
}