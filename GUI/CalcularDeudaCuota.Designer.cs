namespace proyecto_final_club_deportivo.GUI
{
    partial class CalcularDeudaCuota
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
            lblPagar = new Label();
            txtValorAnterior = new TextBox();
            txtValorActual = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnAceptar = new Button();
            btnCancelar = new Button();
            lblUsuario = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lblPagar
            // 
            lblPagar.AutoSize = true;
            lblPagar.BackColor = Color.DarkSlateBlue;
            lblPagar.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblPagar.ForeColor = Color.Snow;
            lblPagar.Location = new Point(98, 40);
            lblPagar.Name = "lblPagar";
            lblPagar.Size = new Size(187, 32);
            lblPagar.TabIndex = 3;
            lblPagar.Text = "Calcular Deuda";
            // 
            // txtValorAnterior
            // 
            txtValorAnterior.Location = new Point(172, 95);
            txtValorAnterior.Name = "txtValorAnterior";
            txtValorAnterior.Size = new Size(100, 23);
            txtValorAnterior.TabIndex = 4;
            // 
            // txtValorActual
            // 
            txtValorActual.Location = new Point(172, 151);
            txtValorActual.Name = "txtValorActual";
            txtValorActual.Size = new Size(100, 23);
            txtValorActual.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(71, 98);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 6;
            label1.Text = "Valor Cuota Base:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Snow;
            label2.Location = new Point(64, 154);
            label2.Name = "label2";
            label2.Size = new Size(108, 15);
            label2.TabIndex = 7;
            label2.Text = "Valor Cuota Actual:";
            // 
            // btnAceptar
            // 
            btnAceptar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAceptar.Location = new Point(88, 205);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(81, 35);
            btnAceptar.TabIndex = 8;
            btnAceptar.Text = "ACEPTAR";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.Location = new Point(204, 205);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(81, 35);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.BackColor = Color.FromArgb(53, 47, 80);
            lblUsuario.ForeColor = Color.Snow;
            lblUsuario.Location = new Point(159, 9);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(0, 15);
            lblUsuario.TabIndex = 80;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(53, 47, 80);
            pictureBox2.Location = new Point(-3, -1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(378, 38);
            pictureBox2.TabIndex = 81;
            pictureBox2.TabStop = false;
            // 
            // CalcularDeudaCuota
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateBlue;
            ClientSize = new Size(372, 264);
            Controls.Add(lblUsuario);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtValorActual);
            Controls.Add(txtValorAnterior);
            Controls.Add(lblPagar);
            Controls.Add(pictureBox2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CalcularDeudaCuota";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CalcularDeudaCuota";
            Load += CalcularDeudaCuota_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPagar;
        private TextBox txtValorAnterior;
        private TextBox txtValorActual;
        private Label label1;
        private Label label2;
        private Button btnAceptar;
        private Button btnCancelar;
        private Label lblUsuario;
        private PictureBox pictureBox2;
    }
}