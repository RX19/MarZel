using MaterialSkin;
using System.Data;
using System.Data.SqlClient;
//Prueba
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
        SqlConnection conexion = new SqlConnection("server=LEGION5I\\SQLEXPRESS; database=MarZel; integrated security=true");
        private void FRM_MAIN_Load(object sender, EventArgs e)
        {
            Panel fondo = new Panel();
            fondo.Dock = DockStyle.Fill;
            fondo.BackColor = Color.FromArgb(55, 71, 79); // Gris metálico
            this.Controls.Add(fondo);
            fondo.SendToBack(); // Lo envía al fondo, detrás de los demás controles


        }

        private void materialCard1_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                conexion.Open();
                string query = "SELECT * FROM Productos";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                dgv_productos.DataSource = tabla;
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void TP_INICIO_Click(object sender, EventArgs e)
        {

        }
    }
}
