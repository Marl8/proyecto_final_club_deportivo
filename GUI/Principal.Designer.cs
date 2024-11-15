using System.Drawing;
using System.Windows.Forms;

namespace proyecto_final_club_deportivo
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            label1 = new Label();
            btnRegistrarSocio = new Button();
            btnRegistrarNoSocio = new Button();
            btnImprimirCarnet = new Button();
            btnGestionarNoSocio = new Button();
            btnPagarCuota = new Button();
            btnListarSocios = new Button();
            lblUsuario = new Label();
            btnSalir = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            btnGestionUsuarios = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkSlateBlue;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(275, 39);
            label1.Name = "label1";
            label1.Size = new Size(463, 37);
            label1.TabIndex = 0;
            label1.Text = "Club Deportivo - Pantalla Principal";
            // 
            // btnRegistrarSocio
            // 
            btnRegistrarSocio.BackColor = Color.FromArgb(192, 192, 255);
            btnRegistrarSocio.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegistrarSocio.ForeColor = Color.Black;
            btnRegistrarSocio.Location = new Point(12, 26);
            btnRegistrarSocio.Name = "btnRegistrarSocio";
            btnRegistrarSocio.Size = new Size(182, 50);
            btnRegistrarSocio.TabIndex = 1;
            btnRegistrarSocio.Text = "INSCRIBIR SOCIO";
            btnRegistrarSocio.UseVisualStyleBackColor = false;
            btnRegistrarSocio.Click += btnRegistrarSocio_Click;
            btnRegistrarSocio.MouseLeave += btnRegistrarSocio_MouseLeave;
            btnRegistrarSocio.MouseMove += btnRegistrarSocio_MouseMove;
            // 
            // btnRegistrarNoSocio
            // 
            btnRegistrarNoSocio.BackColor = Color.FromArgb(192, 192, 255);
            btnRegistrarNoSocio.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegistrarNoSocio.ForeColor = Color.Black;
            btnRegistrarNoSocio.Location = new Point(12, 162);
            btnRegistrarNoSocio.Name = "btnRegistrarNoSocio";
            btnRegistrarNoSocio.Size = new Size(182, 51);
            btnRegistrarNoSocio.TabIndex = 2;
            btnRegistrarNoSocio.Text = "INSCRIBIR NO SOCIO";
            btnRegistrarNoSocio.UseVisualStyleBackColor = false;
            btnRegistrarNoSocio.Click += btnRegistrarNoSocio_Click;
            btnRegistrarNoSocio.MouseLeave += btnRegistrarNoSocio_MouseLeave;
            btnRegistrarNoSocio.MouseMove += btnRegistrarNoSocio_MouseMove;
            // 
            // btnImprimirCarnet
            // 
            btnImprimirCarnet.BackColor = Color.FromArgb(192, 192, 255);
            btnImprimirCarnet.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnImprimirCarnet.ForeColor = Color.Black;
            btnImprimirCarnet.Location = new Point(12, 95);
            btnImprimirCarnet.Name = "btnImprimirCarnet";
            btnImprimirCarnet.Size = new Size(182, 49);
            btnImprimirCarnet.TabIndex = 3;
            btnImprimirCarnet.Text = "IMPRIMIR CARNET";
            btnImprimirCarnet.UseVisualStyleBackColor = false;
            btnImprimirCarnet.Click += btnImprimirCarnet_Click;
            btnImprimirCarnet.MouseLeave += btnImprimirCarnet_MouseLeave;
            btnImprimirCarnet.MouseMove += btnImprimirCarnet_MouseMove;
            // 
            // btnGestionarNoSocio
            // 
            btnGestionarNoSocio.BackColor = Color.FromArgb(192, 192, 255);
            btnGestionarNoSocio.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnGestionarNoSocio.ForeColor = Color.Black;
            btnGestionarNoSocio.Location = new Point(12, 235);
            btnGestionarNoSocio.Name = "btnGestionarNoSocio";
            btnGestionarNoSocio.Size = new Size(182, 47);
            btnGestionarNoSocio.TabIndex = 4;
            btnGestionarNoSocio.Text = "GESTIONAR NO SOCIO";
            btnGestionarNoSocio.UseVisualStyleBackColor = false;
            btnGestionarNoSocio.Click += btnInscribirActividad_Click;
            btnGestionarNoSocio.MouseLeave += btnInscribirActividad_MouseLeave;
            btnGestionarNoSocio.MouseMove += btnInscribirActividad_MouseMove;
            // 
            // btnPagarCuota
            // 
            btnPagarCuota.BackColor = Color.FromArgb(192, 192, 255);
            btnPagarCuota.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnPagarCuota.ForeColor = Color.Black;
            btnPagarCuota.Location = new Point(12, 303);
            btnPagarCuota.Name = "btnPagarCuota";
            btnPagarCuota.Size = new Size(182, 50);
            btnPagarCuota.TabIndex = 5;
            btnPagarCuota.Text = "PAGAR ";
            btnPagarCuota.UseVisualStyleBackColor = false;
            btnPagarCuota.Click += btnPagarCuota_Click;
            btnPagarCuota.MouseLeave += btnPagarCuota_MouseLeave;
            btnPagarCuota.MouseMove += btnPagarCuota_MouseMove;
            // 
            // btnListarSocios
            // 
            btnListarSocios.BackColor = Color.FromArgb(192, 192, 255);
            btnListarSocios.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnListarSocios.ForeColor = Color.Black;
            btnListarSocios.Location = new Point(12, 379);
            btnListarSocios.Name = "btnListarSocios";
            btnListarSocios.Size = new Size(182, 46);
            btnListarSocios.TabIndex = 6;
            btnListarSocios.Text = "LISTAR SOCIOS";
            btnListarSocios.UseVisualStyleBackColor = false;
            btnListarSocios.Click += btnListarSocios_Click;
            btnListarSocios.MouseLeave += btnListarSocios_MouseLeave;
            btnListarSocios.MouseMove += btnListarSocios_MouseMove;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.BackColor = Color.DarkSlateBlue;
            lblUsuario.Location = new Point(562, 9);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(0, 15);
            lblUsuario.TabIndex = 7;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(192, 192, 255);
            btnSalir.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.ForeColor = Color.Black;
            btnSalir.Image = Properties.Resources.exit_icon1;
            btnSalir.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalir.Location = new Point(610, 379);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(115, 46);
            btnSalir.TabIndex = 8;
            btnSalir.Text = "SALIR";
            btnSalir.TextAlign = ContentAlignment.MiddleRight;
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            btnSalir.MouseLeave += btnSalir_MouseLeave;
            btnSalir.MouseMove += btnSalir_MouseMove;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(53, 47, 87);
            pictureBox1.Location = new Point(-1, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(216, 450);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(263, 95);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(484, 269);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // btnGestionUsuarios
            // 
            btnGestionUsuarios.BackColor = Color.FromArgb(192, 192, 255);
            btnGestionUsuarios.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnGestionUsuarios.ForeColor = Color.Black;
            btnGestionUsuarios.Location = new Point(263, 379);
            btnGestionUsuarios.Name = "btnGestionUsuarios";
            btnGestionUsuarios.Size = new Size(144, 46);
            btnGestionUsuarios.TabIndex = 11;
            btnGestionUsuarios.Text = "GESTION USUARIOS";
            btnGestionUsuarios.UseVisualStyleBackColor = false;
            btnGestionUsuarios.Click += btnGestionUsuarios_Click;
            btnGestionUsuarios.MouseLeave += btnGestionUsuarios_MouseLeave;
            btnGestionUsuarios.MouseMove += btnGestionUsuarios_MouseMove;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGestionUsuarios);
            Controls.Add(pictureBox2);
            Controls.Add(btnSalir);
            Controls.Add(lblUsuario);
            Controls.Add(btnListarSocios);
            Controls.Add(btnPagarCuota);
            Controls.Add(btnGestionarNoSocio);
            Controls.Add(btnImprimirCarnet);
            Controls.Add(btnRegistrarNoSocio);
            Controls.Add(btnRegistrarSocio);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            ForeColor = Color.Snow;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Principal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Principal";
            Load += Principal_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnRegistrarSocio;
        private Button btnRegistrarNoSocio;
        private Button btnImprimirCarnet;
        private Button btnGestionarNoSocio;
        private Button btnPagarCuota;
        private Button btnListarSocios;
        private Label lblUsuario;
        private Button btnSalir;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button btnGestionUsuarios;
    }
}