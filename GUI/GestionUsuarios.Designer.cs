namespace proyecto_final_club_deportivo.GUI
{
    partial class GestionUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionUsuarios));
            lblPagar = new Label();
            lblUsuario = new Label();
            pictureBox10 = new PictureBox();
            pictureBox1 = new PictureBox();
            btnCrearUsusario = new Button();
            btnModificarUsuario = new Button();
            btnVolver = new Button();
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
            lblPagar.Location = new Point(144, 65);
            lblPagar.Name = "lblPagar";
            lblPagar.Size = new Size(249, 40);
            lblPagar.TabIndex = 2;
            lblPagar.Text = "Gestión Usuarios";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.BackColor = Color.FromArgb(53, 47, 80);
            lblUsuario.ForeColor = Color.Snow;
            lblUsuario.Location = new Point(333, 9);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(0, 15);
            lblUsuario.TabIndex = 10;
            // 
            // pictureBox10
            // 
            pictureBox10.BackColor = Color.FromArgb(53, 47, 80);
            pictureBox10.Location = new Point(-2, -2);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(544, 44);
            pictureBox10.TabIndex = 72;
            pictureBox10.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(37, 133);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(215, 195);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 73;
            pictureBox1.TabStop = false;
            // 
            // btnCrearUsusario
            // 
            btnCrearUsusario.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCrearUsusario.Location = new Point(288, 133);
            btnCrearUsusario.Name = "btnCrearUsusario";
            btnCrearUsusario.Size = new Size(182, 51);
            btnCrearUsusario.TabIndex = 74;
            btnCrearUsusario.Text = "CREAR USUARIO";
            btnCrearUsusario.UseVisualStyleBackColor = true;
            btnCrearUsusario.Click += btnCrearUsusario_Click;
            btnCrearUsusario.MouseLeave += btnCrearUsusario_MouseLeave;
            btnCrearUsusario.MouseMove += btnCrearUsusario_MouseMove;
            // 
            // btnModificarUsuario
            // 
            btnModificarUsuario.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnModificarUsuario.Location = new Point(288, 221);
            btnModificarUsuario.Name = "btnModificarUsuario";
            btnModificarUsuario.Size = new Size(182, 51);
            btnModificarUsuario.TabIndex = 75;
            btnModificarUsuario.Text = "MODIFICAR USUARIO";
            btnModificarUsuario.UseVisualStyleBackColor = true;
            btnModificarUsuario.Click += btnModificarUsuario_Click;
            btnModificarUsuario.MouseLeave += btnModificarUsuario_MouseLeave;
            btnModificarUsuario.MouseMove += btnModificarUsuario_MouseMove;
            // 
            // btnVolver
            // 
            btnVolver.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolver.Image = Properties.Resources.volver;
            btnVolver.ImageAlign = ContentAlignment.MiddleLeft;
            btnVolver.Location = new Point(359, 309);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(111, 46);
            btnVolver.TabIndex = 76;
            btnVolver.Text = "VOLVER";
            btnVolver.TextAlign = ContentAlignment.MiddleRight;
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            btnVolver.MouseLeave += btnVolver_MouseLeave;
            btnVolver.MouseMove += btnVolver_MouseMove;
            // 
            // GestionUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateBlue;
            ClientSize = new Size(538, 405);
            Controls.Add(btnVolver);
            Controls.Add(btnModificarUsuario);
            Controls.Add(btnCrearUsusario);
            Controls.Add(pictureBox1);
            Controls.Add(lblUsuario);
            Controls.Add(lblPagar);
            Controls.Add(pictureBox10);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "GestionUsuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión Usuarios";
            Load += GestionUsuarios_Load;
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
        private Button btnCrearUsusario;
        private Button btnModificarUsuario;
        private Button btnVolver;
    }
}