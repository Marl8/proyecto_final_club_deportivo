using Org.BouncyCastle.Pqc.Crypto.Lms;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Net;
using System.Windows.Forms;
using proyecto_final_club_deportivo.Logica;

namespace proyecto_final_club_deportivo
{
    public partial class Login : Form
    {
        internal UsuarioController UsuarioController = new UsuarioController();

        public Login()
        {
            InitializeComponent();
            txtUsername.ForeColor = Color.Gray;
            txtPassword.ForeColor = Color.Gray;
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

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable tablaLogin = new DataTable();
            Entities.Usuario user;
            tablaLogin = UsuarioController.login(txtUsername.Text, txtPassword.Text);
            if (tablaLogin.Rows.Count > 0)
            {
                MessageBox.Show("Ingreso exitoso!", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);

                string nombre = tablaLogin.Rows[0][0].ToString();
                string apellido = tablaLogin.Rows[0][1].ToString();
                string dni = tablaLogin.Rows[0][2].ToString();
                string username = tablaLogin.Rows[0][3].ToString();
                string rol = tablaLogin.Rows[0][4].ToString();
                user = new Entities.Usuario(nombre, apellido, dni, username, rol);

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
