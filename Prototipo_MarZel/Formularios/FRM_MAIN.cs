using MaterialSkin;
using System.Data;
using System.Data.SqlClient;

namespace Prototipo_MarZel
{
    public partial class FRM_MAIN : MaterialSkin.Controls.MaterialForm
    {
        FRM_PRODUCTOS frm_productos = new FRM_PRODUCTOS();
        public FRM_MAIN()
        {
            InitializeComponent();
            // Obtener instancia del SkinManager
            var skinManager = MaterialSkinManager.Instance;

            // Registrar este formulario
            skinManager.AddFormToManage(this);

            // Cambiar tema (LIGHT o DARK)
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Cambiar esquema de color primario y secundario
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(
                Primary.BlueGrey800,  // Barra superior y botones
                Primary.BlueGrey900,  // Hover / Click
                Primary.BlueGrey500,  // Claro (no se usa mucho)
                Accent.LightBlue200,  // Detalles como sliders, checkboxes
                TextShade.WHITE);       // Texto blanco en fondo oscuro

        }

        private void CargarFormularioEnPanel(Form formHijo)
        {
            PANEL_PRDUCTOS.Controls.Clear(); // Limpia lo anterior
            formHijo.TopLevel = false; // Lo hace hijo, no ventana independiente
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill; // Ocupa todo el panel
            PANEL_PRDUCTOS.Controls.Add(formHijo);
            PANEL_PRDUCTOS.Tag = formHijo;
            formHijo.Show();
        }
        SqlConnection conexion = new SqlConnection("server=ROBBER\\SQLEXPRESS; database=MarZel; integrated security=true");
        private void FRM_MAIN_Load(object sender, EventArgs e)
        {
            Panel fondo = new Panel();
            fondo.Dock = DockStyle.Fill;
            fondo.BackColor = Color.FromArgb(55, 71, 79); // Gris metálico
            this.Controls.Add(fondo);
            fondo.SendToBack(); // Lo envía al fondo, detrás de los demás controles
            this.WindowState = FormWindowState.Maximized;
            CargarFormularioEnPanel(frm_productos);


        }

    }
}
