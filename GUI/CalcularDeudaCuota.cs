using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace proyecto_final_club_deportivo.GUI
{
    public partial class CalcularDeudaCuota : Form
    {
        internal string? rol;
        internal string? usuario;
        internal string? valor;

        public CalcularDeudaCuota()
        {
            InitializeComponent();
        }

        private void CalcularDeudaCuota_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = "USUARIO: " + usuario + " " + "(" + rol + ")";
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtValorAnterior.Text != "" && txtValorActual.Text != "")
            {
                double valorCuotaAnterior = double.Parse(txtValorAnterior.Text);
                double valorCuotaActual = double.Parse(txtValorActual.Text);
                double valorAdeudado = valorCuotaAnterior + valorCuotaActual;

                // Establecer el valor de la propiedad Valor
                this.valor = valorAdeudado.ToString();

                // Establecer el resultado del diálogo a OK
                this.DialogResult = DialogResult.OK;

                // Cerrar el formulario
                this.Close();
            }
            else
            {
                MessageBox.Show("FALTAN COMPLETAR DATOS", "AVISO DEL SISTEMA",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
