namespace proyecto_final_club_deportivo.GUI
{
    partial class ListarNoSocios
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
            lblUsuario = new Label();
            pictureBox8 = new PictureBox();
            btnVolver = new Button();
            dtgvNoSocios = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgvNoSocios).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkSlateBlue;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(129, 76);
            label1.Name = "label1";
            label1.Size = new Size(413, 32);
            label1.TabIndex = 2;
            label1.Text = "LISTA DE NO SOCIOS HABILITADOS";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.BackColor = Color.FromArgb(53, 47, 80);
            lblUsuario.ForeColor = Color.Snow;
            lblUsuario.Location = new Point(560, 9);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(0, 15);
            lblUsuario.TabIndex = 46;
            // 
            // pictureBox8
            // 
            pictureBox8.BackColor = Color.FromArgb(53, 47, 80);
            pictureBox8.Location = new Point(-1, -1);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(774, 52);
            pictureBox8.TabIndex = 71;
            pictureBox8.TabStop = false;
            // 
            // btnVolver
            // 
            btnVolver.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolver.Image = Properties.Resources.volver;
            btnVolver.ImageAlign = ContentAlignment.MiddleLeft;
            btnVolver.Location = new Point(618, 70);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(112, 51);
            btnVolver.TabIndex = 76;
            btnVolver.Text = "VOLVER";
            btnVolver.TextAlign = ContentAlignment.MiddleRight;
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            btnVolver.MouseLeave += btnVolver_MouseLeave;
            btnVolver.MouseMove += btnVolver_MouseMove;
            // 
            // dtgvNoSocios
            // 
            dtgvNoSocios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvNoSocios.Location = new Point(31, 147);
            dtgvNoSocios.Name = "dtgvNoSocios";
            dtgvNoSocios.RowTemplate.Height = 25;
            dtgvNoSocios.Size = new Size(699, 272);
            dtgvNoSocios.TabIndex = 77;
            // 
            // ListarNoSocios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateBlue;
            ClientSize = new Size(771, 446);
            Controls.Add(dtgvNoSocios);
            Controls.Add(btnVolver);
            Controls.Add(lblUsuario);
            Controls.Add(label1);
            Controls.Add(pictureBox8);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ListarNoSocios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ListarNoSocios";
            Load += ListarNoSocios_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgvNoSocios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblUsuario;
        private PictureBox pictureBox8;
        private Button btnVolver;
        private DataGridView dtgvNoSocios;
    }
}