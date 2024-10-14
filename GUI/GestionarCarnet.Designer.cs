namespace proyecto_final_club_deportivo.GUI
{
    partial class GestionarCarnet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionarCarnet));
            lblPagar = new Label();
            lblUsuario = new Label();
            pictureBox10 = new PictureBox();
            btnVolver = new Button();
            label1 = new Label();
            buscarSocio = new Button();
            txtDniSocio = new TextBox();
            btnImprimir = new Button();
            txtIdSocio = new TextBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            SuspendLayout();
            // 
            // lblPagar
            // 
            lblPagar.AutoSize = true;
            lblPagar.BackColor = Color.DarkSlateBlue;
            lblPagar.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblPagar.ForeColor = Color.Snow;
            lblPagar.Location = new Point(114, 58);
            lblPagar.Name = "lblPagar";
            lblPagar.Size = new Size(221, 40);
            lblPagar.TabIndex = 2;
            lblPagar.Text = "Gestión Carnet";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.BackColor = Color.FromArgb(53, 47, 80);
            lblUsuario.ForeColor = Color.Snow;
            lblUsuario.Location = new Point(213, 9);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(0, 15);
            lblUsuario.TabIndex = 10;
            // 
            // pictureBox10
            // 
            pictureBox10.BackColor = Color.FromArgb(53, 47, 80);
            pictureBox10.Location = new Point(-8, -4);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(463, 46);
            pictureBox10.TabIndex = 72;
            pictureBox10.TabStop = false;
            // 
            // btnVolver
            // 
            btnVolver.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolver.Image = Properties.Resources.volver;
            btnVolver.ImageAlign = ContentAlignment.MiddleLeft;
            btnVolver.Location = new Point(242, 253);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(112, 40);
            btnVolver.TabIndex = 76;
            btnVolver.Text = "VOLVER";
            btnVolver.TextAlign = ContentAlignment.MiddleRight;
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            btnVolver.MouseLeave += btnVolver_MouseLeave;
            btnVolver.MouseMove += btnVolver_MouseMove;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(75, 143);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 77;
            label1.Text = "DNI Socio:";
            // 
            // buscarSocio
            // 
            buscarSocio.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            buscarSocio.ForeColor = Color.Black;
            buscarSocio.Image = (Image)resources.GetObject("buscarSocio.Image");
            buscarSocio.ImageAlign = ContentAlignment.MiddleLeft;
            buscarSocio.Location = new Point(277, 135);
            buscarSocio.Name = "buscarSocio";
            buscarSocio.Size = new Size(100, 32);
            buscarSocio.TabIndex = 102;
            buscarSocio.Text = "BUSCAR";
            buscarSocio.TextAlign = ContentAlignment.MiddleRight;
            buscarSocio.UseVisualStyleBackColor = true;
            buscarSocio.Click += buscarSocio_Click;
            // 
            // txtDniSocio
            // 
            txtDniSocio.Location = new Point(143, 140);
            txtDniSocio.Name = "txtDniSocio";
            txtDniSocio.Size = new Size(118, 23);
            txtDniSocio.TabIndex = 100;
            txtDniSocio.Text = "DNI";
            txtDniSocio.Enter += txtDniSocio_Enter;
            txtDniSocio.Leave += txtDniSocio_Leave;
            // 
            // btnImprimir
            // 
            btnImprimir.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnImprimir.Image = (Image)resources.GetObject("btnImprimir.Image");
            btnImprimir.ImageAlign = ContentAlignment.MiddleLeft;
            btnImprimir.Location = new Point(87, 253);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(126, 40);
            btnImprimir.TabIndex = 103;
            btnImprimir.Text = "IMPRIMIR";
            btnImprimir.TextAlign = ContentAlignment.MiddleRight;
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.Click += btnImprimir_Click;
            btnImprimir.MouseLeave += btnImprimir_MouseLeave;
            btnImprimir.MouseMove += btnImprimir_MouseMove;
            // 
            // txtIdSocio
            // 
            txtIdSocio.BackColor = Color.LightGray;
            txtIdSocio.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtIdSocio.Location = new Point(201, 191);
            txtIdSocio.Name = "txtIdSocio";
            txtIdSocio.Size = new Size(60, 28);
            txtIdSocio.TabIndex = 105;
            txtIdSocio.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Snow;
            label5.Location = new Point(143, 198);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 104;
            label5.Text = "Id Socio:";
            // 
            // GestionarCarnet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateBlue;
            ClientSize = new Size(453, 323);
            Controls.Add(txtIdSocio);
            Controls.Add(label5);
            Controls.Add(btnImprimir);
            Controls.Add(buscarSocio);
            Controls.Add(txtDniSocio);
            Controls.Add(label1);
            Controls.Add(btnVolver);
            Controls.Add(lblUsuario);
            Controls.Add(lblPagar);
            Controls.Add(pictureBox10);
            Name = "GestionarCarnet";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GestionarCarnet";
            Load += GestionarCarnet_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPagar;
        private Label lblUsuario;
        private PictureBox pictureBox10;
        private Button btnVolver;
        private Label label1;
        private Button buscarSocio;
        private TextBox txtDniSocio;
        private Button btnImprimir;
        private TextBox txtIdSocio;
        private Label label5;
    }
}