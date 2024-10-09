using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_final_club_deportivo
{
    public partial class Principal : Form
    {
        internal string? rol;
        internal string? usuario;

        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = "USUARIO: " + usuario + " " + "(" + rol + ")";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegistrarSocio_Click(object sender, EventArgs e)
        {
            InscribirSocio registrarSocio = new InscribirSocio();
            registrarSocio.usuario = usuario;
            registrarSocio.rol = rol;
            registrarSocio.Show();
            this.Hide();
        }

        private void btnRegistrarNoSocio_Click(object sender, EventArgs e)
        {
            InscribirNoSocio registrarNoSocio = new InscribirNoSocio();
            registrarNoSocio.usuario = usuario;
            registrarNoSocio.rol = rol;
            registrarNoSocio.Show();
            this.Hide();
        }

        private void btnPagarCuota_Click(object sender, EventArgs e)
        {
            Pagar pagar = new Pagar();
            pagar.usuario = usuario;
            pagar.rol = rol;
            pagar.Show();
            this.Hide();
        }

        private void btnInscribirActividad_Click(object sender, EventArgs e)
        {
            InscribirActividad inscribirActividad = new InscribirActividad();
            inscribirActividad.usuario = usuario;
            inscribirActividad.rol = rol;
            inscribirActividad.Show();
            this.Hide();
        }
    }
}

