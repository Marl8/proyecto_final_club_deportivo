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
    public partial class GestionarCarnet : Form
    {
        internal string? rol;
        internal string? usuario;
        private string? Dni { get; set; }
        internal SocioController controller;

        public GestionarCarnet()
        {
            InitializeComponent();
            controller = new SocioController();
        }

        private void GestionarCarnet_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = "USUARIO: " + usuario + " " + "(" + rol + ")";
            txtDniSocio.ForeColor = Color.Gray;
        }

        private void buscarSocio_Click(object sender, EventArgs e)
        {
            if (txtDniSocio.Text.Equals("DNI") || txtDniSocio.Text.Equals(""))
            {
                MessageBox.Show("Debe ingresar un DNI", "AVISO DEL SISTEMA",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Socio socio = obtenerSocio(txtDniSocio.Text);
                if (socio != null)
                {
                    this.Dni = socio.Dni;
                    txtIdSocio.Text = socio.IdSocio.ToString();
                    txtDniSocio.Text = "DNI";
                    txtIdSocio.ForeColor = Color.Gray;
                }
                else
                {
                    MessageBox.Show("No existen socios con ese DNI", "AVISO DEL SISTEMA",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private Socio obtenerSocio(string idCliente)
        {
            return controller.buscarSocio(idCliente);
        }


        private void btnImprimir_Click(object sender, EventArgs e)
        {
            CarnetSocio carnetSocio = new CarnetSocio();
            if (this.Dni != null)
            {
                Socio socio = obtenerSocio(this.Dni);
                carnetSocio.id = socio.IdSocio;
                carnetSocio.nombre = socio.Nombre;
                carnetSocio.apellido = socio.Apellido;
                carnetSocio.dni = socio.Dni;
                carnetSocio.email = socio.Email;
                carnetSocio.telefono = socio.Telefono;
                carnetSocio.aptoFisico = socio.AptoFisico;
                carnetSocio.estado = socio.EstadoSocio;
                carnetSocio.usuario = this.usuario;
                carnetSocio.rol = this.rol;
                carnetSocio.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("No existen socios con ese DNI", "AVISO DEL SISTEMA",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void txtDniSocio_Enter(object sender, EventArgs e)
        {
            if (txtDniSocio.Text == "DNI")
            {
                txtDniSocio.Text = "";
                txtDniSocio.ForeColor = Color.Black;
            }
        }

        private void txtDniSocio_Leave(object sender, EventArgs e)
        {
            if (txtDniSocio.Text == "")
            {
                txtDniSocio.Text = "DNI";
                txtDniSocio.ForeColor = Color.Gray;
            }
        }

        private void btnVolver_MouseMove(object sender, MouseEventArgs e)
        {
            btnVolver.BackColor = Color.FromArgb(192, 192, 255);
        }

        private void btnVolver_MouseLeave(object sender, EventArgs e)
        {
            btnVolver.BackColor = Color.White;
        }

        private void btnImprimir_MouseMove(object sender, MouseEventArgs e)
        {
            btnImprimir.BackColor = Color.FromArgb(192, 192, 255);

        }

        private void btnImprimir_MouseLeave(object sender, EventArgs e)
        {
            btnImprimir.BackColor = Color.White;
        }
    }
}
