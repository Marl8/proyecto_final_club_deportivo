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
            double valorCuotaAnterior;
            double valorCuotaActual;
            if (txtValorAnterior.Text != "" && txtValorActual.Text != "")
            {
                bool esNum1 = double.TryParse(txtValorAnterior.Text, out double val1);
                bool esNum2 = double.TryParse(txtValorActual.Text, out double val2);

                if(esNum1 && esNum2)
                {
                    valorCuotaActual = val2;
                    valorCuotaAnterior = val1;
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
                        double cuotaPorDia = valorCuotaActual / 30;

                        // Calculamos el monto a pagar de acuerdo al tiempo transcurrido desde el vencimiento
                        double montoDiasDesdesVencimiento = cuotaPorDia * numeroDeDias;

                        // Calculamos el monto total
                        double monto = montoDiasDesdesVencimiento + valorCuotaAnterior;

                        // Aplicamos un recargo del 10% como interes punitorio
                        double recargo = monto * 0.10;

                        // Monto final a pagar con el recargo aplicado
                        valorAdeudado = monto + recargo;
                        valorAdeudado = Math.Round(valorAdeudado, 2);
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
                    MessageBox.Show("NO SON TIPOS NUMÉRICOS", "AVISO DEL SISTEMA",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
