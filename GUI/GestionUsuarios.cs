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
    public partial class GestionUsuarios : Form
    {
        internal string? rol;
        internal string? usuario;
        internal UsuarioController usuarioController;

        public GestionUsuarios()
        {
            InitializeComponent();
            usuarioController = new UsuarioController();
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

        private void btnGestionarUsuarios_MouseMove(object sender, MouseEventArgs e)
        {
            btnGestionarUsuarios.BackColor = Color.FromArgb(192, 192, 255);
        }

        private void btnGestionarUsuarios_MouseLeave(object sender, EventArgs e)
        {
            btnGestionarUsuarios.BackColor = Color.White;
        }

        private void btnMiUsuario_MouseMove(object sender, MouseEventArgs e)
        {
            btnMiUsuario.BackColor = Color.FromArgb(192, 192, 255);
        }

        private void btnMiUsuario_MouseLeave(object sender, EventArgs e)
        {
            btnMiUsuario.BackColor = Color.White;
        }

        private void btnGestionarUsuarios_Click(object sender, EventArgs e)
        {
            ListaUsuarios usuario = new ListaUsuarios();
            usuario.usuario = this.usuario;
            usuario.rol = this.rol;
            usuario.Show();
            this.Hide();
        }

        private void btnMiUsuario_Click(object sender, EventArgs e)
        {
            DataTable user = usuarioController.buscarUsuarioPorUsername(this.usuario);
            string rol = "";
            if (user.Rows.Count > 0) {

                string nombre = user.Rows[0][1].ToString();
                string apellido = user.Rows[0][2].ToString();
                string username = user.Rows[0][3].ToString();
                string dni = user.Rows[0][4].ToString();
                string email = user.Rows[0][5].ToString();
                string telefono = user.Rows[0][6].ToString();
                int fkRol = int.Parse(user.Rows[0][7].ToString());

                if (fkRol == 1)
                {
                    rol = "Administrador";
                }
                else if (fkRol == 2)
                {
                    rol = "Empleado";
                }
                EditarUsuario usuario = new EditarUsuario(nombre, apellido, username, dni, email, telefono, rol);
                usuario.usuario = this.usuario;
                usuario.rol = this.rol;
                usuario.Show();
                this.Hide();
            }
            if (user.Rows.Count <= 0)
            {
                MessageBox.Show("El usuario no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (user.Rows.Count > 0)
            {
                MessageBox.Show("Usuario editado con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
