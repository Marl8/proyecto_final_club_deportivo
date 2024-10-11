namespace proyecto_final_club_deportivo
{
    partial class Pagar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pagar));
            lblPagar = new Label();
            btnPagarCuota = new Button();
            pictureBox1 = new PictureBox();
            btnPagoDiario = new Button();
            lblUsuario = new Label();
            btnVolver = new Button();
            pictureBox10 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            SuspendLayout();
            // 
            // lblPagar
            // 
            lblPagar.AutoSize = true;
            lblPagar.BackColor = Color.DarkSlateBlue;
            lblPagar.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblPagar.ForeColor = Color.Snow;
            lblPagar.Location = new Point(217, 41);
            lblPagar.Name = "lblPagar";
            lblPagar.Size = new Size(96, 40);
            lblPagar.TabIndex = 0;
            lblPagar.Text = "Pagar";
            // 
            // btnPagarCuota
            // 
            btnPagarCuota.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnPagarCuota.Location = new Point(293, 100);
            btnPagarCuota.Name = "btnPagarCuota";
            btnPagarCuota.Size = new Size(172, 54);
            btnPagarCuota.TabIndex = 1;
            btnPagarCuota.Text = "PAGO CUOTA";
            btnPagarCuota.UseVisualStyleBackColor = true;
            btnPagarCuota.MouseLeave += btnPagarCuota_MouseLeave;
            btnPagarCuota.MouseMove += btnPagarCuota_MouseMove;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(45, 79);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(205, 218);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // btnPagoDiario
            // 
            btnPagoDiario.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnPagoDiario.Location = new Point(293, 186);
            btnPagoDiario.Name = "btnPagoDiario";
            btnPagoDiario.Size = new Size(172, 58);
            btnPagoDiario.TabIndex = 3;
            btnPagoDiario.Text = "PAGO DIARIO";
            btnPagoDiario.UseVisualStyleBackColor = true;
            btnPagoDiario.Click += btnPagoDiario_Click;
            btnPagoDiario.MouseLeave += btnPagoDiario_MouseLeave;
            btnPagoDiario.MouseMove += btnPagoDiario_MouseMove;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.BackColor = Color.FromArgb(53, 47, 80);
            lblUsuario.ForeColor = Color.Snow;
            lblUsuario.Location = new Point(322, 9);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(0, 15);
            lblUsuario.TabIndex = 8;
            // 
            // btnVolver
            // 
            btnVolver.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolver.Image = Properties.Resources.volver;
            btnVolver.ImageAlign = ContentAlignment.MiddleLeft;
            btnVolver.Location = new Point(352, 276);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(113, 44);
            btnVolver.TabIndex = 10;
            btnVolver.Text = "VOLVER";
            btnVolver.TextAlign = ContentAlignment.MiddleRight;
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            btnVolver.MouseLeave += btnVolver_MouseLeave;
            btnVolver.MouseMove += btnVolver_MouseMove;
            // 
            // pictureBox10
            // 
            pictureBox10.BackColor = Color.FromArgb(53, 47, 80);
            pictureBox10.Location = new Point(-4, -2);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(533, 40);
            pictureBox10.TabIndex = 70;
            pictureBox10.TabStop = false;
            // 
            // Pagar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateBlue;
            ClientSize = new Size(528, 366);
            Controls.Add(btnVolver);
            Controls.Add(lblUsuario);
            Controls.Add(btnPagoDiario);
            Controls.Add(pictureBox1);
            Controls.Add(btnPagarCuota);
            Controls.Add(lblPagar);
            Controls.Add(pictureBox10);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Pagar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pagar";
            Load += Pagar_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPagar;
        private Button btnPagarCuota;
        private PictureBox pictureBox1;
        private Button btnPagoDiario;
        private Label lblUsuario;
        private Button btnVolver;
        private PictureBox pictureBox10;
    }
}