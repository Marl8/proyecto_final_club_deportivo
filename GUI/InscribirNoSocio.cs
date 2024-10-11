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

namespace proyecto_final_club_deportivo
{
    public partial class InscribirNoSocio : Form
    {
        internal string? rol;
        internal string? usuario;
        internal NoSocioController noSocioController = new NoSocioController();

        public InscribirNoSocio()
        {
            InitializeComponent();
        }

        private void InscribirNoSocio_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = "USUARIO: " + usuario + " " + "(" + rol + ")";
            txtNombre.ForeColor = Color.Gray;
            txtApellido.ForeColor = Color.Gray;
            txtDni.ForeColor = Color.Gray;
            txtEmail.ForeColor = Color.Gray;
            txtTelefono.ForeColor = Color.Gray;
            cmbAptoFisico.SelectedItem = null;
            cmbAptoFisico.SelectedText = "--select--";
        }

        private void btnInscribir_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "Nombre" || txtApellido.Text == "Apellido" || txtDni.Text == "Dni"
                || txtEmail.Text == "Email" || txtTelefono.Text == "Telefono" || cmbAptoFisico.Text == "--select--")
            {
                MessageBox.Show("Debe completar datos requeridos (*) ",
                "AVISO DEL SISTEMA", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            else
            {
                string respuesta;

                bool aptoFisico = false;
                if (cmbAptoFisico.Text.Equals("Si"))
                {
                    aptoFisico = true;
                }

                string nombre = txtNombre.Text;
                string apellido = txtApellido.Text;
                string dni = txtDni.Text;
                string email = txtEmail.Text;
                string telefono = txtTelefono.Text;
                NoSocio noSocio = new NoSocio(aptoFisico, nombre, apellido, dni, email, telefono);

                respuesta = noSocioController.inscribirNoSocio(noSocio);
                bool convertido = int.TryParse(respuesta, out int codigo);
                if (convertido)
                {
                    if (codigo == 1)
                    {
                        MessageBox.Show("SOCIO YA EXISTE", "AVISO DEL SISTEMA",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Se almacenó con éxito el cliente con Nro. de No socio "
                            + respuesta, "AVISO DEL SISTEMA",
                        MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }
                }
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();
            principal.usuario = this.usuario;
            principal.rol = this.rol;
            principal.Show();
            this.Hide();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "Nombre";
            txtApellido.Text = "Apellido";
            txtDni.Text = "DNI";
            txtEmail.Text = "Email";
            txtTelefono.Text = "Telefono";
            cmbAptoFisico.Text = "--select--";
            txtNombre.ForeColor = Color.Gray;
            txtApellido.ForeColor = Color.Gray;
            txtDni.ForeColor = Color.Gray;
            txtEmail.ForeColor = Color.Gray;
            txtTelefono.ForeColor = Color.Gray;
            txtNombre.Focus();
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

        private void txtApellido_Enter(object sender, EventArgs e)
        {
            if (txtApellido.Text == "Apellido")
            {
                txtApellido.Text = "";
                txtApellido.ForeColor = Color.Black;
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

        private void btnLimpiar_MouseMove(object sender, MouseEventArgs e)
        {
            btnLimpiar.BackColor = Color.FromArgb(192, 192, 255);
        }

        private void btnLimpiar_MouseLeave(object sender, EventArgs e)
        {
            btnLimpiar.BackColor = Color.White;
        }

        private void btnInscribir_MouseMove(object sender, MouseEventArgs e)
        {
            btnInscribir.BackColor = Color.FromArgb(192, 192, 255);
        }

        private void btnInscribir_MouseLeave(object sender, EventArgs e)
        {
            btnInscribir.BackColor = Color.White;
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
