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
            label1 = new Label();
            btnRegistrarSocio = new Button();
            btnRegistrarNoSocio = new Button();
            btnImprimirCarnet = new Button();
            btnInscribirActividad = new Button();
            btnPagarCuota = new Button();
            btnListarSocios = new Button();
            lblUsuario = new Label();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(160, 39);
            label1.Name = "label1";
            label1.Size = new Size(463, 37);
            label1.TabIndex = 0;
            label1.Text = "Club Deportivo - Pantalla Principal";
            // 
            // btnRegistrarSocio
            // 
            btnRegistrarSocio.BackColor = Color.FromArgb(128, 128, 255);
            btnRegistrarSocio.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegistrarSocio.ForeColor = Color.Black;
            btnRegistrarSocio.Location = new Point(116, 116);
            btnRegistrarSocio.Name = "btnRegistrarSocio";
            btnRegistrarSocio.Size = new Size(205, 52);
            btnRegistrarSocio.TabIndex = 1;
            btnRegistrarSocio.Text = "INSCRIBIR SOCIO";
            btnRegistrarSocio.UseVisualStyleBackColor = false;
            btnRegistrarSocio.Click += btnRegistrarSocio_Click;
            // 
            // btnRegistrarNoSocio
            // 
            btnRegistrarNoSocio.BackColor = Color.FromArgb(128, 128, 255);
            btnRegistrarNoSocio.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegistrarNoSocio.ForeColor = Color.Black;
            btnRegistrarNoSocio.Location = new Point(472, 116);
            btnRegistrarNoSocio.Name = "btnRegistrarNoSocio";
            btnRegistrarNoSocio.Size = new Size(205, 52);
            btnRegistrarNoSocio.TabIndex = 2;
            btnRegistrarNoSocio.Text = "INSCRIBIR NO SOCIO";
            btnRegistrarNoSocio.UseVisualStyleBackColor = false;
            btnRegistrarNoSocio.Click += btnRegistrarNoSocio_Click;
            // 
            // btnImprimirCarnet
            // 
            btnImprimirCarnet.BackColor = Color.FromArgb(192, 192, 255);
            btnImprimirCarnet.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnImprimirCarnet.ForeColor = Color.Black;
            btnImprimirCarnet.Location = new Point(116, 200);
            btnImprimirCarnet.Name = "btnImprimirCarnet";
            btnImprimirCarnet.Size = new Size(205, 52);
            btnImprimirCarnet.TabIndex = 3;
            btnImprimirCarnet.Text = "IMPRIMIR CARNET";
            btnImprimirCarnet.UseVisualStyleBackColor = false;
            // 
            // btnInscribirActividad
            // 
            btnInscribirActividad.BackColor = Color.FromArgb(192, 192, 255);
            btnInscribirActividad.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnInscribirActividad.ForeColor = Color.Black;
            btnInscribirActividad.Location = new Point(472, 200);
            btnInscribirActividad.Name = "btnInscribirActividad";
            btnInscribirActividad.Size = new Size(205, 52);
            btnInscribirActividad.TabIndex = 4;
            btnInscribirActividad.Text = "INSCRIBIR ACTIVIDAD";
            btnInscribirActividad.UseVisualStyleBackColor = false;
            btnInscribirActividad.Click += btnInscribirActividad_Click;
            // 
            // btnPagarCuota
            // 
            btnPagarCuota.BackColor = Color.FromArgb(128, 128, 255);
            btnPagarCuota.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnPagarCuota.ForeColor = Color.Black;
            btnPagarCuota.Location = new Point(116, 288);
            btnPagarCuota.Name = "btnPagarCuota";
            btnPagarCuota.Size = new Size(205, 52);
            btnPagarCuota.TabIndex = 5;
            btnPagarCuota.Text = "PAGAR ";
            btnPagarCuota.UseVisualStyleBackColor = false;
            btnPagarCuota.Click += btnPagarCuota_Click;
            // 
            // btnListarSocios
            // 
            btnListarSocios.BackColor = Color.FromArgb(128, 128, 255);
            btnListarSocios.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnListarSocios.ForeColor = Color.Black;
            btnListarSocios.Location = new Point(472, 288);
            btnListarSocios.Name = "btnListarSocios";
            btnListarSocios.Size = new Size(205, 52);
            btnListarSocios.TabIndex = 6;
            btnListarSocios.Text = "LISTAR SOCIOS";
            btnListarSocios.UseVisualStyleBackColor = false;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(562, 9);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(0, 15);
            lblUsuario.TabIndex = 7;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.LightGray;
            btnSalir.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.ForeColor = Color.Black;
            btnSalir.Image = Properties.Resources.exit_icon1;
            btnSalir.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalir.Location = new Point(562, 379);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(115, 46);
            btnSalir.TabIndex = 8;
            btnSalir.Text = "SALIR";
            btnSalir.TextAlign = ContentAlignment.MiddleRight;
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalir);
            Controls.Add(lblUsuario);
            Controls.Add(btnListarSocios);
            Controls.Add(btnPagarCuota);
            Controls.Add(btnInscribirActividad);
            Controls.Add(btnImprimirCarnet);
            Controls.Add(btnRegistrarNoSocio);
            Controls.Add(btnRegistrarSocio);
            Controls.Add(label1);
            ForeColor = Color.Snow;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Principal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Principal";
            Load += Principal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnRegistrarSocio;
        private Button btnRegistrarNoSocio;
        private Button btnImprimirCarnet;
        private Button btnInscribirActividad;
        private Button btnPagarCuota;
        private Button btnListarSocios;
        private Label lblUsuario;
        private Button btnSalir;
    }
}