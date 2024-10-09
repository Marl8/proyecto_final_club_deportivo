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
            button2 = new Button();
            lblUsuario = new Label();
            btnVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblPagar
            // 
            lblPagar.AutoSize = true;
            lblPagar.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblPagar.ForeColor = Color.Snow;
            lblPagar.Location = new Point(210, 36);
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
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(293, 186);
            button2.Name = "button2";
            button2.Size = new Size(172, 58);
            button2.TabIndex = 3;
            button2.Text = "PAGO DIARIO";
            button2.UseVisualStyleBackColor = true;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.ForeColor = Color.Snow;
            lblUsuario.Location = new Point(323, 21);
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
            // 
            // Pagar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateBlue;
            ClientSize = new Size(528, 366);
            Controls.Add(btnVolver);
            Controls.Add(lblUsuario);
            Controls.Add(button2);
            Controls.Add(pictureBox1);
            Controls.Add(btnPagarCuota);
            Controls.Add(lblPagar);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Pagar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pagar";
            Load += Pagar_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPagar;
        private Button btnPagarCuota;
        private PictureBox pictureBox1;
        private Button button2;
        private Label lblUsuario;
        private Button btnVolver;
    }
}