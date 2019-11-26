namespace IBERPrime
{
    using System;
    using System.Windows.Forms;

    public static class StartUp
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new IBERPrime());
        }
    }
}