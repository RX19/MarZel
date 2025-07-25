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
        Login_Controller LoginController = new Login_Controller();
        FRM_CLIENTES frm_clientes = new FRM_CLIENTES();

        private Producto_Controller Producto_Controller = new Producto_Controller();

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



        }

        private async void MTBC_MENU_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MTBC_MENU.SelectedTab == TP_PRODUCTOS)
            {
                // Verificar productos sin existencia
                DataTable productos = Producto_Controller.ObtenerProductosPorDescripcion();
                var productosSinExistencia = new List<string>();
                foreach (DataRow row in productos.Rows)
                {
                    if (row["EXISTENCIA"] != DBNull.Value && Convert.ToInt32(row["EXISTENCIA"]) == 0)
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

            if (MTBC_MENU.SelectedTab == TP_PROVEEDORES)
            {
                for (double i = 1.0; i >= 0.2; i -= 0.05)
                {
                    this.Opacity = i;
                    await Task.Delay(15);
                }
                this.Visible = false;
                FRM_PROVEEDORES frm_proveedores = new FRM_PROVEEDORES();
                frm_proveedores.ShowDialog();
                this.Visible = true;
                for (double i = 0.2; i <= 1.0; i += 0.05)
                {
                    this.Opacity = i;
                    await Task.Delay(15);
                }
                this.Opacity = 1.0;
                MTBC_MENU.SelectedTab = TP_INICIO;
            }

            if (MTBC_MENU.SelectedTab == TP_COMPRAS)
            {
                for (double i = 1.0; i >= 0.2; i -= 0.05)
                {
                    this.Opacity = i;
                    await Task.Delay(15);
                }
                this.Visible = false;
                FRM_COMPRAS frm_compras = new FRM_COMPRAS();
                frm_compras.ShowDialog();
                this.Visible = true;
                for (double i = 0.2; i <= 1.0; i += 0.05)
                {
                    this.Opacity = i;
                    await Task.Delay(15);
                }
                this.Opacity = 1.0;
                MTBC_MENU.SelectedTab = TP_COMPRAS;
            }

            if (MTBC_MENU.SelectedTab == TP_CLIENTES)
            {
                for (double i = 1.0; i >= 0.2; i -= 0.05)
                {
                    this.Opacity = i;
                    await Task.Delay(15);
                }
                this.Visible = false;
                frm_clientes.ShowDialog();
                this.Visible = true;
                for (double i = 0.2; i <= 1.0; i += 0.05)
                {
                    this.Opacity = i;
                    await Task.Delay(15);
                }
                this.Opacity = 1.0;
                MTBC_MENU.SelectedTab = TP_CLIENTES;
            }

        }

        private void BTN_PRUEBA_Click(object sender, EventArgs e)
        {
            try
            {
                string texto = "Este es un correo de prueba desde el botón.";
                string destinatario = "e1a8lbyje@mozmail.com";//LBL_CORREO.Text; // Correo Prueba

                CorreoHelper.EnviarCorreo(texto, destinatario);
                MessageBox.Show("Correo enviado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al enviar el correo:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
