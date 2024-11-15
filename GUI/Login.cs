using Org.BouncyCastle.Pqc.Crypto.Lms;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Net;
using System.Windows.Forms;
using proyecto_final_club_deportivo.Logica;
using proyecto_final_club_deportivo.Entities;
using System.Runtime.CompilerServices;
using System.IO;
using System;
using System.Drawing;
using System.Threading.Tasks;

namespace proyecto_final_club_deportivo
{
    public partial class Login : Form
    {
        private string? username;
        private string? rol;
        internal UsuarioController usuarioController;
        private PictureBox spinner;
        public Login()
        {
            InitializeComponent();
            usuarioController = new UsuarioController();
            panelLogin.Visible = false;

            this.spinner = crearSpinner();

            // Agregar los controles al formulario
            this.Controls.Add(spinner);
            this.spinner.Visible = false;

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

        private PictureBox crearSpinner()
        {
            PictureBox pictureBoxSpinner = new PictureBox();
            string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "imagines", "loading.gif");
            pictureBoxSpinner.Image = Properties.Resources.loading; 
            pictureBoxSpinner.Size = new Size(35, 35);
            pictureBoxSpinner.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxSpinner.BackColor = Color.FromArgb(128, Color.Gray);
            pictureBoxSpinner.Left = (this.ClientSize.Width - pictureBoxSpinner.Width) / 2;
            pictureBoxSpinner.Top = pictureBoxSpinner.Bottom + 110;
            return pictureBoxSpinner;
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
            this.spinner.Visible = true;
            this.spinner.BringToFront();
            panelLogin.Visible = true;
            panelLogin.BackColor = Color.FromArgb(128, Color.Gray);
            
            // Inhabilitamos los botones y inputs
            btnIngresar.Enabled = false;
            lblTitulo.BackColor = Color.FromArgb(128, Color.Gray);
            pictureInicio.BackColor= Color.FromArgb(128, Color.Gray);
            txtUsername.Enabled = false;
            txtPassword.Enabled = false;

            // Realizar el login de manera asincrónica
            bool loginSuccess = await PerformLoginAsync();

            // Ocultar el spinner
            this.spinner.Visible = false;
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
                txtPassword.Enabled = true;
                txtUsername.Enabled = true;
                txtUsername.Text = "USUARIO";
                txtUsername.ForeColor = Color.Gray;
                txtPassword.Text = "CONTRASEÑA";
                txtPassword.ForeColor = Color.Gray;
                txtPassword.UseSystemPasswordChar = false;
                btnIngresar.Enabled= true;
                lblTitulo.BackColor = Color.DarkSlateBlue;
                pictureInicio.BackColor = Color.DarkSlateBlue;
                this.spinner.Visible = false;
                panelLogin.Visible = false;
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
