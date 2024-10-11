using proyecto_final_club_deportivo.Entities;
using proyecto_final_club_deportivo.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_final_club_deportivo.GUI
{
    public partial class CalcularPagoActividad : Form
    {
        internal string? rol;
        internal string? usuario;
        internal ActividadController controller = new ActividadController();
        public List<int> ListaIds { get; set; } = new List<int>();
        public List<double> ListaMontos { get; set; } = new List<double>();
        public double MontoTotal { get; set; }

        public CalcularPagoActividad()
        {
            InitializeComponent();
        }

        private void CalcularPagoActividad_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = "USUARIO: " + usuario + " " + "(" + rol + ")";
            txtIdActividad.Enabled = false;
            txtValorDiario.Enabled = false;
            txtMontoTotal.Enabled = false;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            PagoDiario pago = new PagoDiario();
            pago.usuario = this.usuario;
            pago.rol = this.rol;
            pago.Show();
            this.Hide();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            PagoDiario pago = new PagoDiario();
            pago.usuario = this.usuario;
            pago.rol = this.rol;
            pago.montoTotal = this.MontoTotal;
            pago.ListaIds = this.ListaIds;
            pago.ListaMontos = this.ListaMontos;
            pago.Show();
            this.Hide();
        }


        /**
         * El siguiente método busca las actividades inscriptas que el NoSocio desea
         * pagar para su práctica diaria y calcula el monto total a pagar.
         **/
        private void buscarActividad_Click(object sender, EventArgs e)
        {
            DataTable tablaActividad = new DataTable();
            Actividad actividad;
            if (txtNombreAct.Text != "Actividad" && txtNombreAct.Text != "")
            {
                tablaActividad = controller.buscarActividad(txtNombreAct.Text.ToLower());
                if (tablaActividad.Rows.Count > 0)
                {
                    string id = tablaActividad.Rows[0][0].ToString();
                    string nombre = tablaActividad.Rows[0][1].ToString();
                    string valor = tablaActividad.Rows[0][2].ToString();
                    int idActividad = int.Parse(id);
                    double valorActividad = int.Parse(valor);
                    actividad = new Actividad(idActividad, nombre, valorActividad);

                    this.ListaIds.Add(actividad.IdActividad);
                    this.ListaMontos.Add(actividad.ValorActividad);
                    this.MontoTotal += actividad.ValorActividad;
                    txtIdActividad.Text = actividad.IdActividad.ToString();
                    txtValorDiario.Text = "$ " + actividad.ValorActividad.ToString() + ".-";
                    txtMontoTotal.Text = "$ " + this.MontoTotal.ToString() + ".-";
                    txtNombreAct.Text = "Actividad";
                    txtNombreAct.ForeColor = Color.Gray;
                }
                else
                {
                    MessageBox.Show("No existe una actividad con este nombre", "AVISO DEL SISTEMA",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debe indicarse una actividad", "AVISO DEL SISTEMA",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtNombreAct_Enter(object sender, EventArgs e)
        {
            if (txtNombreAct.Text == "Actividad")
            {
                txtNombreAct.Text = "";
                txtNombreAct.ForeColor = Color.Black;
            }
        }

        private void txtNombreAct_Leave(object sender, EventArgs e)
        {
            if (txtNombreAct.Text == "")
            {
                txtNombreAct.Text = "Actividad";
                txtNombreAct.ForeColor = Color.Gray;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombreAct.Text = "Actividad";
            txtNombreAct.ForeColor = Color.Gray;
            txtIdActividad.Clear();
            txtMontoTotal.Text = "0";
            txtValorDiario.Text = "0";
        }

        private void btnLimpiar_MouseMove(object sender, MouseEventArgs e)
        {
            btnLimpiar.BackColor = Color.FromArgb(192, 192, 255);
        }

        private void btnLimpiar_MouseLeave(object sender, EventArgs e)
        {
            btnLimpiar.BackColor = Color.White;
        }

        private void btnAceptar_MouseMove(object sender, MouseEventArgs e)
        {
            btnAceptar.BackColor = Color.FromArgb(192, 192, 255);
        }

        private void btnAceptar_MouseLeave(object sender, EventArgs e)
        {
            btnAceptar.BackColor = Color.White;
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
