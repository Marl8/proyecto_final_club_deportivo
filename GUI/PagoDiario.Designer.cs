namespace proyecto_final_club_deportivo.GUI
{
    partial class PagoDiario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PagoDiario));
            lblPagar = new Label();
            lblUsuario = new Label();
            label1 = new Label();
            btnCalcular = new Button();
            txtMonto = new TextBox();
            txtDiaHabilitado = new DateTimePicker();
            label4 = new Label();
            pictureBox10 = new PictureBox();
            btnPagar = new Button();
            btnLimpiar = new Button();
            btnVolver = new Button();
            pictureBox2 = new PictureBox();
            buscarNoSocio = new Button();
            label3 = new Label();
            txtDniNoSocio = new TextBox();
            label5 = new Label();
            txtIdNoSocio = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lblPagar
            // 
            lblPagar.AutoSize = true;
            lblPagar.BackColor = Color.DarkSlateBlue;
            lblPagar.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblPagar.ForeColor = Color.Snow;
            lblPagar.Location = new Point(161, 76);
            lblPagar.Name = "lblPagar";
            lblPagar.Size = new Size(322, 40);
            lblPagar.TabIndex = 1;
            lblPagar.Text = "Pagar Actividad Diaria";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.BackColor = Color.FromArgb(53, 47, 80);
            lblUsuario.ForeColor = Color.Snow;
            lblUsuario.Location = new Point(388, 9);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(0, 15);
            lblUsuario.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(267, 234);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 20;
            label1.Text = "Monto a Pagar:";
            // 
            // btnCalcular
            // 
            btnCalcular.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCalcular.Image = (Image)resources.GetObject("btnCalcular.Image");
            btnCalcular.ImageAlign = ContentAlignment.MiddleLeft;
            btnCalcular.Location = new Point(470, 223);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(100, 34);
            btnCalcular.TabIndex = 19;
            btnCalcular.Text = "CALCULAR";
            btnCalcular.TextAlign = ContentAlignment.MiddleRight;
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtMonto
            // 
            txtMonto.BackColor = Color.LightGray;
            txtMonto.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtMonto.Location = new Point(361, 227);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(93, 28);
            txtMonto.TabIndex = 18;
            txtMonto.Text = "0";
            txtMonto.TextAlign = HorizontalAlignment.Center;
            // 
            // txtDiaHabilitado
            // 
            txtDiaHabilitado.Format = DateTimePickerFormat.Custom;
            txtDiaHabilitado.Location = new Point(142, 168);
            txtDiaHabilitado.Name = "txtDiaHabilitado";
            txtDiaHabilitado.Size = new Size(100, 23);
            txtDiaHabilitado.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Snow;
            label4.Location = new Point(51, 172);
            label4.Name = "label4";
            label4.Size = new Size(85, 15);
            label4.TabIndex = 24;
            label4.Text = "Dia Habilitado:";
            // 
            // pictureBox10
            // 
            pictureBox10.BackColor = Color.FromArgb(53, 47, 80);
            pictureBox10.Location = new Point(-6, 340);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(648, 97);
            pictureBox10.TabIndex = 71;
            pictureBox10.TabStop = false;
            // 
            // btnPagar
            // 
            btnPagar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnPagar.Location = new Point(271, 365);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(117, 36);
            btnPagar.TabIndex = 74;
            btnPagar.Text = "PAGAR";
            btnPagar.UseVisualStyleBackColor = true;
            btnPagar.Click += btnInscribir_Click;
            btnPagar.MouseLeave += btnPagar_MouseLeave;
            btnPagar.MouseMove += btnInscribir_MouseMove;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimpiar.Image = Properties.Resources.limpiar;
            btnLimpiar.ImageAlign = ContentAlignment.BottomLeft;
            btnLimpiar.Location = new Point(110, 365);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(123, 36);
            btnLimpiar.TabIndex = 73;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.TextAlign = ContentAlignment.MiddleRight;
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            btnLimpiar.MouseLeave += btnLimpiar_MouseLeave;
            btnLimpiar.MouseMove += btnLimpiar_MouseMove;
            // 
            // btnVolver
            // 
            btnVolver.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolver.Image = Properties.Resources.volver;
            btnVolver.ImageAlign = ContentAlignment.MiddleLeft;
            btnVolver.Location = new Point(422, 365);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(113, 36);
            btnVolver.TabIndex = 72;
            btnVolver.Text = "VOLVER";
            btnVolver.TextAlign = ContentAlignment.MiddleRight;
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            btnVolver.MouseLeave += btnVolver_MouseLeave;
            btnVolver.MouseMove += btnVolver_MouseMove;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(53, 47, 80);
            pictureBox2.Location = new Point(-6, -1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(648, 51);
            pictureBox2.TabIndex = 75;
            pictureBox2.TabStop = false;
            // 
            // buscarNoSocio
            // 
            buscarNoSocio.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            buscarNoSocio.ForeColor = Color.Black;
            buscarNoSocio.Image = (Image)resources.GetObject("buscarNoSocio.Image");
            buscarNoSocio.ImageAlign = ContentAlignment.MiddleLeft;
            buscarNoSocio.Location = new Point(470, 164);
            buscarNoSocio.Name = "buscarNoSocio";
            buscarNoSocio.Size = new Size(100, 32);
            buscarNoSocio.TabIndex = 78;
            buscarNoSocio.Text = "BUSCAR";
            buscarNoSocio.TextAlign = ContentAlignment.MiddleRight;
            buscarNoSocio.UseVisualStyleBackColor = true;
            buscarNoSocio.Click += buscarNoSocio_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Snow;
            label3.Location = new Point(262, 172);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 77;
            label3.Text = "Dni Cliente:";
            // 
            // txtDniNoSocio
            // 
            txtDniNoSocio.Location = new Point(336, 169);
            txtDniNoSocio.Name = "txtDniNoSocio";
            txtDniNoSocio.Size = new Size(118, 23);
            txtDniNoSocio.TabIndex = 76;
            txtDniNoSocio.Text = "DNI";
            txtDniNoSocio.Enter += txtDniNoSocio_Enter;
            txtDniNoSocio.Leave += txtDniNoSocio_Leave;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Snow;
            label5.Location = new Point(108, 234);
            label5.Name = "label5";
            label5.Size = new Size(68, 15);
            label5.TabIndex = 80;
            label5.Text = "Id NoSocio:";
            // 
            // txtIdNoSocio
            // 
            txtIdNoSocio.BackColor = Color.LightGray;
            txtIdNoSocio.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtIdNoSocio.Location = new Point(182, 229);
            txtIdNoSocio.Name = "txtIdNoSocio";
            txtIdNoSocio.Size = new Size(60, 28);
            txtIdNoSocio.TabIndex = 79;
            txtIdNoSocio.TextAlign = HorizontalAlignment.Center;
            // 
            // PagoDiario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateBlue;
            ClientSize = new Size(642, 433);
            Controls.Add(label5);
            Controls.Add(txtIdNoSocio);
            Controls.Add(buscarNoSocio);
            Controls.Add(label3);
            Controls.Add(txtDniNoSocio);
            Controls.Add(btnPagar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnVolver);
            Controls.Add(pictureBox10);
            Controls.Add(label4);
            Controls.Add(txtDiaHabilitado);
            Controls.Add(label1);
            Controls.Add(btnCalcular);
            Controls.Add(txtMonto);
            Controls.Add(lblUsuario);
            Controls.Add(lblPagar);
            Controls.Add(pictureBox2);
            Name = "PagoDiario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PagoDiario";
            Load += PagoDiario_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPagar;
        private Label lblUsuario;
        private Label label1;
        private Button btnCalcular;
        private TextBox txtMonto;
        private DateTimePicker txtDiaHabilitado;
        private Label label4;
        private PictureBox pictureBox10;
        private Button btnPagar;
        private Button btnLimpiar;
        private Button btnVolver;
        private PictureBox pictureBox2;
        private Button buscarNoSocio;
        private Label label3;
        private TextBox txtDniNoSocio;
        private Label label5;
        private TextBox txtIdNoSocio;
    }
}