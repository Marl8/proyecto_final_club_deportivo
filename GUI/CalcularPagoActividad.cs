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
    public partial class CalcularPagoActividad : Form
    {
        internal string? rol;
        internal string? usuario;
        internal ActividadController controller = new ActividadController();
        public List<int> ListaIds { get; set; } = new List<int>();
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

        private void buscarActividad_Click(object sender, EventArgs e)
        {
            DataTable tablaActividad = new DataTable();
            Actividad actividad; 
            if(txtNombreAct.Text != "Actividad" && txtNombreAct.Text != "")
            {
                tablaActividad = controller.buscarActividad(txtNombreAct.Text.ToLower());
                string id = tablaActividad.Rows[0][0].ToString();
                string nombre = tablaActividad.Rows[0][1].ToString();
                string valor = tablaActividad.Rows[0][2].ToString();
                int idActividad = int.Parse(id);
                double valorActividad = int.Parse(valor);
                actividad = new Actividad(idActividad, nombre, valorActividad);

                this.ListaIds.Add(actividad.IdActividad);
                this.MontoTotal += actividad.ValorActividad;
                txtIdActividad.Text = actividad.IdActividad.ToString();
                txtValorDiario.Text = "$ " + actividad.ValorActividad.ToString() + ".-";
                txtMontoTotal.Text = "$ " + this.MontoTotal.ToString() + ".-";
            }
            else
            {
                MessageBox.Show("Debe indicarse una actividad", "AVISO DEL SISTEMA",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
