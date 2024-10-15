namespace proyecto_final_club_deportivo.GUI
{
    partial class GestionListadosSocios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionListadosSocios));
            lblPagar = new Label();
            lblUsuario = new Label();
            pictureBox10 = new PictureBox();
            pictureBox1 = new PictureBox();
            btnVolver = new Button();
            btnSociosMora = new Button();
            btnVencDiarios = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblPagar
            // 
            lblPagar.AutoSize = true;
            lblPagar.BackColor = Color.DarkSlateBlue;
            lblPagar.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblPagar.ForeColor = Color.Snow;
            lblPagar.Location = new Point(83, 53);
            lblPagar.Name = "lblPagar";
            lblPagar.Size = new Size(337, 40);
            lblPagar.TabIndex = 3;
            lblPagar.Text = "Gestión Listados Socios";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.BackColor = Color.FromArgb(53, 47, 80);
            lblUsuario.ForeColor = Color.Snow;
            lblUsuario.Location = new Point(259, 9);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(0, 15);
            lblUsuario.TabIndex = 9;
            // 
            // pictureBox10
            // 
            pictureBox10.BackColor = Color.FromArgb(53, 47, 80);
            pictureBox10.Location = new Point(-5, -4);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(528, 40);
            pictureBox10.TabIndex = 71;
            pictureBox10.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(34, 138);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(208, 182);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 72;
            pictureBox1.TabStop = false;
            // 
            // btnVolver
            // 
            btnVolver.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolver.Image = Properties.Resources.volver;
            btnVolver.ImageAlign = ContentAlignment.MiddleLeft;
            btnVolver.Location = new Point(349, 304);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(113, 44);
            btnVolver.TabIndex = 75;
            btnVolver.Text = "VOLVER";
            btnVolver.TextAlign = ContentAlignment.MiddleRight;
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            btnVolver.MouseLeave += btnVolver_MouseLeave;
            btnVolver.MouseMove += btnVolver_MouseMove;
            // 
            // btnSociosMora
            // 
            btnSociosMora.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSociosMora.Location = new Point(290, 214);
            btnSociosMora.Name = "btnSociosMora";
            btnSociosMora.Size = new Size(172, 58);
            btnSociosMora.TabIndex = 74;
            btnSociosMora.Text = "SOCIOS EN MORA";
            btnSociosMora.UseVisualStyleBackColor = true;
            btnSociosMora.Click += btnSociosMora_Click;
            btnSociosMora.MouseLeave += btnSociosMora_MouseLeave;
            btnSociosMora.MouseMove += btnSociosMora_MouseMove;
            // 
            // btnVencDiarios
            // 
            btnVencDiarios.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnVencDiarios.Location = new Point(290, 128);
            btnVencDiarios.Name = "btnVencDiarios";
            btnVencDiarios.Size = new Size(172, 54);
            btnVencDiarios.TabIndex = 73;
            btnVencDiarios.Text = "VENCIMIENTOS DIARIOS";
            btnVencDiarios.UseVisualStyleBackColor = true;
            btnVencDiarios.Click += btnVencDiarios_Click;
            btnVencDiarios.MouseLeave += btnVencDiarios_MouseLeave;
            btnVencDiarios.MouseMove += btnVencDiarios_MouseMove;
            // 
            // GestionListadosSocios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateBlue;
            ClientSize = new Size(519, 379);
            Controls.Add(btnVolver);
            Controls.Add(btnSociosMora);
            Controls.Add(btnVencDiarios);
            Controls.Add(pictureBox1);
            Controls.Add(lblUsuario);
            Controls.Add(lblPagar);
            Controls.Add(pictureBox10);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "GestionListadosSocios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GestionListadosSocios";
            Load += GestionListadosSocios_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPagar;
        private Label lblUsuario;
        private PictureBox pictureBox10;
        private PictureBox pictureBox1;
        private Button btnVolver;
        private Button btnSociosMora;
        private Button btnVencDiarios;
    }
}