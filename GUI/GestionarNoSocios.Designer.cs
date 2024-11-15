using System.Drawing;
using System.Windows.Forms;

namespace proyecto_final_club_deportivo.GUI
{
    partial class GestionarNoSocios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionarNoSocios));
            lblPagar = new Label();
            lblUsuario = new Label();
            pictureBox10 = new PictureBox();
            pictureBox1 = new PictureBox();
            btnInscribirActividad = new Button();
            btnListarNoSocios = new Button();
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
            lblPagar.Location = new Point(136, 51);
            lblPagar.Name = "lblPagar";
            lblPagar.Size = new Size(266, 40);
            lblPagar.TabIndex = 1;
            lblPagar.Text = "Gestión No Socios";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.BackColor = Color.FromArgb(53, 47, 80);
            lblUsuario.ForeColor = Color.Snow;
            lblUsuario.Location = new Point(301, 9);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(0, 15);
            lblUsuario.TabIndex = 9;
            // 
            // pictureBox10
            // 
            pictureBox10.BackColor = Color.FromArgb(53, 47, 80);
            pictureBox10.Location = new Point(-2, -1);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(531, 40);
            pictureBox10.TabIndex = 71;
            pictureBox10.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(83, 114);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(156, 178);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 72;
            pictureBox1.TabStop = false;
            // 
            // btnInscribirActividad
            // 
            btnInscribirActividad.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnInscribirActividad.Location = new Point(271, 114);
            btnInscribirActividad.Name = "btnInscribirActividad";
            btnInscribirActividad.Size = new Size(182, 51);
            btnInscribirActividad.TabIndex = 73;
            btnInscribirActividad.Text = "INSCRIBIR ACTIVIDAD";
            btnInscribirActividad.UseVisualStyleBackColor = true;
            btnInscribirActividad.Click += btnInscribirActividad_Click;
            btnInscribirActividad.MouseLeave += btnInscribirActividad_MouseLeave;
            btnInscribirActividad.MouseMove += btnInscribirActividad_MouseMove;
            // 
            // btnListarNoSocios
            // 
            btnListarNoSocios.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnListarNoSocios.Location = new Point(271, 197);
            btnListarNoSocios.Name = "btnListarNoSocios";
            btnListarNoSocios.Size = new Size(182, 51);
            btnListarNoSocios.TabIndex = 74;
            btnListarNoSocios.Text = "LISTAR NO SOCIOS";
            btnListarNoSocios.UseVisualStyleBackColor = true;
            btnListarNoSocios.Click += btnListarNoSocios_Click;
            btnListarNoSocios.MouseLeave += btnListarNoSocios_MouseLeave;
            btnListarNoSocios.MouseMove += btnListarNoSocios_MouseMove;
            // 
            // btnVolver
            // 
            btnVolver.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolver.Image = Properties.Resources.volver;
            btnVolver.ImageAlign = ContentAlignment.MiddleLeft;
            btnVolver.Location = new Point(342, 284);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(111, 51);
            btnVolver.TabIndex = 75;
            btnVolver.Text = "VOLVER";
            btnVolver.TextAlign = ContentAlignment.MiddleRight;
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            btnVolver.MouseLeave += btnVolver_MouseLeave;
            btnVolver.MouseMove += btnVolver_MouseMove;
            // 
            // GestionarNoSocios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateBlue;
            ClientSize = new Size(529, 374);
            Controls.Add(btnVolver);
            Controls.Add(btnListarNoSocios);
            Controls.Add(btnInscribirActividad);
            Controls.Add(pictureBox1);
            Controls.Add(lblUsuario);
            Controls.Add(lblPagar);
            Controls.Add(pictureBox10);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "GestionarNoSocios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "No Socios";
            Load += GestionarNoSocios_Load;
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
        private Button btnInscribirActividad;
        private Button btnListarNoSocios;
        private Button btnVolver;
    }
}