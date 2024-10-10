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

        public PagoDiario()
        {
            InitializeComponent();
        }

        private void PagoDiario_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = "USUARIO: " + usuario + " " + "(" + rol + ")";
            txtMonto.Enabled = false;
            txtDiaHabilitado.Value = DateTime.Now.Date;
            txtDiaHabilitado.MinDate = DateTime.Now.Date;
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
    }
}
