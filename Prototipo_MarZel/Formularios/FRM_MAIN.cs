using MaterialSkin;
using Prototipo_MarZel.Formularios;
using System.Data;
using System.Data.SqlClient;

namespace Prototipo_MarZel
{
    public partial class FRM_MAIN : MaterialSkin.Controls.MaterialForm
    {
        FRM_PRODUCTOS frm_productos = new FRM_PRODUCTOS();
        FRM_ADMINISTRADOR frm_administrador = new FRM_ADMINISTRADOR();
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
        private void FRM_MAIN_Load(object sender, EventArgs e)
        {
            Panel fondo = new Panel();
            fondo.Dock = DockStyle.Fill;
            fondo.BackColor = Color.FromArgb(55, 71, 79);
            this.Controls.Add(fondo);
            fondo.SendToBack();
            this.WindowState = FormWindowState.Maximized;
            CargarFormularioEnPanel(frm_productos);
            //this.ControlBox = false;         // Quita los tres botones (cerrar, minimizar, maximizar)
            this.MaximizeBox = false;        // Impide maximizar
            this.Hide();                                 // this.MinimizeBox = false;        // Impide minimizar
            frm_administrador.ShowDialog();
            Application.Exit();
        }

        private void TP_INICIO_Click(object sender, EventArgs e)
        {

        }

        private void PANEL_PRDUCTOS_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
