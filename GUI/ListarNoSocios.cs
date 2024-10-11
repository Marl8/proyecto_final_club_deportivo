using proyecto_final_club_deportivo.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_final_club_deportivo.GUI
{
    public partial class ListarNoSocios : Form
    {
        internal string? rol;
        internal string? usuario;
        internal NoSocioController controller;

        public ListarNoSocios()
        {
            InitializeComponent();
            controller = new NoSocioController();
        }

        private void ListarNoSocios_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = "USUARIO: " + usuario + " " + "(" + rol + ")";
            dtgvNoSocios.DataSource = controller.listarNoSocios(DateTime.Now.Date);
            personalizarColumnas();
        }

        private void personalizarColumnas()
        {
            // Cambiar nombres de columnas
            dtgvNoSocios.Columns[0].HeaderText = "Id NoSocio";
            dtgvNoSocios.Columns[1].HeaderText = "Nombre";
            dtgvNoSocios.Columns[2].HeaderText = "Apellido";
            dtgvNoSocios.Columns[3].HeaderText = "DNI";
            dtgvNoSocios.Columns[4].HeaderText = "Actividad";
            dtgvNoSocios.Columns[5].HeaderText = "Dia Habilitado";

            // Cambiar el ancho de las columnas
            dtgvNoSocios.Columns[0].Width = 100;
            dtgvNoSocios.Columns[1].Width = 110;
            dtgvNoSocios.Columns[2].Width = 110;
            dtgvNoSocios.Columns[3].Width = 110;
            dtgvNoSocios.Columns[4].Width = 110;
            dtgvNoSocios.Columns[5].Width = 110;

            // Personalizamos el header
            dtgvNoSocios.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
            dtgvNoSocios.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe", 9, FontStyle.Bold);
            dtgvNoSocios.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgvNoSocios.EnableHeadersVisualStyles = false;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();
            principal.usuario = this.usuario;
            principal.rol = this.rol;
            principal.Show();
            this.Hide();
        }

        private void btnVolver_MouseMove(object sender, MouseEventArgs e)
        {
            btnVolver.BackColor = Color.FromArgb(192, 192, 255);
        }

        private void btnVolver_MouseLeave(object sender, EventArgs e)
        {
            btnVolver.BackColor = Color.White;
        }
    }
}
