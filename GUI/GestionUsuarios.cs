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
    public partial class GestionUsuarios : Form
    {
        internal string? rol;
        internal string? usuario;

        public GestionUsuarios()
        {
            InitializeComponent();
        }

        private void GestionUsuarios_Load(object sender, EventArgs e)
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

        private void btnVolver_MouseMove(object sender, MouseEventArgs e)
        {
            btnVolver.BackColor = Color.FromArgb(192, 192, 255);
        }

        private void btnVolver_MouseLeave(object sender, EventArgs e)
        {
            btnVolver.BackColor = Color.White;
        }

        private void btnCrearUsusario_MouseMove(object sender, MouseEventArgs e)
        {
            btnCrearUsusario.BackColor = Color.FromArgb(192, 192, 255);
        }

        private void btnCrearUsusario_MouseLeave(object sender, EventArgs e)
        {
            btnCrearUsusario.BackColor = Color.White;
        }

        private void btnModificarUsuario_MouseMove(object sender, MouseEventArgs e)
        {
            btnModificarUsuario.BackColor = Color.FromArgb(192, 192, 255);
        }

        private void btnModificarUsuario_MouseLeave(object sender, EventArgs e)
        {
            btnModificarUsuario.BackColor = Color.White;
        }

        private void btnCrearUsusario_Click(object sender, EventArgs e)
        {
            CrearUsuario usuario = new CrearUsuario();
            usuario.usuario = this.usuario;
            usuario.rol = this.rol;
            usuario.Show();
            this.Hide();
        }

        private void btnModificarUsuario_Click(object sender, EventArgs e)
        {
            ModificarUsuario usuario = new ModificarUsuario();
            usuario.usuario = this.usuario;
            usuario.rol = this.rol;
            usuario.Show();
            this.Hide();
        }
    }
}
