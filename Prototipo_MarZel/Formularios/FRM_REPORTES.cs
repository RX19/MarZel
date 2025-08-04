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
            string path = @"C:\Users\Roberto\Desktop\REPORTES_FINALES.pdf";
            WV_Reportes.Source = new Uri("file:///" + path.Replace("\\", "/"));
        }

        private void FRM_REPORTES_Load(object sender, EventArgs e)
        {

        }
    }
}
