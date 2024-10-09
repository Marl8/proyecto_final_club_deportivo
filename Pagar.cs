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
    }
}
