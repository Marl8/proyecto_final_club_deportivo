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

        private void btnRegistrarSocio_MouseMove(object sender, MouseEventArgs e)
        {
            btnRegistrarSocio.BackColor = Color.DarkSlateBlue;
        }

        private void btnRegistrarSocio_MouseLeave(object sender, EventArgs e)
        {
            btnRegistrarSocio.BackColor = Color.FromArgb(192, 192, 255);
        }

        private void btnImprimirCarnet_MouseMove(object sender, MouseEventArgs e)
        {
            btnImprimirCarnet.BackColor = Color.DarkSlateBlue;
        }

        private void btnImprimirCarnet_MouseLeave(object sender, EventArgs e)
        {
            btnImprimirCarnet.BackColor = Color.FromArgb(192, 192, 255);
        }

        private void btnRegistrarNoSocio_MouseMove(object sender, MouseEventArgs e)
        {

            btnRegistrarNoSocio.BackColor = Color.DarkSlateBlue;
        }

        private void btnRegistrarNoSocio_MouseLeave(object sender, EventArgs e)
        {
            btnRegistrarNoSocio.BackColor = Color.FromArgb(192, 192, 255);
        }

        private void btnInscribirActividad_MouseMove(object sender, MouseEventArgs e)
        {
            btnInscribirActividad.BackColor = Color.DarkSlateBlue;
        }

        private void btnInscribirActividad_MouseLeave(object sender, EventArgs e)
        {
            btnInscribirActividad.BackColor = Color.FromArgb(192, 192, 255);
        }

        private void btnPagarCuota_MouseMove(object sender, MouseEventArgs e)
        {
            btnPagarCuota.BackColor = Color.DarkSlateBlue;
        }

        private void btnPagarCuota_MouseLeave(object sender, EventArgs e)
        {
            btnPagarCuota.BackColor = Color.FromArgb(192, 192, 255);
        }

        private void btnListarSocios_MouseMove(object sender, MouseEventArgs e)
        {
            btnListarSocios.BackColor = Color.DarkSlateBlue;
        }

        private void btnListarSocios_MouseLeave(object sender, EventArgs e)
        {
            btnListarSocios.BackColor = Color.FromArgb(192, 192, 255);
        }

        private void btnSalir_MouseMove(object sender, MouseEventArgs e)
        {
            btnSalir.BackColor = Color.FromArgb(104, 90, 158);
        }

        private void btnSalir_MouseLeave(object sender, EventArgs e)
        {
            btnSalir.BackColor = Color.FromArgb(192, 192, 255);
        }
    }
}

