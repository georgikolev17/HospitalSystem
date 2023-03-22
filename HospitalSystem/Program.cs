using Data;

namespace HospitalSystem
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static async Task Main()
        {
            // Set up the database
            var db = new ApplicationDbContext();
            await db.Database.EnsureDeletedAsync();
            await db.Database.EnsureCreatedAsync();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // *It was just Application.Run(new LoginForm()); before.
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            Application.Run();
        }
    }
}