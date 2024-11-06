using proyecto_final_club_deportivo.Entities;
using proyecto_final_club_deportivo.Logica;
using System.Data;
using System.Windows.Forms;

namespace proyecto_final_club_deportivo.GUI
{
    public partial class ListaUsuarios : Form
    {
        internal string? rol;
        internal string? usuario;
        private DataTable dataTable;
        private int numFila;
        internal UsuarioController usuarioController;

        public ListaUsuarios()
        {
            InitializeComponent();
            this.dataTable = new DataTable();
            usuarioController = new UsuarioController();
        }

        private void ListaUsuarios_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = "USUARIO: " + usuario + " " + "(" + rol + ")";
            txtUsuario.ForeColor = Color.Gray;
            cargarTabla();
            personalizarColumnas();
            txtUsuario.Focus();
        }

        private void cargarTabla()
        {
            this.dataTable = usuarioController.listarUsuarios();
            if (this.dataTable.Rows.Count > 0)
            {
                dtgvUsuarios.DataSource = this.dataTable;
            }
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            cargarTabla();
        }

        private void personalizarColumnas()
        {
            // Cambiar nombres de columnas
            dtgvUsuarios.Columns[0].HeaderText = "Id Usuario";
            dtgvUsuarios.Columns[1].HeaderText = "Nombre";
            dtgvUsuarios.Columns[2].HeaderText = "Apellido";
            dtgvUsuarios.Columns[3].HeaderText = "DNI";
            dtgvUsuarios.Columns[4].HeaderText = "Username";
            dtgvUsuarios.Columns[5].HeaderText = "Rol";

            // Cambiar el ancho de las columnas
            dtgvUsuarios.Columns[0].Width = 66;
            dtgvUsuarios.Columns[1].Width = 130;
            dtgvUsuarios.Columns[2].Width = 130;
            dtgvUsuarios.Columns[3].Width = 95;
            dtgvUsuarios.Columns[4].Width = 100;
            dtgvUsuarios.Columns[5].Width = 115;

            // Personalizamos el header
            dtgvUsuarios.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
            dtgvUsuarios.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe", 9, FontStyle.Bold);
            dtgvUsuarios.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Ajustar tamaño de la grilla
            dtgvUsuarios.Height = dtgvUsuarios.Rows.GetRowsHeight(DataGridViewElementStates.Visible) + dtgvUsuarios.ColumnHeadersHeight;

            // Aplicar los ajustes
            dtgvUsuarios.EnableHeadersVisualStyles = false;
        }

        private void buscarUsuario_Click(object sender, EventArgs e)
        {
            string username = txtUsuario.Text.Trim();

            if (!string.IsNullOrEmpty(username))
            {
                DataView dataView = dataTable.DefaultView;
                dataView.RowFilter = $"Username = '{username}'";
                dtgvUsuarios.DataSource = dataView;
            }
            else
            {
                cargarTabla();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            DataTable usuario = new DataTable();
            string rol = "";
            if (numFila < dtgvUsuarios.RowCount)
            {
                int id = int.Parse(dtgvUsuarios.Rows[numFila].Cells[0].Value.ToString());
                usuario = usuarioController.buscarUsuarioPorId(id);

                if (usuario.Rows.Count > 0)
                {
                    string nombre = usuario.Rows[0][1].ToString();
                    string apellido = usuario.Rows[0][2].ToString();
                    string username = usuario.Rows[0][3].ToString();
                    string dni = usuario.Rows[0][4].ToString();
                    string email = usuario.Rows[0][5].ToString();
                    string telefono = usuario.Rows[0][6].ToString();
                    int fkRol = int.Parse(usuario.Rows[0][7].ToString());

                    if (fkRol == 1)
                    {
                        rol = "Administrador";
                    }
                    else if (fkRol == 2)
                    {
                        rol = "Empleado";
                    }
                    EditarUsuario modificar = new EditarUsuario(nombre, apellido, username, dni, email, telefono, rol);
                    modificar.usuario = this.usuario;
                    modificar.rol = this.rol;
                    modificar.Show();
                    this.Hide();
                }
            }
            if (usuario.Rows.Count <= 0)
            {
                MessageBox.Show("El usuario no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();
            principal.usuario = this.usuario;
            principal.rol = this.rol;
            principal.Show();
            this.Hide();
        }

        private void btnVolver_MouseMove(object sender, MouseEventArgs e)
        {
            btnVolver.BackColor = Color.FromArgb(192, 192, 255);
        }

        private void btnVolver_MouseLeave(object sender, EventArgs e)
        {
            btnVolver.BackColor = Color.White;
        }

        private void dtgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            numFila = e.RowIndex;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (numFila < dtgvUsuarios.RowCount)
            {
                int id = int.Parse(dtgvUsuarios.Rows[numFila].Cells[0].Value.ToString());
                string respuesta = usuarioController.eliminarUsuario(id);
                if (respuesta.Equals("0"))
                {
                    MessageBox.Show("El usuario no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Usuario eliminado con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarTabla();
                }
            }
        }

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            CrearUsuario crear = new CrearUsuario();
            crear.usuario = this.usuario;
            crear.rol = this.rol;
            crear.Show();
            this.Hide();
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Usuario")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.Black;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Usuario";
                txtUsuario.ForeColor = Color.Gray;
            }
        }
    }
}

