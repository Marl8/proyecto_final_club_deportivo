using Org.BouncyCastle.Tls;
using proyecto_final_club_deportivo.Entities;
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
    public partial class GestionarNoSocios : Form
    {
        internal string? rol;
        internal string? usuario;

        public GestionarNoSocios()
        {
            InitializeComponent();
        }

        private void GestionarNoSocios_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = "USUARIO: " + usuario + " " + "(" + rol + ")";
        }

        private void btnInscribirActividad_Click(object sender, EventArgs e)
        {
            InscribirActividad inscribirActividad = new InscribirActividad();
            inscribirActividad.usuario = usuario;
            inscribirActividad.rol = rol;
            inscribirActividad.Show();
            this.Hide();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();
            principal.usuario = this.usuario;
            principal.rol = this.rol;
            principal.Show();
            this.Hide();
        }

        private void btnListarNoSocios_Click(object sender, EventArgs e)
        {
            ListarNoSocios listar = new ListarNoSocios();
            listar.usuario = this.usuario;
            listar.rol = this.rol;
            listar.Show();
            this.Hide();
        }

        private void btnInscribirActividad_MouseMove(object sender, MouseEventArgs e)
        {
            btnInscribirActividad.BackColor = Color.FromArgb(192, 192, 255);
        }

        private void btnInscribirActividad_MouseLeave(object sender, EventArgs e)
        {
            btnInscribirActividad.BackColor = Color.White;
        }

        private void btnListarNoSocios_MouseMove(object sender, MouseEventArgs e)
        {
            btnListarNoSocios.BackColor = Color.FromArgb(192, 192, 255);
        }

        private void btnListarNoSocios_MouseLeave(object sender, EventArgs e)
        {
            btnListarNoSocios.BackColor = Color.White;
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
