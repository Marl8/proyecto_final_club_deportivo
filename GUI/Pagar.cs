using proyecto_final_club_deportivo.GUI;
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
    public partial class Pagar : Form
    {
        internal string? rol;
        internal string? usuario;

        public Pagar()
        {
            InitializeComponent();
        }

        private void Pagar_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = "USUARIO: " + usuario + " " + "(" + rol + ")";
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();
            principal.usuario = this.usuario;
            principal.rol = this.rol;
            principal.Show();
            this.Hide();
        }

        private void btnPagarCuota_MouseMove(object sender, MouseEventArgs e)
        {
            btnPagarCuota.BackColor = Color.FromArgb(192, 192, 255);
        }

        private void btnPagarCuota_MouseLeave(object sender, EventArgs e)
        {
            btnPagarCuota.BackColor = Color.White;
        }

        private void btnPagoDiario_MouseMove(object sender, MouseEventArgs e)
        {
            btnPagoDiario.BackColor = Color.FromArgb(192, 192, 255);
        }

        private void btnPagoDiario_MouseLeave(object sender, EventArgs e)
        {
            btnPagoDiario.BackColor = Color.White;
        }

        private void btnVolver_MouseMove(object sender, MouseEventArgs e)
        {
            btnVolver.BackColor = Color.FromArgb(192, 192, 255);
        }

        private void btnVolver_MouseLeave(object sender, EventArgs e)
        {
            btnVolver.BackColor = Color.White;
        }

        private void btnPagoDiario_Click(object sender, EventArgs e)
        {
            PagoDiario pago = new PagoDiario();
            pago.usuario = usuario;
            pago.rol = rol;
            pago.Show();
            this.Hide();
        }

        private void btnPagarCuota_Click(object sender, EventArgs e)
        {
            PagarCuota pargarCuota = new PagarCuota();
            pargarCuota.usuario = usuario;
            pargarCuota.rol = rol; 
            pargarCuota.Show();
            this.Hide();
        }
    }
}
