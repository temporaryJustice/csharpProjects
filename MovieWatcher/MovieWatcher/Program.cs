namespace MovieWatcher
{
    //https://ww25.soap2day.day/series/game-of-thrones-vaqf3-bakgw-5gnga-jk8ke-z5ykj-cy6zq/
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
            Application.Run(new Form1());
        }
    }
}