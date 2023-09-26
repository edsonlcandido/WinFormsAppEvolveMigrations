using EvolveDb;
using Microsoft.Data.Sqlite;
using System.Diagnostics;

namespace WinFormsAppEvolveMigrations
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
            try
            {
                SQLitePCL.raw.SetProvider(new SQLitePCL.SQLite3Provider_e_sqlite3());

                var cnx = new SqliteConnection("Data Source=EvolveMigration.db");
                var evolve = new Evolve(cnx, msg => Debug.WriteLine(msg))
                {
                    Locations = new[] { "Db" },
                    IsEraseDisabled = true,
                };
                evolve.Migrate();
            }
            catch (Exception ex)
            {
                throw;
            }

            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}