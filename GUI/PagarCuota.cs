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
    public partial class PagarCuota : Form
    {
        internal string? rol;
        internal string? usuario;
        internal CuotaController controller;

        public PagarCuota()
        {
            InitializeComponent();
            controller = new CuotaController();
        }

        public PagarCuota(string idSocio)
        {
            InitializeComponent();
            controller = new CuotaController();
            txtIdSocio.Text = idSocio;
            txtDniSocio.Enabled = false;
            cmbCantCuotas.SelectedItem = cmbCantCuotas.SelectedIndex = 0;
            cmbEstado.Enabled = false;
        }

        private void PargarCuota_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = "USUARIO: " + usuario + " " + "(" + rol + ")";
            txtValor.ForeColor = Color.Gray;
            txtDniSocio.Text = "DNI";
            txtDniSocio.ForeColor = Color.Gray;
            cmbEstado.SelectedItem = null;
            cmbEstado.SelectedText = "--select--";
            cmbFormaPago.SelectedItem = null;
            cmbFormaPago.SelectedText = "--select--";
            cmbCantCuotas.SelectedItem = cmbCantCuotas.SelectedIndex = 0;
            cmbCantCuotas.Enabled = false;
            txtDniSocio.Focus();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Pagar pagar = new Pagar();
            pagar.usuario = this.usuario;
            pagar.rol = this.rol;
            pagar.Show();
            this.Hide();
        }

        private void buscarSocio_Click(object sender, EventArgs e)
        {
            if (txtDniSocio.Text.Equals("DNI"))
            {
                MessageBox.Show("Debe ingresar un DNI", "AVISO DEL SISTEMA",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string idCliente = controller.buscarSocio(txtDniSocio.Text);
                if (int.Parse(idCliente) != 0)
                {
                    txtIdSocio.Text = idCliente;
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

        private void btnPagar_Click(object sender, EventArgs e)
        {
            if (txtIdSocio.Text != "" && txtValor.Text != "Valor" && txtValor.Text != ""
                && cmbFormaPago.Text != "--select--" && cmbEstado.Text != "--select--")
            {
                double valor = double.Parse(txtValor.Text);
                DateTime fechaPago = DateTime.Today;
                DateTime fechaVencimiento = DateTime.Today.AddDays(30);
                string formaPago = cmbEstado.Text;
                int cantCuotas = int.Parse(cmbCantCuotas.Text);

                bool estado = false;
                if (cmbEstado.Text.Equals("Activo"))
                {
                    estado = true;
                }

                Cuota cuota = new Cuota(valor, fechaPago, fechaVencimiento, formaPago, cantCuotas, estado);
                string respuesta = controller.crearCuota(cuota);
                bool convertido = int.TryParse(respuesta, out int codigo);
                if (convertido)
                {
                    if (codigo == 0)
                    {
                        MessageBox.Show("Se generó con éxito la couta para el socio DNI: " + txtIdSocio.Text
                            + respuesta, "AVISO DEL SISTEMA",
                        MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }
                    else
                    {
                        MessageBox.Show("SOCIO YA EXISTE", "AVISO DEL SISTEMA",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void cmbFormaPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFormaPago.Text.Equals("Tarjeta de Crédito"))
            {
                cmbCantCuotas.Enabled = true;
            }
            else if (cmbFormaPago.Text.Equals("Efectivo"))
            {
                cmbCantCuotas.Enabled = false;
            }

        }

        private void txtValor_Enter(object sender, EventArgs e)
        {
            if (txtValor.Text == "Valor")
            {
                txtValor.Text = "";
                txtValor.ForeColor = Color.Black;
            }
        }

        private void txtValor_Leave(object sender, EventArgs e)
        {
            if (txtValor.Text == "")
            {
                txtValor.Text = "Valor";
                txtValor.ForeColor = Color.Gray;
            }
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
    }
}
