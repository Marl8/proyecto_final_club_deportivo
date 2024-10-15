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
    public partial class PagoDiario : Form
    {
        internal string? rol;
        internal string? usuario;
        internal double montoTotal = 0;
        internal List<int> ListaIds { get; set; } = new List<int>();
        internal List<double> ListaMontos { get; set; } = new List<double>();
        internal ActividadController controller = new ActividadController();

        public PagoDiario()
        {
            InitializeComponent();
        }

        public PagoDiario(string idNoSocio, string monto, DateTime dia)
        {
            InitializeComponent();
            txtDiaHabilitado.Value = dia;
            txtIdNoSocio.Text = idNoSocio;
            txtMonto.Text = "$ " + monto + ".-";
        }

        private void PagoDiario_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = "USUARIO: " + usuario + " " + "(" + rol + ")";
            txtMonto.Enabled = false;
            txtIdNoSocio.Enabled = false;
            txtDniNoSocio.ForeColor = Color.Gray;
            txtDiaHabilitado.Value = DateTime.Now.Date;
            txtDiaHabilitado.MinDate = DateTime.Now.Date;

            if (montoTotal != 0)
            {
                txtMonto.Text = "$" + montoTotal.ToString() + ".-";
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

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            CalcularPagoActividad calcular = new CalcularPagoActividad();
            calcular.usuario = this.usuario;
            calcular.rol = this.rol;
            calcular.Show();
            this.Hide();
        }

        private void buscarNoSocio_Click(object sender, EventArgs e)
        {
            if (txtDniNoSocio.Text.Equals("DNI"))
            {
                MessageBox.Show("Debe ingresar un DNI", "AVISO DEL SISTEMA",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string idCliente = controller.buscarNoSocio(txtDniNoSocio.Text);
                if (int.Parse(idCliente) != 0)
                {
                    txtIdNoSocio.Text = idCliente;
                }
                else
                {
                    MessageBox.Show("No existen clientes con ese DNI", "AVISO DEL SISTEMA",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /**
         * Pago Diario de Actividad
         * 
         * De acuerdo al modelado un NoSocio puede estar inscripto en varias actividades,
         * sin embargo, puede desear prácticar solo alguna/s de ellas durante determinado dia.
         * Es por ello que se habilita el pago de una o varias actividades diarias.
         * El monto a pagar es generado en la pantalla de CalcularPagoActividades y este
         * asignado en una variable que le es transferida a la Pantalla PagoDiario junto
         * a una lista con los ids de las actividaes a pagar.
         * El siguiente método recorre esa lista y registra el pago para cada una de las 
         * actividades en ella incluidas, actualizando el dia habilitado para la práctica de
         * la actividad en cuestión.
         * NOTA: el cliente puede eligir la fecha a su conveniencia.
         **/
        private void btnPagar_Click(object sender, EventArgs e)
        {
            if (txtDniNoSocio.Text != "" && txtMonto.Text != "0" && this.ListaIds.Count > 0)
            {
                int id = int.Parse(txtIdNoSocio.Text);
                DateTime fecha = txtDiaHabilitado.Value;
                string respuesta = "";

                for (int i = 0; i < this.ListaIds.Count; i++)
                {
                    int idActividad = this.ListaIds[i];
                    double monto = this.ListaMontos[i];
                    respuesta = controller.pagarActividadDiaria(id, idActividad, fecha, monto);
                }

                if (int.Parse(respuesta) == 0)
                {
                    MessageBox.Show("OCURRIÓ UN ERROR INTENTE NUEVAMENTE", "AVISO DEL SISTEMA",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (int.Parse(respuesta) == 1)
                {
                    MessageBox.Show("Se registró con éxito el pago del cliente con Nro. de No socio "
                        + txtIdNoSocio.Text, "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                else if (int.Parse(respuesta) == 2)
                {
                    MessageBox.Show("CLIENTE NO ESTA INSCRIPTO", "AVISO DEL SISTEMA",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtDniNoSocio_Enter(object sender, EventArgs e)
        {
            if (txtDniNoSocio.Text == "DNI")
            {
                txtDniNoSocio.Text = "";
                txtDniNoSocio.ForeColor = Color.Black;
            }
        }

        private void txtDniNoSocio_Leave(object sender, EventArgs e)
        {
            if (txtDniNoSocio.Text == "DNI")
            {
                txtDniNoSocio.Text = "DNI";
                txtDniNoSocio.ForeColor = Color.Gray;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtDniNoSocio.Text = "DNI";
            txtIdNoSocio.Clear();
            txtMonto.Text = "0";
            txtDniNoSocio.ForeColor = Color.Gray;
            txtDiaHabilitado.Value = DateTime.Now.Date;
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
            btnPagar.BackColor = Color.FromArgb(192, 192, 255);
        }

        private void btnPagar_MouseLeave(object sender, EventArgs e)
        {
            btnPagar.BackColor = Color.White;
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
