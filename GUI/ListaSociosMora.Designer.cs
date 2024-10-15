namespace proyecto_final_club_deportivo.GUI
{
    partial class ListaSociosMora
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            lblUsuario = new Label();
            pictureBox8 = new PictureBox();
            label1 = new Label();
            btnVolver = new Button();
            dtgvSociosMora = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            Dni = new DataGridViewTextBoxColumn();
            FechaVenc = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            EstadoSocio = new DataGridViewTextBoxColumn();
            btnSuspender = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgvSociosMora).BeginInit();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.BackColor = Color.FromArgb(53, 47, 80);
            lblUsuario.ForeColor = Color.Snow;
            lblUsuario.Location = new Point(529, 9);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(0, 15);
            lblUsuario.TabIndex = 48;
            // 
            // pictureBox8
            // 
            pictureBox8.BackColor = Color.FromArgb(53, 47, 80);
            pictureBox8.Location = new Point(-1, -1);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(805, 42);
            pictureBox8.TabIndex = 73;
            pictureBox8.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkSlateBlue;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(140, 65);
            label1.Name = "label1";
            label1.Size = new Size(408, 30);
            label1.TabIndex = 74;
            label1.Text = "LISTA DE SOCIOS CON CUOTA VENCIDA";
            // 
            // btnVolver
            // 
            btnVolver.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolver.Image = Properties.Resources.volver;
            btnVolver.ImageAlign = ContentAlignment.MiddleLeft;
            btnVolver.Location = new Point(696, 137);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(92, 37);
            btnVolver.TabIndex = 78;
            btnVolver.Text = "VOLVER";
            btnVolver.TextAlign = ContentAlignment.MiddleRight;
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // dtgvSociosMora
            // 
            dtgvSociosMora.BackgroundColor = Color.DarkSlateBlue;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.LightGray;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtgvSociosMora.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtgvSociosMora.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvSociosMora.Columns.AddRange(new DataGridViewColumn[] { Id, Nombre, Apellido, Dni, FechaVenc, Estado, EstadoSocio });
            dtgvSociosMora.EnableHeadersVisualStyles = false;
            dtgvSociosMora.Location = new Point(12, 137);
            dtgvSociosMora.Name = "dtgvSociosMora";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dtgvSociosMora.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dtgvSociosMora.RowTemplate.Height = 25;
            dtgvSociosMora.Size = new Size(670, 301);
            dtgvSociosMora.TabIndex = 79;
            dtgvSociosMora.CellClick += dtgvSociosMora_CellClick;
            // 
            // Id
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            Id.DefaultCellStyle = dataGridViewCellStyle2;
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.Width = 50;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.Width = 115;
            // 
            // Apellido
            // 
            Apellido.HeaderText = "Apellido";
            Apellido.Name = "Apellido";
            Apellido.Width = 115;
            // 
            // Dni
            // 
            Dni.HeaderText = "DNI";
            Dni.Name = "Dni";
            Dni.Width = 80;
            // 
            // FechaVenc
            // 
            FechaVenc.HeaderText = "Fecha Vencimiento";
            FechaVenc.Name = "FechaVenc";
            FechaVenc.Width = 95;
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado Pago";
            Estado.Name = "Estado";
            Estado.Width = 86;
            // 
            // EstadoSocio
            // 
            EstadoSocio.HeaderText = "Estado Socio";
            EstadoSocio.Name = "EstadoSocio";
            EstadoSocio.Width = 86;
            // 
            // btnSuspender
            // 
            btnSuspender.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSuspender.Location = new Point(696, 209);
            btnSuspender.Name = "btnSuspender";
            btnSuspender.Size = new Size(92, 37);
            btnSuspender.TabIndex = 80;
            btnSuspender.Text = "SUSPENDER";
            btnSuspender.UseVisualStyleBackColor = true;
            btnSuspender.Click += btnSuspender_Click;
            // 
            // ListaSociosMora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSuspender);
            Controls.Add(dtgvSociosMora);
            Controls.Add(btnVolver);
            Controls.Add(label1);
            Controls.Add(lblUsuario);
            Controls.Add(pictureBox8);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ListaSociosMora";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lista Socios en Mora";
            Load += ListaSociosMora_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgvSociosMora).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsuario;
        private PictureBox pictureBox8;
        private Label label1;
        private Button btnVolver;
        private DataGridView dtgvSociosMora;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Dni;
        private DataGridViewTextBoxColumn FechaVenc;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewTextBoxColumn EstadoSocio;
        private Button btnSuspender;
    }
}