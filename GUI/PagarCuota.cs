using proyecto_final_club_deportivo.Entities;
using proyecto_final_club_deportivo.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
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
        private string? dni;
        internal CuotaController controller;
        internal SocioController socioController = new SocioController();

        public PagarCuota()
        {
            InitializeComponent();
            controller = new CuotaController();
            cmbEstado.SelectedIndex = 0;
        }

        public PagarCuota(string idSocio, string formaPago, string dni)
        {
            InitializeComponent();
            controller = new CuotaController();
            txtIdSocio.Text = idSocio;
            this.dni = dni;
            cmbFormaPago.Text = formaPago;
            cmbFormaPago.Enabled = false;
            txtDniSocio.Enabled = false;
            txtDniSocio.Focus();
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
            txtDniSocio.Focus();
        }

        private void PargarCuota_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = "USUARIO: " + usuario + " " + "(" + rol + ")";
            txtValor.ForeColor = Color.Gray;
            txtDniSocio.Text = "DNI";
            txtDniSocio.ForeColor = Color.Gray;
            cmbCantCuotas.SelectedIndex = 0;
            cmbCantCuotas.Enabled = false;
            checkValor.Enabled = false;
            checkValor.Visible = false;
            cmbEstado.SelectedIndex = 0;
            cmbFormaPago.SelectedIndex = 0;
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
                this.dni = txtDniSocio.Text;
                string idCliente = controller.buscarIdSocio(this.dni);
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
         * Si el socio esá siendo inscripto, por lo cual paga su primera cuota, se
         * genera la cuota y registra su pago. El primer pago solo puede realizarse 
         * en Efectivo.
         * Si el socio ya estaba inscripto se procede al pago de la cuota y fija la fecha
         * de vencimiento de la cuota siguiente a los 30 dias posteriores de la fecha en 
         * la que se realiza el presente pago.
         * **/

        private void btnPagar_Click(object sender, EventArgs e)
        {
            if (txtIdSocio.Text != "" && txtValor.Text != "Valor" && txtValor.Text != ""
               && cmbFormaPago.Text != "--select--" && cmbEstado.Text != "--select--")
            {
                string mensaje = "0";
                string response;
                int id = int.Parse(txtIdSocio.Text);
                double valor;
                bool esNum = double.TryParse(txtValor.Text, out double val);
                if (esNum)
                {
                    valor = val;
                    string respuesta = controller.existeCuotaSocio(id);
                    bool convertido = int.TryParse(respuesta, out int codigo);
                    if (convertido)
                    {
                        string formaPago = cmbFormaPago.Text;
                        int cantCuotas = int.Parse(cmbCantCuotas.Text);

                        // Si no hay cuotas registradas en el sistema entonces es un socio socio y se genera su primera cuota
                        if (codigo == 0)
                        {
                            /* Se genera la cuota y se abona. 
                             * La fecha de vencimiento al no existir por ser la primer cuota y abonarse al momento 
                             * se fija en el dia del pago. 
                             */
                            DateTime fechaVenc = DateTime.Today;
                            crearCuota(id, fechaVenc);

                            GestionarCarnet carnet = new GestionarCarnet(txtIdSocio.Text, this.dni);
                            carnet.usuario = this.usuario;
                            carnet.rol = this.rol;
                            carnet.Show();
                            this.Hide();
                        }
                        // Sino se genera una cuota nueva para el presente periodo
                        else if (codigo == 1)
                        {
                            /* Buscamos la última fecha de próximo vencimiento registrada para el socio,la cual constituye el
                               el plazo de pago para el vecimciento actual */   
                            DateTime resp = controller.buscarFechaVencimiento(id);

                            /* Comparamos fecha de vencimiento con la fecha actual.
                             * Si la fecha de vencimiento es menor entonces el socio está en mora y debe procederse al calculo
                             * de la deuda.
                             * Si el plazo de vencimiento no se cumplió o si el checkBox esta en estado TRUE 
                             * debido a que ya se calculo la deuda del socio se puede procesar el pago */
                            if (resp > DateTime.Today || checkValor.Checked == true)
                            {
                                crearCuota(id, resp);
                                bool estado = true;
                                socioController.modificarEstadoSocio(this.dni, estado);
                            }
                            else
                            {
                                // Caso contrario debe calcularse la deuda
                                MessageBox.Show("Socio con deuda. Debe liquidarse la deuda para continuar.", "AVISO DEL SISTEMA",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                calcularDeuda(resp);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("OCURRIÓ UN ERROR", "AVISO DEL SISTEMA",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("DEBE INGRESAR UN VALOR NUMÉRICO", "AVISO DEL SISTEMA",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {

                MessageBox.Show("FALTAN COMPLETAR DATOS", "AVISO DEL SISTEMA",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /**
         * Método que verifica la exitencia de deuda.
         * Si existe deuda se procede a su cálculo.
         * **/

        private void btnVerificarDeuda_Click(object sender, EventArgs e)
        {
            // Validamos que el socio no tenga cuotas impagas
            int id;
            if (txtIdSocio.Text != "")
            {
                id = int.Parse(txtIdSocio.Text);
                string response = controller.buscarCuotasImpagas(id);
                if (int.Parse(response) != 0)
                {
                    MessageBox.Show("El socio DNI: " + txtIdSocio.Text + " registra deuda",
                            "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    DateTime resp = controller.buscarFechaVencimiento(id);
                    calcularDeuda(resp);
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

        private void calcularDeuda(DateTime ultimoVencimiento)
        {
            CalcularDeudaCuota deuda = new CalcularDeudaCuota();
            deuda.usuario = this.usuario;
            deuda.rol = this.rol;
            deuda.vencimiento = ultimoVencimiento;
            if (deuda.ShowDialog() == DialogResult.OK)
            {
                // Obtener el valor del segundo formulario
                string valor = deuda.valor;

                // Establecer el valor en el campo de texto del formulario original
                txtValor.Text = valor;
                txtValor.Enabled = false;
                checkValor.Checked = true;
            }
        }

        /**
         * Método que gestiona la creación de la cuota
         **/

        private void crearCuota(int id, DateTime fechaVencimiento)
        {
            if (txtIdSocio.Text != "" && txtValor.Text != "Valor" && txtValor.Text != ""
               && cmbFormaPago.Text != "--select--" && cmbEstado.Text != "--select--")
            {
                double valor;
                bool esNum = double.TryParse(txtValor.Text, out double val);
                if (esNum)
                {
                    valor = val;
                    DateTime fechaPago = DateTime.Today;
                    DateTime fechaProxVenc = DateTime.Today.AddDays(30);
                    DateTime fechaVec = fechaVencimiento;
                    string formaPago = cmbFormaPago.Text;
                    int cantCuotas = int.Parse(cmbCantCuotas.Text);

                    bool estado = true;

                    Cuota cuota = new Cuota(valor, fechaPago, fechaVencimiento, fechaProxVenc, formaPago, cantCuotas, estado);
                    string respuesta = controller.crearCuota(cuota, id);


                    bool convertido = int.TryParse(respuesta, out int codigo);
                    if (convertido)
                    {
                        if (codigo == 1)
                        {
                            MessageBox.Show("Se generó con éxito la cuota para el socio DNI: " + txtIdSocio.Text
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
                else
                {
                    MessageBox.Show("DEBE INGRESAR UN VALOR NUMÉRICO", "AVISO DEL SISTEMA",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtValor.Text = "Valor";
            txtValor.ForeColor = Color.Gray;
            txtDniSocio.Text = "DNI";
            txtDniSocio.ForeColor = Color.Gray;
            txtIdSocio.Clear();
            txtDniSocio.Enabled = true;
            cmbFormaPago.Enabled = true;
            cmbFormaPago.SelectedItem = null;
            cmbFormaPago.SelectedText = "--select--";
            cmbEstado.SelectedItem = null;
            cmbEstado.SelectedText = "--select--";
            cmbCantCuotas.SelectedIndex = 0;
            cmbCantCuotas.Enabled = false;
            checkValor.Enabled = false;
            checkValor.Visible = false;
        }
    }
}
