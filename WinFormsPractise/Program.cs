namespace WinFormsPractise
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
            Bank myBank = new Bank();
            Form1 form = new Form1(myBank);
            Application.Run(form);
        }
    }
}