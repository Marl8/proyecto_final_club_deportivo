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
    public partial class ListaSociosMora : Form
    {
        internal string? rol;
        internal string? usuario;
        internal SocioController controller;
        private int numFila;
        private string? dniSocio;

        public ListaSociosMora()
        {
            InitializeComponent();
            controller = new SocioController();
        }

        private void ListaSociosMora_Load(object sender, EventArgs e)
        {

            lblUsuario.Text = "USUARIO: " + usuario + " " + "(" + rol + ")";
            cargarTabla();
        }

        private void cargarTabla()
        {
            DateTime fecha = DateTime.Today;
            DataTable tabla = controller.listarSociosEnMora(fecha);

            if (tabla.Rows.Count > 0)
            {
                foreach (DataRow row in tabla.Rows)
                {
                    int renglon = dtgvSociosMora.Rows.Add();
                    dtgvSociosMora.Rows[renglon].Cells[0].Value = row[0].ToString();
                    dtgvSociosMora.Rows[renglon].Cells[1].Value = row[1].ToString();
                    dtgvSociosMora.Rows[renglon].Cells[2].Value = row[2].ToString();
                    dtgvSociosMora.Rows[renglon].Cells[3].Value = row[3].ToString();
                    dtgvSociosMora.Rows[renglon].Cells[4].Value = row[4].ToString();
                    dtgvSociosMora.Rows[renglon].Cells[5].Value = "Pendiente";
                    dtgvSociosMora.Rows[renglon].Cells[6].Value = row[6].ToString();

                    if (dtgvSociosMora.Rows[renglon].Cells[6].Value == "1")
                    {
                        dtgvSociosMora.Rows[renglon].Cells[6].Value = "Activo";
                    }
                    else
                    {
                        dtgvSociosMora.Rows[renglon].Cells[6].Value = "Inactivo";
                    }

                    DateTime fechaVencimiento = Convert.ToDateTime(row[4]);
                    dtgvSociosMora.Rows[renglon].Cells[4].Value = fechaVencimiento.ToString("dd/MM/yyyy");
                }
            }
            else
            {
                MessageBox.Show("No hay Socios morosos","AVISO DEL SISTEMA", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
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

        private void dtgvSociosMora_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            numFila = e.RowIndex;
        }

        /***
         * Método para suspender a un socio en la práctica de actividades por falta de pago.
         * La suspensión no implica su baja por lo cual el socio continuará devengando deuda
         * hasta que esta se haga efectiva.
         * Una vez regularizada su situación será rehabilitado para la práctica de actividades.
         * **/
        private void btnSuspender_Click(object sender, EventArgs e)
        {
            string estado = "0";
            if (numFila < dtgvSociosMora.RowCount)
            {
                this.dniSocio = dtgvSociosMora.Rows[numFila].Cells[3].Value.ToString();
                bool estadoSocio = false;
                estado = controller.modificarEstadoSocio(dniSocio, estadoSocio);
            }
            if (estado == "1")
            {
                MessageBox.Show("Estado del socio modificado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (estado == "0")
            {
                MessageBox.Show("No se pudo modificar el estado del socio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (estado == "2")
            {
                MessageBox.Show("El socio no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dtgvSociosMora.Rows.Clear();
            cargarTabla();
        }
    }
}
