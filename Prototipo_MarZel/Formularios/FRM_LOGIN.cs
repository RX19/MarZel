using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//comentario del formulario
namespace Prototipo_MarZel.Formularios
{
    public partial class FRM_LOGIN : MaterialSkin.Controls.MaterialForm
    {
        public FRM_LOGIN()
        {
            InitializeComponent();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {

            string Username = USR_TXB_LOGIN.Text.Trim();
            string Password = PSW_TXB_LOGIN.Text;
            

        }

        private void SHW_CHK_LOGIN_CheckedChanged(object sender, EventArgs e)
        {
            PSW_TXB_LOGIN.Password = !PSW_TXB_LOGIN.Password;
            PSW_TXB_LOGIN.Focus();
        }

        private void PSW_TXB_LOGIN_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
