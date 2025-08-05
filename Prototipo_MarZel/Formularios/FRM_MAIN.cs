using MaterialSkin;
using MaterialSkin.Controls;
using Prototipo_MarZel.Formularios;
using Prototipo_MarZel.Recursos.Controlador;
using Prototipo_MarZel.Recursos.DAO;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Prototipo_MarZel
{
    //''
    public partial class FRM_MAIN : MaterialSkin.Controls.MaterialForm
    {
        FRM_PRODUCTOS frm_productos = new FRM_PRODUCTOS();
        FRM_USUARIOS frm_usuarios = new FRM_USUARIOS();
        Login_Controller LoginController = new Login_Controller();
        FRM_CLIENTES frm_clientes = new FRM_CLIENTES();
        FRM_REPORTES frm_reportes = new FRM_REPORTES();
        int Id_Usuario;
        string Nombre_Usuario;
        int id_tipo_usuario;

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
            Id_Usuario = Convert.ToInt32(fila["Id_Usuario"]);
            id_tipo_usuario = Convert.ToInt32(fila["ID_TIPO"]);
            Nombre_Usuario = fila["Nombre"].ToString() ?? "";

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
            Existencia_DAO existenciaDao = new Existencia_DAO();
            DataTable productosBajos = existenciaDao.ObtenerProductosBajaExistencia();
            if (id_tipo_usuario == 1)
            {
                if (productosBajos.Rows.Count > 0)
                {
                    DialogResult respuesta = MessageBox.Show(
                        "Se han detectado productos con baja existencia.\n¿Desea recibir un correo con la lista de estos productos?",
                        "Productos con baja existencia",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (respuesta == DialogResult.Yes)
                    {
                        try
                        {
                            string texto = "Adjunto se encuentra la lista de productos con baja existencia.";
                            string destinatario = LBL_CORREO.Text;
                            string rutaPDF = Path.Combine(Application.StartupPath, "ProductosBajos.pdf");

                            PDFHelper.GenerarPDFDesdeDataTable(productosBajos, rutaPDF);
                            CorreoHelper.EnviarCorreo(texto, destinatario, rutaPDF);

                            MessageBox.Show(
                                "Se ha enviado un correo con los productos con bajas existencias.",
                                "Éxito",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                            );
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(
                                "Error al enviar el correo:\n" + ex.Message,
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                            );
                        }
                    }
                }
            }

            if (id_tipo_usuario == 2)
            {
                if (TP_ADMIN.Parent != null)
                    MTBC_MENU.TabPages.Remove(TP_ADMIN);
                MTBC_MENU.TabPages.Remove(TP_REPORTES);
            }


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

                for (double i = 1.0; i >= 0.2; i -= 0.05)
                {
                    this.Opacity = i;
                    await Task.Delay(15);
                }
                this.Visible = false;
                FRM_PRODUCTOS fRM_PRODUCTOS = new FRM_PRODUCTOS();
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
                MTBC_MENU.SelectedTab = TP_INICIO;
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
                MTBC_MENU.SelectedTab = TP_INICIO;
            }

            if (MTBC_MENU.SelectedTab == TP_VENTAS)
            {
                for (double i = 1.0; i >= 0.2; i -= 0.05)
                {
                    this.Opacity = i;
                    await Task.Delay(15);
                }
                this.Visible = false;
                FRM_VENTAS frm_ventas = new FRM_VENTAS(Id_Usuario, Nombre_Usuario);
                frm_ventas.ShowDialog();
                this.Visible = true;
                for (double i = 0.2; i <= 1.0; i += 0.05)
                {
                    this.Opacity = i;
                    await Task.Delay(15);
                }
                this.Opacity = 1.0;
                MTBC_MENU.SelectedTab = TP_INICIO;
            }
            if (MTBC_MENU.SelectedTab == TP_REPORTES)
            {
                for (double i = 1.0; i >= 0.2; i -= 0.05)
                {
                    this.Opacity = i;
                    await Task.Delay(15);
                }
                this.Visible = false;
                frm_reportes.ShowDialog();
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

        private void TP_INICIO_Click(object sender, EventArgs e)
        {

        }

        private void LBL_NOMBRE_USU_Click(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FRM_LOGIN frm_login = new FRM_LOGIN();
            frm_login.ShowDialog();

        }
    }
}
