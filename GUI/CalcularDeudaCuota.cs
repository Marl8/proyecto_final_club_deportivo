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
        internal DateTime vencimiento;

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

                double valorAdeudado = 0;
                DateTime fechaActual = DateTime.Today;

                // Si ya venció el plazo para efectuar el pago de la cuota
                if (this.vencimiento < fechaActual)
                {
                    // Calculamos la cantidad de dias que pasaron desde el vencimiento
                    TimeSpan diferencia = fechaActual.Subtract(vencimiento);

                    // Conviero esa cantidad a int.
                    int numeroDeDias = diferencia.Days;

                    // Prorrateamos el monto de la cuota en 30 dias.
                    double cuotaPorDia = valorCuotaAnterior / 30;
                    
                    // Calculamos el monto a pagar de acuerdo al tiempo transcurrido desde el vencimiento
                    double montoDiasDesdesVencimiento = cuotaPorDia * numeroDeDias;

                    // Aplicamos un recargo del 10% sobre la cuota vencida
                    double recargo = montoDiasDesdesVencimiento * 0.10;

                    // Calculamos el monto total
                    double monto = montoDiasDesdesVencimiento + valorCuotaActual;
                    
                    // Monto final a pagar con el recargo aplicado
                    valorAdeudado = monto + recargo;
                }           

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
