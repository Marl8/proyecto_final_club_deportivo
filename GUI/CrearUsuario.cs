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
    public partial class CrearUsuario : Form
    {
        internal string? rol;
        internal string? usuario;
        UsuarioController usuarioController;

        public CrearUsuario()
        {
            InitializeComponent();
            usuarioController = new UsuarioController();    
        }

        private void CrearUsuario_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = "USUARIO: " + usuario + " " + "(" + rol + ")";
            txtNombre.ForeColor = Color.Gray;
            txtApellido.ForeColor = Color.Gray;
            txtDni.ForeColor = Color.Gray;
            txtEmail.ForeColor = Color.Gray;
            txtTelefono.ForeColor = Color.Gray;
            txtUsername.ForeColor = Color.Gray;
            txtPassword.ForeColor = Color.Gray;
            cmbRol.SelectedItem = null;
            cmbRol.SelectedText = "--select--";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DataTable rol = usuarioController.buscarRol(cmbRol.SelectedItem.ToString());
            int idRol = 0;
            string crearUsuario = "";
            if (rol.Rows.Count > 0)
            {
                idRol = int.Parse(rol.Rows[0][0].ToString());
                string nombre = txtNombre.Text;
                string apellido = txtApellido.Text;
                string username = txtUsername.Text;
                string password = txtPassword.Text;
                string dni = txtDni.Text;
                string email = txtEmail.Text;
                string telefono = txtTelefono.Text;
                string rolName = cmbRol.SelectedItem.ToString();

                if (nombre != "" && apellido != "" && dni != "" && telefono != "" && rolName != "" &&
                    username != "" && email != "" && password != "")
                {
                    string passEncriptado = UsuarioController.getSHA256(password);

                    Usuario user = new Usuario(nombre, apellido, dni, email, telefono, username, passEncriptado, rolName);
                    crearUsuario = usuarioController.crearUsuario(user, idRol);

                    if (crearUsuario.Equals("0"))
                    {
                        MessageBox.Show("OCURRIÓ UN ERROR INTENTE NUEVAMENTE.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("El usuario con id " + crearUsuario + " fue creado con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Faltan Completar Datos (*).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No se encontraron roles con este nombre.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            ListaUsuarios lista = new ListaUsuarios();
            lista.usuario = this.usuario;
            lista.rol = this.rol;
            lista.Show();
            this.Hide();
        }

        private void txtApellido_Enter(object sender, EventArgs e)
        {
            if (txtApellido.Text == "Apellido")
            {
                txtApellido.Text = "";
                txtApellido.ForeColor = Color.Black;
            }
        }

        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text == "Nombre")
            {
                txtNombre.Text = "";
                txtNombre.ForeColor = Color.Black;
            }
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                txtNombre.Text = "Nombre";
                txtNombre.ForeColor = Color.Gray;
            }
        }

        private void txtApellido_Leave(object sender, EventArgs e)
        {
            if (txtApellido.Text == "")
            {
                txtApellido.Text = "Apellido";
                txtApellido.ForeColor = Color.Gray;
            }
        }

        private void txtDni_Enter(object sender, EventArgs e)
        {
            if (txtDni.Text == "DNI")
            {
                txtDni.Text = "";
                txtDni.ForeColor = Color.Black;
            }
        }

        private void txtDni_Leave(object sender, EventArgs e)
        {
            if (txtDni.Text == "")
            {
                txtDni.Text = "DNI";
                txtDni.ForeColor = Color.Gray;
            }
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Email")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.Black;
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "Email";
                txtEmail.ForeColor = Color.Gray;
            }
        }

        private void textUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Username")
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = Color.Black;
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                txtUsername.Text = "Username";
                txtUsername.ForeColor = Color.Gray;
            }
        }

        private void txPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Black;
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Password";
                txtPassword.ForeColor = Color.Gray;
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void txtTelefono_Enter(object sender, EventArgs e)
        {
            if (txtTelefono.Text == "Telefono")
            {
                txtTelefono.Text = "";
                txtTelefono.ForeColor = Color.Black;
            }
        }

        private void txtTelefono_Leave(object sender, EventArgs e)
        {
            if (txtTelefono.Text == "")
            {
                txtTelefono.Text = "Telefono";
                txtTelefono.ForeColor = Color.Gray;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "Nombre";
            txtApellido.Text = "Apellido";
            txtDni.Text = "DNI";
            txtEmail.Text = "Email";
            txtTelefono.Text = "Telefono";
            txtUsername.Text = "Username";
            txtPassword.Text = "Password";
            cmbRol.SelectedItem = null;
            cmbRol.SelectedText = "--select--";
            txtPassword.UseSystemPasswordChar = false;
            txtNombre.ForeColor = Color.Gray;
            txtApellido.ForeColor = Color.Gray;
            txtDni.ForeColor = Color.Gray;
            txtEmail.ForeColor = Color.Gray;
            txtTelefono.ForeColor = Color.Gray;
            txtUsername.ForeColor = Color.Gray;
            txtPassword.ForeColor = Color.Gray;
            txtNombre.Focus();
        }
    }
}
