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

        }

        private void CargarFormularioEnPanel(Form formHijo)
        {
            PANEL_PRDUCTOS.Controls.Clear(); 
            formHijo.TopLevel = false; 
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill; 
            PANEL_PRDUCTOS.Controls.Add(formHijo);
            PANEL_PRDUCTOS.Tag = formHijo;
            formHijo.Show();
        }
        SqlConnection conexion = new SqlConnection("server=LAPTOP-BLTEG90B\\SQLEXPRESS; database=MarZel; integrated security=true");
        private void FRM_MAIN_Load(object sender, EventArgs e)
        {
            Panel fondo = new Panel();
            fondo.Dock = DockStyle.Fill;
            fondo.BackColor = Color.FromArgb(55, 71, 79); 
            this.Controls.Add(fondo);
            fondo.SendToBack();
            this.WindowState = FormWindowState.Maximized;
            CargarFormularioEnPanel(frm_productos);


        }

    }
}
