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
    public partial class GestionListadosSocios : Form
    {
        internal string? rol;
        internal string? usuario;

        public GestionListadosSocios()
        {
            InitializeComponent();
        }

        private void GestionListadosSocios_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = "USUARIO: " + usuario + " " + "(" + rol + ")";
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();
            principal.usuario = this.usuario;
            principal.rol = this.rol;
            principal.Show();
            this.Hide();
        }

        private void btnVencDiarios_Click(object sender, EventArgs e)
        {
            ListaSociosFechaVencimiento lista = new ListaSociosFechaVencimiento();
            lista.usuario = this.usuario;
            lista.rol = this.rol;
            lista.Show();
            this.Hide();
        }

        private void btnSociosMora_Click(object sender, EventArgs e)
        {
            ListaSociosMora lista = new ListaSociosMora();
            lista.usuario = this.usuario;
            lista.rol = this.rol;
            lista.Show();
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

        private void btnVencDiarios_MouseMove(object sender, MouseEventArgs e)
        {
            btnVencDiarios.BackColor = Color.FromArgb(192, 192, 255);
        }

        private void btnVencDiarios_MouseLeave(object sender, EventArgs e)
        {
            btnVencDiarios.BackColor = Color.White;
        }

        private void btnSociosMora_MouseMove(object sender, MouseEventArgs e)
        {
            btnSociosMora.BackColor = Color.FromArgb(192, 192, 255);
        }

        private void btnSociosMora_MouseLeave(object sender, EventArgs e)
        {
            btnSociosMora.BackColor = Color.White;
        }
    }
}
