using MaterialSkin;
using MaterialSkin.Controls;
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
            //CargarFormularioEnPanel(frm_productos);
            //this.ControlBox = false;         
            this.MaximizeBox = false;        
            this.Hide();    
            // this.MinimizeBox = false;        
            //frm_administrador.ShowDialog();
            //Application.Exit();
        }

        private async void MTBC_MENU_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MTBC_MENU.SelectedTab == TP_PRODUCTOS)
            {
                for (double i = 1.0; i >= 0.2; i -= 0.05)
                {
                    this.Opacity = i;
                    await Task.Delay(15);
                }

                frm_productos.ShowDialog();

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

                frm_administrador.ShowDialog();

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
