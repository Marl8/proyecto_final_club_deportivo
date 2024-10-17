using proyecto_final_club_deportivo.Datos;
using proyecto_final_club_deportivo.Entities;
using proyecto_final_club_deportivo.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_final_club_deportivo.GUI
{
    public partial class CarnetSocio : Form
    {
        internal int id;
        internal string? nombre;
        internal string? apellido;
        internal string? dni;
        internal string? email;
        internal string? telefono;
        internal bool aptoFisico;
        internal bool estado;
        internal string? rol;
        internal string? usuario;

        public CarnetSocio()
        {
            InitializeComponent();
        }

        private void CarnetSocio_Load(object sender, EventArgs e)
        {
            if (this.id != 0)
            {
                lblFechaExpedicion.Text = DateTime.Now.ToString();
                lblNumSocio.Text = id.ToString();
                lblNombre.Text = this.nombre;
                lblApellido.Text = this.apellido;
                lblDni.Text = this.dni;
                if (this.estado == true)
                {
                    lblEstado.Text = "Activo";
                }
                else
                {
                    lblEstado.Text = "Inactivo";
                }
            }
        }

        // Envia directamente el documento a la impresora

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            btnImprimir.Visible = false;
            btnCancelar.Visible = false;
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.None;

            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(imprimirCarnet);
            pd.Print();
            btnImprimir.Visible = true;
            btnCancelar.Visible = true;

            MessageBox.Show("Operación existosa", "AVISO DEL SISTEMA",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
            Principal principal = new Principal();
            principal.usuario = this.usuario;
            principal.rol = this.rol;
            principal.Show();
            this.Close();
        }

        private void imprimirCarnet(object o, PrintPageEventArgs e)
        {
            // Capturar la imagen del formulario
            Bitmap img = new Bitmap(this.Width, this.Height);
            this.DrawToBitmap(img, new Rectangle(0, 0, this.Width, this.Height));

            // Calcular el factor de escala para ajustar la imagen a la página
            float escalaAncho = (float)e.MarginBounds.Width / (float)img.Width;
            float escalaAlto = (float)e.MarginBounds.Height / (float)img.Height;
            float escala = Math.Min(escalaAncho, escalaAlto);

            // Calcular las nuevas dimensiones
            int nuevoAncho = (int)(img.Width * escala);
            int nuevoAlto = (int)(img.Height * escala);

            // Calcular la posición para centrar la imagen
            int x = (e.PageBounds.Width - nuevoAncho) / 2;
            int y = (e.PageBounds.Height - nuevoAlto) / 2;

            // Dibujar la imagen centrada y escalada
            e.Graphics.DrawImage(img, x, y, nuevoAncho, nuevoAlto);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();
            principal.usuario = this.usuario;
            principal.rol = this.rol;
            principal.Show();
            this.Hide();
        }
    }
}
