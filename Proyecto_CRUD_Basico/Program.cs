using Proyecto_CRUD_Basico.Forms;

namespace Proyecto_CRUD_Basico
{
    internal static class Program
    {
        /// <summary>  
        ///  The main entry point for the application.  
        /// </summary>  
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new ProductoForms());
        }
    }
}