namespace proyecto_final_club_deportivo.GUI
{
    partial class ListaUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaUsuarios));
            label1 = new Label();
            pictureBox8 = new PictureBox();
            lblUsuario = new Label();
            btnVolver = new Button();
            dtgvUsuarios = new DataGridView();
            btnCrearUsuario = new Button();
            buscarUsuario = new Button();
            label2 = new Label();
            txtUsuario = new TextBox();
            btnEditar = new Button();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkSlateBlue;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(258, 64);
            label1.Name = "label1";
            label1.Size = new Size(279, 32);
            label1.TabIndex = 3;
            label1.Text = "GESTIÓN DE USUARIOS";
            // 
            // pictureBox8
            // 
            pictureBox8.BackColor = Color.FromArgb(53, 47, 80);
            pictureBox8.Location = new Point(-1, -2);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(837, 52);
            pictureBox8.TabIndex = 72;
            pictureBox8.TabStop = false;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.BackColor = Color.FromArgb(53, 47, 80);
            lblUsuario.ForeColor = Color.Snow;
            lblUsuario.Location = new Point(614, 9);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(0, 15);
            lblUsuario.TabIndex = 73;
            // 
            // btnVolver
            // 
            btnVolver.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolver.Image = Properties.Resources.volver;
            btnVolver.ImageAlign = ContentAlignment.MiddleLeft;
            btnVolver.Location = new Point(712, 388);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(108, 37);
            btnVolver.TabIndex = 77;
            btnVolver.Text = "VOLVER";
            btnVolver.TextAlign = ContentAlignment.MiddleRight;
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            btnVolver.MouseLeave += btnVolver_MouseLeave;
            btnVolver.MouseMove += btnVolver_MouseMove;
            // 
            // dtgvUsuarios
            // 
            dtgvUsuarios.BackgroundColor = Color.DarkSlateBlue;
            dtgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvUsuarios.Location = new Point(12, 184);
            dtgvUsuarios.Name = "dtgvUsuarios";
            dtgvUsuarios.RowTemplate.Height = 25;
            dtgvUsuarios.Size = new Size(679, 241);
            dtgvUsuarios.TabIndex = 78;
            dtgvUsuarios.CellClick += dtgvUsuarios_CellClick;
            // 
            // btnCrearUsuario
            // 
            btnCrearUsuario.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCrearUsuario.Image = (Image)resources.GetObject("btnCrearUsuario.Image");
            btnCrearUsuario.ImageAlign = ContentAlignment.MiddleLeft;
            btnCrearUsuario.Location = new Point(12, 115);
            btnCrearUsuario.Name = "btnCrearUsuario";
            btnCrearUsuario.Size = new Size(148, 40);
            btnCrearUsuario.TabIndex = 79;
            btnCrearUsuario.Text = "NUEVO USUARIO";
            btnCrearUsuario.TextAlign = ContentAlignment.MiddleRight;
            btnCrearUsuario.UseVisualStyleBackColor = true;
            btnCrearUsuario.Click += btnCrearUsuario_Click;
            // 
            // buscarUsuario
            // 
            buscarUsuario.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buscarUsuario.ForeColor = Color.Black;
            buscarUsuario.Image = (Image)resources.GetObject("buscarUsuario.Image");
            buscarUsuario.ImageAlign = ContentAlignment.MiddleLeft;
            buscarUsuario.Location = new Point(602, 119);
            buscarUsuario.Name = "buscarUsuario";
            buscarUsuario.Size = new Size(87, 32);
            buscarUsuario.TabIndex = 82;
            buscarUsuario.Text = "BUSCAR";
            buscarUsuario.TextAlign = ContentAlignment.MiddleRight;
            buscarUsuario.UseVisualStyleBackColor = true;
            buscarUsuario.Click += buscarUsuario_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Snow;
            label2.Location = new Point(501, 129);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 81;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(491, 126);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(96, 23);
            txtUsuario.TabIndex = 80;
            txtUsuario.Text = "Usuario";
            txtUsuario.MouseLeave += txtUsuario_MouseLeave;
            txtUsuario.MouseMove += txtUsuario_MouseMove;
            // 
            // btnEditar
            // 
            btnEditar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditar.Location = new Point(712, 184);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(108, 37);
            btnEditar.TabIndex = 83;
            btnEditar.Text = "EDITAR";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminar.Location = new Point(712, 249);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(108, 37);
            btnEliminar.TabIndex = 84;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // ListaUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateBlue;
            ClientSize = new Size(832, 456);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(buscarUsuario);
            Controls.Add(label2);
            Controls.Add(txtUsuario);
            Controls.Add(btnCrearUsuario);
            Controls.Add(dtgvUsuarios);
            Controls.Add(btnVolver);
            Controls.Add(lblUsuario);
            Controls.Add(label1);
            Controls.Add(pictureBox8);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ListaUsuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión Usuarios";
            Load += ListaUsuarios_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgvUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox8;
        private Label lblUsuario;
        private Button btnVolver;
        private DataGridView dtgvUsuarios;
        private Button btnCrearUsuario;
        private Button buscarUsuario;
        private Label label2;
        private TextBox txtUsuario;
        private Button btnEditar;
        private Button btnEliminar;
    }
}