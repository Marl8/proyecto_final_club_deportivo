namespace proyecto_final_club_deportivo.GUI
{
    partial class CalcularPagoActividad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalcularPagoActividad));
            lblPagar = new Label();
            buscarActividad = new Button();
            label2 = new Label();
            txtNombreAct = new TextBox();
            txtIdActividad = new TextBox();
            label4 = new Label();
            txtValorDiario = new TextBox();
            label1 = new Label();
            txtMontoTotal = new TextBox();
            label3 = new Label();
            btnAceptar = new Button();
            btnLimpiar = new Button();
            btnVolver = new Button();
            pictureBox10 = new PictureBox();
            lblUsuario = new Label();
            pictureBox2 = new PictureBox();
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
            lblPagar.Location = new Point(137, 49);
            lblPagar.Name = "lblPagar";
            lblPagar.Size = new Size(204, 40);
            lblPagar.TabIndex = 2;
            lblPagar.Text = "Calcular Pago";
            // 
            // buscarActividad
            // 
            buscarActividad.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buscarActividad.ForeColor = Color.Black;
            buscarActividad.Image = (Image)resources.GetObject("buscarActividad.Image");
            buscarActividad.ImageAlign = ContentAlignment.MiddleLeft;
            buscarActividad.Location = new Point(310, 113);
            buscarActividad.Name = "buscarActividad";
            buscarActividad.Size = new Size(87, 32);
            buscarActividad.TabIndex = 20;
            buscarActividad.Text = "BUSCAR";
            buscarActividad.TextAlign = ContentAlignment.MiddleRight;
            buscarActividad.UseVisualStyleBackColor = true;
            buscarActividad.Click += buscarActividad_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Snow;
            label2.Location = new Point(86, 123);
            label2.Name = "label2";
            label2.Size = new Size(107, 15);
            label2.TabIndex = 19;
            label2.Text = "Nombre Actividad:";
            // 
            // txtNombreAct
            // 
            txtNombreAct.Location = new Point(199, 120);
            txtNombreAct.Name = "txtNombreAct";
            txtNombreAct.Size = new Size(96, 23);
            txtNombreAct.TabIndex = 18;
            txtNombreAct.Text = "Actividad";
            txtNombreAct.Enter += txtNombreAct_Enter;
            txtNombreAct.Leave += txtNombreAct_Leave;
            // 
            // txtIdActividad
            // 
            txtIdActividad.BackColor = Color.LightGray;
            txtIdActividad.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtIdActividad.Location = new Point(167, 167);
            txtIdActividad.Name = "txtIdActividad";
            txtIdActividad.Size = new Size(60, 28);
            txtIdActividad.TabIndex = 36;
            txtIdActividad.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Snow;
            label4.Location = new Point(88, 172);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 35;
            label4.Text = "Id Actividad:";
            // 
            // txtValorDiario
            // 
            txtValorDiario.BackColor = Color.LightGray;
            txtValorDiario.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtValorDiario.Location = new Point(310, 167);
            txtValorDiario.Name = "txtValorDiario";
            txtValorDiario.Size = new Size(87, 28);
            txtValorDiario.TabIndex = 38;
            txtValorDiario.Text = "0";
            txtValorDiario.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(237, 174);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 37;
            label1.Text = "Valor Diario:";
            // 
            // txtMontoTotal
            // 
            txtMontoTotal.BackColor = Color.LightGray;
            txtMontoTotal.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtMontoTotal.Location = new Point(232, 222);
            txtMontoTotal.Name = "txtMontoTotal";
            txtMontoTotal.Size = new Size(119, 28);
            txtMontoTotal.TabIndex = 40;
            txtMontoTotal.Text = "0";
            txtMontoTotal.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Snow;
            label3.Location = new Point(153, 229);
            label3.Name = "label3";
            label3.Size = new Size(74, 15);
            label3.TabIndex = 39;
            label3.Text = "Monto Total:";
            // 
            // btnAceptar
            // 
            btnAceptar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAceptar.Location = new Point(190, 284);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(117, 36);
            btnAceptar.TabIndex = 77;
            btnAceptar.Text = "ACEPTAR";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            btnAceptar.MouseLeave += btnAceptar_MouseLeave;
            btnAceptar.MouseMove += btnAceptar_MouseMove;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimpiar.Image = Properties.Resources.limpiar;
            btnLimpiar.ImageAlign = ContentAlignment.BottomLeft;
            btnLimpiar.Location = new Point(29, 284);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(123, 36);
            btnLimpiar.TabIndex = 76;
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
            btnVolver.Location = new Point(341, 284);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(113, 36);
            btnVolver.TabIndex = 75;
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
            pictureBox10.Location = new Point(-4, 266);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(491, 78);
            pictureBox10.TabIndex = 78;
            pictureBox10.TabStop = false;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.BackColor = Color.FromArgb(53, 47, 80);
            lblUsuario.ForeColor = Color.Snow;
            lblUsuario.Location = new Point(275, 9);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(0, 15);
            lblUsuario.TabIndex = 79;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(53, 47, 80);
            pictureBox2.Location = new Point(-4, -3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(491, 49);
            pictureBox2.TabIndex = 80;
            pictureBox2.TabStop = false;
            // 
            // CalcularPagoActividad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateBlue;
            ClientSize = new Size(487, 344);
            Controls.Add(lblUsuario);
            Controls.Add(btnAceptar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnVolver);
            Controls.Add(txtMontoTotal);
            Controls.Add(label3);
            Controls.Add(txtValorDiario);
            Controls.Add(label1);
            Controls.Add(txtIdActividad);
            Controls.Add(label4);
            Controls.Add(buscarActividad);
            Controls.Add(label2);
            Controls.Add(txtNombreAct);
            Controls.Add(lblPagar);
            Controls.Add(pictureBox10);
            Controls.Add(pictureBox2);
            Name = "CalcularPagoActividad";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calcular Pago Actividad";
            Load += CalcularPagoActividad_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPagar;
        private Button buscarActividad;
        private Label label2;
        private TextBox txtNombreAct;
        private TextBox txtIdActividad;
        private Label label4;
        private TextBox txtValorDiario;
        private Label label1;
        private TextBox txtMontoTotal;
        private Label label3;
        private Button btnAceptar;
        private Button btnLimpiar;
        private Button btnVolver;
        private PictureBox pictureBox10;
        private Label lblUsuario;
        private PictureBox pictureBox2;
    }
}