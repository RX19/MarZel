using MaterialSkin;
using MaterialSkin.Controls;
using Prototipo_MarZel.Formularios;
using Prototipo_MarZel.Recursos.Controlador;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Prototipo_MarZel
{
    public partial class FRM_MAIN : MaterialSkin.Controls.MaterialForm
    {
        FRM_PRODUCTOS frm_productos = new FRM_PRODUCTOS();
        FRM_USUARIOS frm_usuarios = new FRM_USUARIOS();
        LoginController LoginController = new LoginController();
        FRM_CLIENTES frm_clientes = new FRM_CLIENTES();
        private ProductoController productoController = new ProductoController();

        public FRM_MAIN(string usuario)
        {
            InitializeComponent();
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(
                Primary.BlueGrey800,
                Primary.BlueGrey900,
                Primary.BlueGrey500,
                Accent.LightBlue200,
                TextShade.WHITE);

            string usuarioActual = usuario;

            LBL_USUARIO.Text = usuarioActual;

            DataTable tabla_express = LoginController.ObtenerInformacionUsuario(usuarioActual);
            DataRow fila = tabla_express.Rows[0];
            LBL_NOMBRE.Text = fila["Nombre"].ToString();
            LBL_APELLIDO.Text = fila["Apellido"].ToString();
            LBL_CORREO.Text = fila["Correo"].ToString();

        }
        private async Task FadeOutAsync(Form form)
        {
            for (double i = 1.0; i >= 0; i -= 0.05)
            {
                form.Opacity = i;
                await Task.Delay(15); // Ajusta la velocidad
            }
            form.Hide();
        }

        private async Task FadeInAsync(Form form)
        {
            form.Show();
            for (double i = 0; i <= 1.0; i += 0.05)
            {
                form.Opacity = i;
                await Task.Delay(15);
            }
        }

        private void FRM_MAIN_Load(object sender, EventArgs e)
        {
            Panel fondo = new Panel();
            fondo.Dock = DockStyle.Fill;
            fondo.BackColor = Color.FromArgb(55, 71, 79);
            this.Controls.Add(fondo);
            fondo.SendToBack();
            this.WindowState = FormWindowState.Maximized;
            this.MaximizeBox = false;
            this.Hide();
            frm_clientes.ShowDialog();



        }

        private async void MTBC_MENU_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MTBC_MENU.SelectedTab == TP_PRODUCTOS)
            {
                // Verificar productos sin existencia
                DataTable productos = productoController.ObtenerProductosPorDescripcion();
                var productosSinExistencia = new List<string>();
                foreach (DataRow row in productos.Rows)
                {
                    if (row["Cantidad"] != DBNull.Value && Convert.ToInt32(row["Cantidad"]) == 0)
                    {
                        productosSinExistencia.Add(row["Producto"].ToString());
                    }
                }

                if (productosSinExistencia.Count > 0)
                {
                    string mensaje = "Los siguientes productos se quedaron sin existencia:\n\n" +
                                     string.Join("\n", productosSinExistencia);
                    MessageBox.Show(mensaje, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                for (double i = 1.0; i >= 0.2; i -= 0.05)
                {
                    this.Opacity = i;
                    await Task.Delay(15);
                }
                this.Visible = false;
                frm_productos.ShowDialog();
                this.Visible = true;
                for (double i = 0.2; i <= 1.0; i += 0.05)
                {
                    this.Opacity = i;
                    await Task.Delay(15);
                }
                this.Opacity = 1.0;
                MTBC_MENU.SelectedTab = TP_INICIO;
            }

            if (MTBC_MENU.SelectedTab == TP_ADMIN)
            {
                for (double i = 1.0; i >= 0.2; i -= 0.05)
                {
                    this.Opacity = i;
                    await Task.Delay(15);
                }
                this.Visible = false;
                frm_usuarios.ShowDialog();
                this.Visible = true;
                for (double i = 0.2; i <= 1.0; i += 0.05)
                {
                    this.Opacity = i;
                    await Task.Delay(15);
                }
                this.Opacity = 1.0;
                MTBC_MENU.SelectedTab = TP_INICIO;
            }

        }

    }
}
