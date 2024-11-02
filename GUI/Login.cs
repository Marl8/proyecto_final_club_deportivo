using Org.BouncyCastle.Pqc.Crypto.Lms;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Net;
using System.Windows.Forms;
using proyecto_final_club_deportivo.Logica;
using proyecto_final_club_deportivo.Entities;

namespace proyecto_final_club_deportivo
{
    public partial class Login : Form
    {
        private string? username;
        private string? rol;
        internal UsuarioController usuarioController;

        public Login()
        {
            InitializeComponent();
            usuarioController = new UsuarioController();
            pictureBoxSpinner.Visible = false;

            // Configurar el formulario para aceptar la tecla Enter
            this.AcceptButton = btnIngresar;

            // Agregar eventos KeyPress a los TextBox
            txtUsername.KeyPress += new KeyPressEventHandler(TextBox_KeyPress);
            txtPassword.KeyPress += new KeyPressEventHandler(TextBox_KeyPress);
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtUsername.ForeColor = Color.Gray;
            txtPassword.ForeColor = Color.Gray;
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Si se presiona Enter
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Prevenir el sonido de beep
                e.Handled = true; 
                realizarLogin();
            }
        }

        /**
         * Encriptamos la contraseña con una algoritmo SHA256 ya es considerado muy mala práctica guardar
         * contraseñas planas en la base de datos.
         * Sin embargo, a los fines de facilitar el acceso a la aplicación con el objeto de probar su 
         * funcionamiento se adjuntan los datos de logeo.
         * 
         * USUARIO ROL ADMINISTRADOR:
         * 
         * Username: prueba
         * Password: 123
         * 
         * USUARIO ROL EMPLEADO:
         * Username: fabi
         * Password: 12345
         * **/
        private async void realizarLogin()
        {
            // Mostrar el spinner
            pictureBoxSpinner.Visible = true;
            btnIngresar.Enabled = false;

            // Realizar el login de manera asincrónica
            bool loginSuccess = await PerformLoginAsync();

            // Ocultar el spinner
            pictureBoxSpinner.Visible = false;
            btnIngresar.Enabled = true;

            if (loginSuccess)
            {
                MessageBox.Show("Ingreso exitoso!", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Principal form = new Principal();
                form.usuario = username;
                form.rol = rol;
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario y/o password incorrecto", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Clear();
                txtUsername.Clear();
                txtUsername.Text = "USUARIO";
                txtUsername.ForeColor = Color.Gray;
                txtPassword.Text = "CONTRASEÑA";
                txtPassword.ForeColor = Color.Gray;
                txtPassword.UseSystemPasswordChar = false;
                txtUsername.Focus();
            }
        }

        private async Task<bool> PerformLoginAsync()
        {
            return await Task.Run(() =>
            {
                DataTable tablaLogin = new DataTable();
                Usuario user;
                tablaLogin = usuarioController.login(txtUsername.Text, txtPassword.Text);
                bool existe = tablaLogin.Rows.Count > 0;

                if (existe)
                {
                    string nombre = tablaLogin.Rows[0][0].ToString();
                    string apellido = tablaLogin.Rows[0][1].ToString();
                    string dni = tablaLogin.Rows[0][2].ToString();
                    string username = tablaLogin.Rows[0][3].ToString();
                    string rol = tablaLogin.Rows[0][4].ToString();
                    user = new Usuario(nombre, apellido, dni, username, rol);
                    this.username = user.Username;
                    this.rol = user.Rol;
                }
                return existe;
            });
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            realizarLogin();
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "USUARIO")
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = Color.Black;
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                txtUsername.Text = "USUARIO";
                txtUsername.ForeColor = Color.Gray;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "CONTRASEÑA")
            {
                txtPassword.Text = "";
                txtPassword.UseSystemPasswordChar = true;
                txtPassword.ForeColor = Color.Black;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "CONTRASEÑA";
                txtPassword.ForeColor = Color.Gray;
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void btnIngresar_MouseMove(object sender, MouseEventArgs e)
        {
            btnIngresar.BackColor = Color.FromArgb(192, 192, 255);
        }

        private void btnIngresar_MouseLeave(object sender, EventArgs e)
        {
            btnIngresar.BackColor = Color.White;
        }
    }
}
