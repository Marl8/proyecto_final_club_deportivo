﻿using Org.BouncyCastle.Crypto;
using proyecto_final_club_deportivo.GUI;
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

namespace proyecto_final_club_deportivo
{
    public partial class InscribirActividad : Form
    {
        internal ActividadController controller;
        internal string? rol;
        internal string? usuario;
        public string? Monto { get; set; }

        public InscribirActividad()
        {
            InitializeComponent();
            controller = new ActividadController();
        }

        private void InscribirActividad_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = "USUARIO: " + usuario + " " + "(" + rol + ")";
            txtIdActividad.Enabled = false;
            txtIdNoSocio.Enabled = false;
            txtDniNoSocio.ForeColor = Color.Gray;
            txtNombreAct.ForeColor = Color.Gray;
            txtDiaHabilitado.Value = DateTime.Now.Date;
            txtDiaHabilitado.MinDate = DateTime.Now.Date;
            //txtDiaHabilitado.Enabled = false;
        }

        private void buscarActividad_Click(object sender, EventArgs e)
        {
            if (txtNombreAct.Text.Equals("Actividad"))
            {
                MessageBox.Show("Debe ingresar una actividad", "AVISO DEL SISTEMA",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DataTable tablaActividad = controller.buscarActividad(txtNombreAct.Text.ToLower());
                if (tablaActividad.Rows.Count > 0)
                {
                    string idAct = tablaActividad.Rows[0][0].ToString();
                    string nombre = tablaActividad.Rows[0][1].ToString();
                    string valor = tablaActividad.Rows[0][2].ToString();
                    txtIdActividad.Text = idAct;
                    this.Monto = valor;
                }
                else
                {
                    MessageBox.Show("No existe una actividad con ese nombre", "AVISO DEL SISTEMA",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buscarNoSocio_Click(object sender, EventArgs e)
        {
            if (txtDniNoSocio.Text.Equals("DNI"))
            {
                MessageBox.Show("Debe ingresar un DNI", "AVISO DEL SISTEMA",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string idCliente = controller.buscarNoSocio(txtDniNoSocio.Text);
                if (int.Parse(idCliente) != 0)
                {
                    txtIdNoSocio.Text = idCliente;
                }
                else
                {
                    MessageBox.Show("No existen clientes con ese DNI", "AVISO DEL SISTEMA",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnInscribir_Click(object sender, EventArgs e)
        {
            int idActividad;
            int idCliente;
            if (txtIdNoSocio.Text != "" && txtIdActividad.Text != "")
            {
                idActividad = int.Parse(txtIdActividad.Text);
                idCliente = int.Parse(txtIdNoSocio.Text);
               
                //Se asigna el dia habilitado para la práctica de la actividad diaria.
                DateTime diaHabilitado = txtDiaHabilitado.Value;
                string respuesta = controller.inscribirActividad(idCliente, idActividad, diaHabilitado);

                if (int.Parse(respuesta) == 0)
                {
                    MessageBox.Show("OCURRIÓ UN ERROR INTENTE NUEVAMENTE", "AVISO DEL SISTEMA",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (int.Parse(respuesta) == 1)
                {
                    MessageBox.Show("Se inscribió con éxito el cliente con Nro. de No socio "
                        + txtIdNoSocio.Text + " en la actividad " + txtNombreAct.Text.ToUpper(),
                        "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Question);

                    PagoDiario pago = new PagoDiario(txtIdNoSocio.Text, this.Monto, diaHabilitado);
                    pago.usuario = this.usuario;
                    pago.rol = this.rol;
                    pago.ListaIds.Add(idActividad);
                    pago.ListaMontos.Add(int.Parse(this.Monto));
                    pago.Show();
                    this.Hide();
                }
                else if (int.Parse(respuesta) == 2)
                {
                    MessageBox.Show("CLIENTE YA ESTA INSCRIPTO", "AVISO DEL SISTEMA",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Deben completarse los datos faltantes", "AVISO DEL SISTEMA",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            GestionarNoSocios noSocios = new GestionarNoSocios();
            noSocios.usuario = this.usuario;
            noSocios.rol = this.rol;
            noSocios.Show();
            this.Hide();
        }

        private void txtNombreAct_Enter(object sender, EventArgs e)
        {
            if (txtNombreAct.Text == "Actividad")
            {
                txtNombreAct.Text = "";
                txtNombreAct.ForeColor = Color.Black;
            }
        }

        private void txtNombreAct_Leave(object sender, EventArgs e)
        {
            if (txtNombreAct.Text == "")
            {
                txtNombreAct.Text = "Actividad";
                txtNombreAct.ForeColor = Color.Gray;
            }
        }

        private void txtDniNoSocio_Enter(object sender, EventArgs e)
        {
            if (txtDniNoSocio.Text == "DNI")
            {
                txtDniNoSocio.Text = "";
                txtDniNoSocio.ForeColor = Color.Black;
            }
        }

        private void txtDniNoSocio_Leave(object sender, EventArgs e)
        {
            if (txtDniNoSocio.Text == "")
            {
                txtDniNoSocio.Text = "DNI";
                txtDniNoSocio.ForeColor = Color.Gray;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombreAct.Text = "Actividad";
            txtDniNoSocio.Text = "DNI";
            txtIdActividad.Text = "";
            txtIdNoSocio.Text = "";
            txtNombreAct.ForeColor = Color.Gray;
            txtDniNoSocio.ForeColor = Color.Gray;
            txtNombreAct.Focus();
        }

        private void btnLimpiar_MouseMove(object sender, MouseEventArgs e)
        {
            btnLimpiar.BackColor = Color.FromArgb(192, 192, 255);
        }

        private void btnLimpiar_MouseLeave(object sender, EventArgs e)
        {
            btnLimpiar.BackColor = Color.White;
        }

        private void btnInscribir_MouseMove(object sender, MouseEventArgs e)
        {
            btnInscribir.BackColor = Color.FromArgb(192, 192, 255);
        }

        private void btnInscribir_MouseLeave(object sender, EventArgs e)
        {
            btnInscribir.BackColor = Color.White;
        }

        private void btnVolver_MouseMove(object sender, MouseEventArgs e)
        {
            btnVolver.BackColor = Color.FromArgb(192, 192, 255);
        }

        private void btnVolver_MouseLeave(object sender, EventArgs e)
        {
            btnVolver.BackColor = Color.White;
        }
    }
}
