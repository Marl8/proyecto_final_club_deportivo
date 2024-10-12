namespace proyecto_final_club_deportivo.GUI
{
    partial class PagarCuota
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PagarCuota));
            label1 = new Label();
            lblUsuario = new Label();
            pictureBox8 = new PictureBox();
            label3 = new Label();
            txtValor = new TextBox();
            buscarSocio = new Button();
            label2 = new Label();
            txtDniSocio = new TextBox();
            label5 = new Label();
            txtIdSocio = new TextBox();
            cmbFormaPago = new ComboBox();
            label4 = new Label();
            cmbEstado = new ComboBox();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            btnPagar = new Button();
            btnLimpiar = new Button();
            btnVolver = new Button();
            pictureBox10 = new PictureBox();
            cmbCantCuotas = new ComboBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkSlateBlue;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(333, 79);
            label1.Name = "label1";
            label1.Size = new Size(180, 32);
            label1.TabIndex = 2;
            label1.Text = "PAGAR CUOTA";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.BackColor = Color.FromArgb(53, 47, 80);
            lblUsuario.ForeColor = Color.Snow;
            lblUsuario.Location = new Point(528, 9);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(0, 15);
            lblUsuario.TabIndex = 46;
            // 
            // pictureBox8
            // 
            pictureBox8.BackColor = Color.FromArgb(53, 47, 80);
            pictureBox8.Location = new Point(0, -1);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(803, 52);
            pictureBox8.TabIndex = 71;
            pictureBox8.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Snow;
            label3.Location = new Point(532, 222);
            label3.Name = "label3";
            label3.Size = new Size(79, 17);
            label3.TabIndex = 73;
            label3.Text = "Valor Cuota:";
            // 
            // txtValor
            // 
            txtValor.Location = new Point(617, 221);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(136, 23);
            txtValor.TabIndex = 72;
            txtValor.Text = "Valor";
            txtValor.Enter += txtValor_Enter;
            txtValor.Leave += txtValor_Leave;
            // 
            // buscarSocio
            // 
            buscarSocio.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            buscarSocio.ForeColor = Color.Black;
            buscarSocio.Image = (Image)resources.GetObject("buscarSocio.Image");
            buscarSocio.ImageAlign = ContentAlignment.MiddleLeft;
            buscarSocio.Location = new Point(653, 160);
            buscarSocio.Name = "buscarSocio";
            buscarSocio.Size = new Size(100, 32);
            buscarSocio.TabIndex = 81;
            buscarSocio.Text = "BUSCAR";
            buscarSocio.TextAlign = ContentAlignment.MiddleRight;
            buscarSocio.UseVisualStyleBackColor = true;
            buscarSocio.Click += buscarSocio_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Snow;
            label2.Location = new Point(445, 168);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 80;
            label2.Text = "Dni Cliente:";
            // 
            // txtDniSocio
            // 
            txtDniSocio.Location = new Point(519, 165);
            txtDniSocio.Name = "txtDniSocio";
            txtDniSocio.Size = new Size(118, 23);
            txtDniSocio.TabIndex = 79;
            txtDniSocio.Enter += txtDniSocio_Enter;
            txtDniSocio.Leave += txtDniSocio_Leave;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Snow;
            label5.Location = new Point(310, 168);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 83;
            label5.Text = "Id Socio:";
            // 
            // txtIdSocio
            // 
            txtIdSocio.BackColor = Color.LightGray;
            txtIdSocio.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtIdSocio.Location = new Point(368, 161);
            txtIdSocio.Name = "txtIdSocio";
            txtIdSocio.Size = new Size(60, 28);
            txtIdSocio.TabIndex = 82;
            txtIdSocio.TextAlign = HorizontalAlignment.Center;
            // 
            // cmbFormaPago
            // 
            cmbFormaPago.FormattingEnabled = true;
            cmbFormaPago.Items.AddRange(new object[] { "Efectivo", "Tarjeta de Crédito" });
            cmbFormaPago.Location = new Point(392, 222);
            cmbFormaPago.Name = "cmbFormaPago";
            cmbFormaPago.Size = new Size(121, 23);
            cmbFormaPago.TabIndex = 84;
            cmbFormaPago.SelectedIndexChanged += cmbFormaPago_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Snow;
            label4.Location = new Point(285, 223);
            label4.Name = "label4";
            label4.Size = new Size(101, 17);
            label4.TabIndex = 85;
            label4.Text = "Forma de Pago:";
            // 
            // cmbEstado
            // 
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Items.AddRange(new object[] { "Activo", "Inactivo" });
            cmbEstado.Location = new Point(587, 283);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(121, 23);
            cmbEstado.TabIndex = 86;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Snow;
            label6.Location = new Point(530, 284);
            label6.Name = "label6";
            label6.Size = new Size(51, 17);
            label6.TabIndex = 87;
            label6.Text = "Estado:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(35, 119);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(225, 197);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 88;
            pictureBox1.TabStop = false;
            // 
            // btnPagar
            // 
            btnPagar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnPagar.Location = new Point(350, 380);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(117, 36);
            btnPagar.TabIndex = 91;
            btnPagar.Text = "PAGAR";
            btnPagar.UseVisualStyleBackColor = true;
            btnPagar.Click += btnPagar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimpiar.Image = Properties.Resources.limpiar;
            btnLimpiar.ImageAlign = ContentAlignment.BottomLeft;
            btnLimpiar.Location = new Point(189, 380);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(123, 36);
            btnLimpiar.TabIndex = 90;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.TextAlign = ContentAlignment.MiddleRight;
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnVolver
            // 
            btnVolver.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolver.Image = Properties.Resources.volver;
            btnVolver.ImageAlign = ContentAlignment.MiddleLeft;
            btnVolver.Location = new Point(501, 380);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(113, 36);
            btnVolver.TabIndex = 89;
            btnVolver.Text = "VOLVER";
            btnVolver.TextAlign = ContentAlignment.MiddleRight;
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // pictureBox10
            // 
            pictureBox10.BackColor = Color.FromArgb(53, 47, 80);
            pictureBox10.Location = new Point(0, 354);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(803, 97);
            pictureBox10.TabIndex = 92;
            pictureBox10.TabStop = false;
            // 
            // cmbCantCuotas
            // 
            cmbCantCuotas.FormattingEnabled = true;
            cmbCantCuotas.Items.AddRange(new object[] { "1", "3", "6" });
            cmbCantCuotas.Location = new Point(443, 283);
            cmbCantCuotas.Name = "cmbCantCuotas";
            cmbCantCuotas.Size = new Size(70, 23);
            cmbCantCuotas.TabIndex = 93;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Snow;
            label7.Location = new Point(330, 284);
            label7.Name = "label7";
            label7.Size = new Size(107, 17);
            label7.TabIndex = 94;
            label7.Text = "Cantidad Cuotas:";
            // 
            // PagarCuota
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(cmbCantCuotas);
            Controls.Add(btnPagar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnVolver);
            Controls.Add(pictureBox1);
            Controls.Add(label6);
            Controls.Add(cmbEstado);
            Controls.Add(label4);
            Controls.Add(cmbFormaPago);
            Controls.Add(label5);
            Controls.Add(txtIdSocio);
            Controls.Add(buscarSocio);
            Controls.Add(label2);
            Controls.Add(txtDniSocio);
            Controls.Add(label3);
            Controls.Add(txtValor);
            Controls.Add(lblUsuario);
            Controls.Add(label1);
            Controls.Add(pictureBox8);
            Controls.Add(pictureBox10);
            Name = "PagarCuota";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pagar Cuota";
            Load += PargarCuota_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblUsuario;
        private PictureBox pictureBox8;
        private Label label3;
        private TextBox txtValor;
        private Button buscarSocio;
        private Label label2;
        private TextBox txtDniSocio;
        private Label label5;
        private TextBox txtIdSocio;
        private ComboBox cmbFormaPago;
        private Label label4;
        private ComboBox cmbEstado;
        private Label label6;
        private PictureBox pictureBox1;
        private Button btnPagar;
        private Button btnLimpiar;
        private Button btnVolver;
        private PictureBox pictureBox10;
        private ComboBox cmbCantCuotas;
        private Label label7;
    }
}