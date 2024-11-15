using System;
using System.Drawing;
using System.Windows.Forms;

namespace proyecto_final_club_deportivo
{
    partial class InscribirActividad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InscribirActividad));
            lblUsuario = new Label();
            pictureBox1 = new PictureBox();
            btnVolver = new Button();
            btnLimpiar = new Button();
            btnInscribir = new Button();
            pictureBox10 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            txtNombreAct = new TextBox();
            label2 = new Label();
            txtDniNoSocio = new TextBox();
            label3 = new Label();
            buscarActividad = new Button();
            buscarNoSocio = new Button();
            label4 = new Label();
            txtIdNoSocio = new TextBox();
            label5 = new Label();
            txtIdActividad = new TextBox();
            txtDiaHabilitado = new DateTimePicker();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.BackColor = Color.FromArgb(53, 47, 80);
            lblUsuario.ForeColor = Color.Snow;
            lblUsuario.Location = new Point(604, 9);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(0, 15);
            lblUsuario.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-2, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(353, 453);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // btnVolver
            // 
            btnVolver.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolver.Image = Properties.Resources.volver;
            btnVolver.ImageAlign = ContentAlignment.MiddleLeft;
            btnVolver.Location = new Point(699, 379);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(113, 36);
            btnVolver.TabIndex = 30;
            btnVolver.Text = "VOLVER";
            btnVolver.TextAlign = ContentAlignment.MiddleRight;
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            btnVolver.MouseLeave += btnVolver_MouseLeave;
            btnVolver.MouseMove += btnVolver_MouseMove;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimpiar.Image = Properties.Resources.limpiar;
            btnLimpiar.ImageAlign = ContentAlignment.BottomLeft;
            btnLimpiar.Location = new Point(387, 379);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(123, 36);
            btnLimpiar.TabIndex = 32;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.TextAlign = ContentAlignment.MiddleRight;
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            btnLimpiar.MouseLeave += btnLimpiar_MouseLeave;
            btnLimpiar.MouseMove += btnLimpiar_MouseMove;
            // 
            // btnInscribir
            // 
            btnInscribir.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnInscribir.Location = new Point(548, 379);
            btnInscribir.Name = "btnInscribir";
            btnInscribir.Size = new Size(117, 36);
            btnInscribir.TabIndex = 33;
            btnInscribir.Text = "INSCRIBIR";
            btnInscribir.UseVisualStyleBackColor = true;
            btnInscribir.Click += btnInscribir_Click;
            btnInscribir.MouseLeave += btnInscribir_MouseLeave;
            btnInscribir.MouseMove += btnInscribir_MouseMove;
            // 
            // pictureBox10
            // 
            pictureBox10.BackColor = Color.FromArgb(53, 47, 80);
            pictureBox10.Location = new Point(348, 355);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(500, 99);
            pictureBox10.TabIndex = 70;
            pictureBox10.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(53, 47, 80);
            pictureBox2.Location = new Point(348, 1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(500, 52);
            pictureBox2.TabIndex = 71;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkSlateBlue;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(458, 65);
            label1.Name = "label1";
            label1.Size = new Size(290, 37);
            label1.TabIndex = 0;
            label1.Text = "Inscribir en Actividad";
            // 
            // txtNombreAct
            // 
            txtNombreAct.Location = new Point(548, 138);
            txtNombreAct.Name = "txtNombreAct";
            txtNombreAct.Size = new Size(109, 23);
            txtNombreAct.TabIndex = 10;
            txtNombreAct.Text = "Actividad";
            txtNombreAct.Enter += txtNombreAct_Enter;
            txtNombreAct.Leave += txtNombreAct_Leave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Snow;
            label2.Location = new Point(435, 141);
            label2.Name = "label2";
            label2.Size = new Size(107, 15);
            label2.TabIndex = 11;
            label2.Text = "Nombre Actividad:";
            // 
            // txtDniNoSocio
            // 
            txtDniNoSocio.Location = new Point(548, 197);
            txtDniNoSocio.Name = "txtDniNoSocio";
            txtDniNoSocio.Size = new Size(109, 23);
            txtDniNoSocio.TabIndex = 12;
            txtDniNoSocio.Text = "DNI";
            txtDniNoSocio.Enter += txtDniNoSocio_Enter;
            txtDniNoSocio.Leave += txtDniNoSocio_Leave;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Snow;
            label3.Location = new Point(474, 200);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 13;
            label3.Text = "Dni Cliente:";
            // 
            // buscarActividad
            // 
            buscarActividad.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buscarActividad.ForeColor = Color.Black;
            buscarActividad.Image = (Image)resources.GetObject("buscarActividad.Image");
            buscarActividad.ImageAlign = ContentAlignment.MiddleLeft;
            buscarActividad.Location = new Point(663, 136);
            buscarActividad.Name = "buscarActividad";
            buscarActividad.Size = new Size(85, 25);
            buscarActividad.TabIndex = 14;
            buscarActividad.Text = "BUSCAR";
            buscarActividad.TextAlign = ContentAlignment.MiddleRight;
            buscarActividad.UseVisualStyleBackColor = true;
            buscarActividad.Click += buscarActividad_Click;
            // 
            // buscarNoSocio
            // 
            buscarNoSocio.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buscarNoSocio.ForeColor = Color.Black;
            buscarNoSocio.Image = (Image)resources.GetObject("buscarNoSocio.Image");
            buscarNoSocio.ImageAlign = ContentAlignment.MiddleLeft;
            buscarNoSocio.Location = new Point(663, 195);
            buscarNoSocio.Name = "buscarNoSocio";
            buscarNoSocio.Size = new Size(85, 25);
            buscarNoSocio.TabIndex = 15;
            buscarNoSocio.Text = "BUSCAR";
            buscarNoSocio.TextAlign = ContentAlignment.MiddleRight;
            buscarNoSocio.UseVisualStyleBackColor = true;
            buscarNoSocio.Click += buscarNoSocio_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Snow;
            label4.Location = new Point(453, 301);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 17;
            label4.Text = "Id Actividad:";
            // 
            // txtIdNoSocio
            // 
            txtIdNoSocio.BackColor = Color.LightGray;
            txtIdNoSocio.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtIdNoSocio.Location = new Point(683, 296);
            txtIdNoSocio.Name = "txtIdNoSocio";
            txtIdNoSocio.Size = new Size(60, 28);
            txtIdNoSocio.TabIndex = 18;
            txtIdNoSocio.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Snow;
            label5.Location = new Point(609, 301);
            label5.Name = "label5";
            label5.Size = new Size(68, 15);
            label5.TabIndex = 19;
            label5.Text = "Id NoSocio:";
            // 
            // txtIdActividad
            // 
            txtIdActividad.BackColor = Color.LightGray;
            txtIdActividad.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtIdActividad.Location = new Point(532, 296);
            txtIdActividad.Name = "txtIdActividad";
            txtIdActividad.Size = new Size(60, 28);
            txtIdActividad.TabIndex = 34;
            txtIdActividad.TextAlign = HorizontalAlignment.Center;
            // 
            // txtDiaHabilitado
            // 
            txtDiaHabilitado.CalendarFont = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtDiaHabilitado.CalendarTitleForeColor = SystemColors.ActiveCaption;
            txtDiaHabilitado.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtDiaHabilitado.Format = DateTimePickerFormat.Custom;
            txtDiaHabilitado.Location = new Point(577, 244);
            txtDiaHabilitado.Name = "txtDiaHabilitado";
            txtDiaHabilitado.Size = new Size(100, 23);
            txtDiaHabilitado.TabIndex = 72;
            txtDiaHabilitado.Value = new DateTime(2024, 10, 9, 0, 0, 0, 0);
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Snow;
            label6.Location = new Point(486, 250);
            label6.Name = "label6";
            label6.Size = new Size(85, 15);
            label6.TabIndex = 73;
            label6.Text = "Dia Habilitado:";
            // 
            // InscribirActividad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateBlue;
            ClientSize = new Size(845, 455);
            Controls.Add(label6);
            Controls.Add(txtDiaHabilitado);
            Controls.Add(btnInscribir);
            Controls.Add(txtIdActividad);
            Controls.Add(btnLimpiar);
            Controls.Add(label5);
            Controls.Add(btnVolver);
            Controls.Add(txtIdNoSocio);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(lblUsuario);
            Controls.Add(buscarNoSocio);
            Controls.Add(pictureBox10);
            Controls.Add(buscarActividad);
            Controls.Add(pictureBox2);
            Controls.Add(label3);
            Controls.Add(txtNombreAct);
            Controls.Add(txtDniNoSocio);
            Controls.Add(label1);
            Controls.Add(label2);
            ForeColor = Color.Black;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "InscribirActividad";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inscribir Actividad";
            Load += InscribirActividad_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblUsuario;
        private PictureBox pictureBox1;
        private Button btnVolver;
        private Button btnLimpiar;
        private Button btnInscribir;
        private PictureBox pictureBox10;
        private PictureBox pictureBox2;
        private Label label1;
        private TextBox txtNombreAct;
        private Label label2;
        private TextBox txtDniNoSocio;
        private Label label3;
        private Button buscarActividad;
        private Button buscarNoSocio;
        private Label label4;
        private TextBox txtIdNoSocio;
        private Label label5;
        private TextBox txtIdActividad;
        private DateTimePicker txtDiaHabilitado;
        private Label label6;
    }
}