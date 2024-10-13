﻿using proyecto_final_club_deportivo.Entities;
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
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace proyecto_final_club_deportivo.GUI
{
    public partial class PagarCuota : Form
    {
        internal string? rol;
        internal string? usuario;
        internal CuotaController controller;

        public PagarCuota()
        {
            InitializeComponent();
            controller = new CuotaController();
            cmbEstado.SelectedIndex = 0;
        }

        public PagarCuota(string idSocio, string formaPago)
        {
            InitializeComponent();
            controller = new CuotaController();
            txtIdSocio.Text = idSocio;
            cmbFormaPago.Text = formaPago;
            cmbFormaPago.Enabled = false;
            txtDniSocio.Enabled = false;
        }

        public PagarCuota(string valor, string idSocio, string formaPago, string cantCuotas)
        {
            InitializeComponent();
            controller = new CuotaController();
            txtIdSocio.Text = idSocio;
            cmbFormaPago.Text = formaPago;
            cmbCantCuotas.Text = cantCuotas;
            txtDniSocio.Enabled = false;
            txtValor.Text = valor;
            txtValor.Enabled = false;
        }

        private void PargarCuota_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = "USUARIO: " + usuario + " " + "(" + rol + ")";
            txtValor.ForeColor = Color.Gray;
            txtDniSocio.Text = "DNI";
            txtDniSocio.ForeColor = Color.Gray;
            cmbEstado.SelectedItem = null;
            cmbEstado.SelectedText = "--select--";
            cmbCantCuotas.SelectedIndex = 0;
            cmbCantCuotas.Enabled = false;

            if(cmbFormaPago.Text != "Efectivo")
            {
                cmbFormaPago.SelectedItem = null;
                cmbFormaPago.SelectedText = "--select--";
            }       
            txtDniSocio.Focus();
        }

        private void buscarSocio_Click(object sender, EventArgs e)
        {
            if (txtDniSocio.Text.Equals("DNI"))
            {
                MessageBox.Show("Debe ingresar un DNI", "AVISO DEL SISTEMA",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string idCliente = controller.buscarSocio(txtDniSocio.Text);
                if (int.Parse(idCliente) != 0)
                {
                    txtIdSocio.Text = idCliente;
                    txtDniSocio.Text = "DNI";
                    txtIdSocio.ForeColor = Color.Gray;
                }
                else
                {
                    MessageBox.Show("No existen socios con ese DNI", "AVISO DEL SISTEMA",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /**
         * Método que gestiona el pago de una cuota.
         * Si el socio esá siendo inscripto, por lo cual paga su primera cuota, primero
         * generamos la cuota y luego registramos su pago. El primer pago solo puede 
         * realizarse en Efectivo.
         * Si el socio ya estaba inscripto se procede al pago de la cuota generada previamente
         * y se crea la nueva cuota pendiente de pago con vecimiento 30 dias posteriores a la
         * sfecha en la que se realiza el presente pago.
         * **/

        private void btnPagar_Click(object sender, EventArgs e)
        {
            string mensaje = "0";
            string response;
            int id = int.Parse(txtIdSocio.Text);
            double valor = double.Parse(txtValor.Text);
            string respuesta = controller.existeCuotaSocio(id);
            bool convertido = int.TryParse(respuesta, out int codigo);
            if (convertido)
            {
                string formaPago = cmbFormaPago.Text;
                int cantCuotas = int.Parse(cmbCantCuotas.Text);

                // Si no hay cuotas registradas en el sistema entonces es un socio socio y se genera su primera cuota
                if (codigo == 0)
                {     
                    // Se crea en primer lugar la cuota y luego se abona
                    crearCuota(id);
                    mensaje = controller.pagarCuota(id, valor, DateTime.Today, formaPago, cantCuotas);
                }
                // Sino se actualiza el estado de la última a "Pagado" y se genera una nueva para el próximo periodo
                else if (codigo == 1)
                {
                    // Procedemos al pago de la cuota
                    mensaje = controller.pagarCuota(id, valor, DateTime.Today, formaPago, cantCuotas);

                    crearCuota(id);    
                }
                if (int.Parse(mensaje) == 1)
                {
                    MessageBox.Show("Se Pagó con éxito la cuota para el socio DNI: " + txtIdSocio.Text, 
                     "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                else if (int.Parse(mensaje) == 0)
                {
                    MessageBox.Show("OCURRIÓ UN ERROR POR FAVOR NUEVAMENTE", "AVISO DEL SISTEMA",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (int.Parse(mensaje) == 2)
                {
                    MessageBox.Show("LA CUOTA YA EXISTE EN EL SISTEMA", "AVISO DEL SISTEMA",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("OCURRIÓ UN ERROR", "AVISO DEL SISTEMA",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /**
         * Método que verifica la exitencia de cuotas impagas(solo puede habr una sola cuota impaga
         * dado que, luego el socio es inahibiltado) si existe deuda se suman los montos de ambas.
         * **/

        private void btnVerificarDeuda_Click(object sender, EventArgs e)
        {
            // Validamos que el socio no tenga cuotas impagas
            int id = 0;
            double valCuota = 0;
            if (txtIdSocio.Text != "")
            {
                id = int.Parse(txtIdSocio.Text);
                string response = controller.buscarCuotasImpagas(id);
                if (int.Parse(response) != 0)
                {                 
                    MessageBox.Show("El socio DNI: " + txtIdSocio.Text + " registra deuda",
                            "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //CalcularDeudaCuota deuda = new CalcularDeudaCuota(txtIdSocio.Text, cmbFormaPago.Text, cmbCantCuotas.Text);
                    CalcularDeudaCuota deuda = new CalcularDeudaCuota();
                    deuda.usuario = this.usuario;
                    deuda.rol = this.rol;
                    if (deuda.ShowDialog() == DialogResult.OK)
                    {
                        // Obtener el valor del segundo formulario
                        string valor = deuda.valor;

                        // Establecer el valor en el campo de texto del formulario original
                        txtValor.Text = valor;
                    }
                }
                else
                {
                    MessageBox.Show("El socio DNI: " + txtIdSocio.Text + " no registra deuda",
                         "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
            }
            else
            {
                MessageBox.Show("NO SE HA INGRESADO NINGUN SOCIO", "AVISO DEL SISTEMA",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /**
         * Al pagar una cuota se genera automaticamente la próxima cuota a pagar.
         * La fecha de vencimiento de esta nueva cuota será a los 30 dias posteriores
         * a la fecha en la cual se registra el pago.
         * **/

        private void crearCuota(int id)
        {
            if (txtIdSocio.Text != "" && txtValor.Text != "Valor" && txtValor.Text != ""
               && cmbFormaPago.Text != "--select--" && cmbEstado.Text != "--select--")
            {
                double? valor = null;
                DateTime? fechaPago = null;
                DateTime fechaVencimiento = DateTime.Today.AddDays(30);
                string? formaPago = null;
                int cantCuotas = 0;

                bool estado = false;

                Cuota cuota = new Cuota(valor, fechaPago, fechaVencimiento, formaPago, cantCuotas, estado);
                string respuesta = controller.crearCuota(cuota, id);

                bool convertido = int.TryParse(respuesta, out int codigo);
                if (convertido)
                {
                    if (codigo == 1)
                    {
                        MessageBox.Show("Se generó con éxito la couta para el socio DNI: " + txtIdSocio.Text
                        , "AVISO DEL SISTEMA",
                        MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }
                    else if (codigo == 0)
                    {
                        MessageBox.Show("OCURRIÓ UN ERROR AL CREAR LA CUOTA", "AVISO DEL SISTEMA",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (codigo == 2)
                    {
                        MessageBox.Show("LA CUOTA YA EXISTE EN EL SISTEMA", "AVISO DEL SISTEMA",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Pagar pagar = new Pagar();
            pagar.usuario = this.usuario;
            pagar.rol = this.rol;
            pagar.Show();
            this.Hide();
        }

        private void cmbFormaPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFormaPago.Text.Equals("Tarjeta de Crédito"))
            {
                cmbCantCuotas.Enabled = true;
            }
            else if (cmbFormaPago.Text.Equals("Efectivo"))
            {
                cmbCantCuotas.Enabled = false;
            }
        }

        private void txtValor_Enter(object sender, EventArgs e)
        {
            if (txtValor.Text == "Valor")
            {
                txtValor.Text = "";
                txtValor.ForeColor = Color.Black;
            }
        }

        private void txtValor_Leave(object sender, EventArgs e)
        {
            if (txtValor.Text == "")
            {
                txtValor.Text = "Valor";
                txtValor.ForeColor = Color.Gray;
            }
        }

        private void txtDniSocio_Enter(object sender, EventArgs e)
        {
            if (txtDniSocio.Text == "DNI")
            {
                txtDniSocio.Text = "";
                txtDniSocio.ForeColor = Color.Black;
            }
        }

        private void txtDniSocio_Leave(object sender, EventArgs e)
        {
            if (txtDniSocio.Text == "")
            {
                txtDniSocio.Text = "DNI";
                txtDniSocio.ForeColor = Color.Gray;
            }
        }
    }
}