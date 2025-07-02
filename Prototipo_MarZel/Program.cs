using Prototipo_MarZel.Formularios;

namespace Prototipo_MarZel
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            FRM_LOGIN loginForm = new FRM_LOGIN();
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new FRM_MAIN());
            }
            else
            {
                Application.Exit();
            }
        }
    }
}