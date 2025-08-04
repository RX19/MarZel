using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototipo_MarZel.Formularios
{
    public partial class FRM_REPORTES : MaterialSkin.Controls.MaterialForm
    {
        public FRM_REPORTES()
        {
            InitializeComponent();
            this.Controls.Add(WV_Reportes);
            this.Load += FRM_REPORTES_Load;
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
        private async void FRM_REPORTES_Load(object sender, EventArgs e)
        {
            await FadeInAsync(this);
            this.Opacity = 1.0;

            await WV_Reportes.EnsureCoreWebView2Async();

            string path = Path.Combine(Application.StartupPath, "REPORTES_FINALES.pdf");
            if (File.Exists(path))
            {
                WV_Reportes.Source = new Uri("file:///" + path.Replace("\\", "/"));
            }
            else
            {
                MessageBox.Show("No se encontró el archivo PDF:\n" + path);
            }
        }

        private void FRM_REPORTES_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
               "¿Desea volver al menú principal?",
               "Confirmación",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question
           );

            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
