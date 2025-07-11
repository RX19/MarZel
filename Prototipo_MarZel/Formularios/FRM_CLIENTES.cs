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
    public partial class FRM_CLIENTES : MaterialSkin.Controls.MaterialForm
    {
        private string currentRTN = string.Empty;

        public FRM_CLIENTES()
        {
            InitializeComponent();
        }

        private void FRM_CLIENTES_Load(object sender, EventArgs e)
        {

        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void materialButton3_Click(object sender, EventArgs e)
        {
            string rtn = TXT_RTN.Text.Trim();
            if (!string.IsNullOrEmpty(rtn))
            {
                currentRTN = rtn;
                BuscarClientePorRTN(rtn);
            }
        }

        private void BuscarClientePorRTN(string rtn)
        {
            var controller = new clientecontroller();
            var cliente = controller.BuscarCliente(rtn);

            if (cliente != null)
            {
                TXT_NAME.Text = cliente.Nombre;
                TXT_DIR.Text = cliente.Direccion;
                TXT_CEL.Text = cliente.Celular;
                materialButton1.Enabled = true;
                TXT_NAME.Enabled = true;
                TXT_DIR.Enabled = true;
                TXT_CEL.Enabled = true;
            }
            else
            {
                MessageBox.Show("Cliente no encontrado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXT_NAME.Text = string.Empty;
                TXT_DIR.Text = string.Empty;
                TXT_CEL.Text = string.Empty;
                materialButton1.Enabled = false;
                TXT_NAME.Enabled = false;
                TXT_DIR.Enabled = false;
                TXT_CEL.Enabled = false;
            }
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            var controller = new clientecontroller();
            var cliente = new model_cliente
            {
                RTN = currentRTN,
                Nombre = TXT_NAME.Text.Trim(),
                Direccion = TXT_DIR.Text.Trim(),
                Celular = TXT_CEL.Text.Trim()
            };

            bool actualizado = controller.ModificarCliente(cliente);
            if (actualizado)
            {
                MessageBox.Show(
                    $"Cliente modificado correctamente:\n\n" +
                    $"RTN: {cliente.RTN}\n" +
                    $"Nombre: {cliente.Nombre}\n" +
                    $"Dirección: {cliente.Direccion}\n" +
                    $"Celular: {cliente.Celular}",
                    "Modificación Exitosa",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            else
            {
                MessageBox.Show("No se pudo actualizar el cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
