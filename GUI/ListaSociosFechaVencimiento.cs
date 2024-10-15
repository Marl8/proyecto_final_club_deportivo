using proyecto_final_club_deportivo.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_final_club_deportivo.GUI
{
    public partial class ListaSociosFechaVencimiento : Form
    {
        internal string? rol;
        internal string? usuario;
        internal SocioController controller;

        public ListaSociosFechaVencimiento()
        {
            InitializeComponent();
            controller = new SocioController();
        }

        private void ListaSociosFechaVencimiento_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = "USUARIO: " + usuario + " " + "(" + rol + ")";
            DateTime fecha = DateTime.Today;
            DataTable tabla = controller.listarSociosVencimientoDiario(fecha);

            if (tabla.Rows.Count > 0)
            {
                foreach (DataRow row in tabla.Rows)
                {
                    int renglon = dtgvSocios.Rows.Add();
                    dtgvSocios.Rows[renglon].Cells[0].Value = row[0].ToString();
                    dtgvSocios.Rows[renglon].Cells[1].Value = row[1].ToString();
                    dtgvSocios.Rows[renglon].Cells[2].Value = row[2].ToString();
                    dtgvSocios.Rows[renglon].Cells[3].Value = row[3].ToString();
                    dtgvSocios.Rows[renglon].Cells[4].Value = row[4].ToString();
                    dtgvSocios.Rows[renglon].Cells[5].Value = row[5].ToString();

                    if (dtgvSocios.Rows[renglon].Cells[5].Value == "0")
                    {
                        dtgvSocios.Rows[renglon].Cells[5].Value = "Pendiente";
                    }
                    else {
                        dtgvSocios.Rows[renglon].Cells[5].Value = "Pagado";
                    }
                    DateTime fechaVencimiento = Convert.ToDateTime(row[4]);
                    dtgvSocios.Rows[renglon].Cells[4].Value = fechaVencimiento.ToString("dd/MM/yyyy");
                }
            }
            else
            {
                MessageBox.Show("No hay Socios con vencimiento de cuota en el dia", "AVISO DEL SISTEMA", MessageBoxButtons.OK,
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
    }
}
