namespace Prototipo_MarZel
{
    public partial class FRM_MAIN : Form
    {
        FRM_PRODUCTOS frm_productos = new FRM_PRODUCTOS();
        public FRM_MAIN()
        {
            InitializeComponent();
        }

        private void FRM_MAIN_Load(object sender, EventArgs e)
        {

        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_productos.ShowDialog();
            this.Show();

        }
    }
}
