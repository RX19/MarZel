using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading.Tasks;


namespace Prototipo_MarZel
{

    public partial class FRM_PRODUCTOS : MaterialSkin.Controls.MaterialForm
    {
        ProductoController productoController = new ProductoController();
        CategoriaController CategoriaController = new CategoriaController();
        public FRM_PRODUCTOS()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            //this.ControlBox = false;         // Quita los tres botones (cerrar, minimizar, maximizar)
            this.MaximizeBox = false;        // Impide maximizar
            this.Hide();

        }
        private async Task FadeOutAsync(Form form)
        {
            for (double i = 1.0; i >= 0; i -= 0.05)
            {
                form.Opacity = i;
                await Task.Delay(15);
            }
        }
        private async Task FadeInAsync(Form form)
        {
            form.Opacity = 0;
            for (double i = 0; i <= 1.0; i += 0.05)
            {
                form.Opacity = i;
                await Task.Delay(15);
            }
        }

        private async void FRM_PRODUCTOS_Load(object sender, EventArgs e)
        {

            await FadeInAsync(this);
            this.Opacity = 1.0;
        }

    }
}
