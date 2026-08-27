namespace _03day
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Application.Run(new lunbotu());
            //Application.Run(new Form23());
            //Application.Run(new Form45());
            //Application.Run(new Form67());
            //Application.Run(new Form89());
            Application.Run(new keymove());
        }
    }
}