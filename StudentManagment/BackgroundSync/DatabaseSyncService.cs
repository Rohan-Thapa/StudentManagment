using System;
using System.Threading;
using System.Threading.Tasks;
using Dotmim.Sync;
using Dotmim.Sync.SqlServer;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;

namespace StudentManagment.Api.BackgroundSync
{
    public class DatabaseSyncService : BackgroundService
    {
        private readonly IConfiguration _configuration;

        public DatabaseSyncService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                await SyncDatabases();
                Console.WriteLine("Next sync in 65 seconds...");
                await Task.Delay(TimeSpan.FromSeconds(65), stoppingToken);
            }
        }

        private async Task SyncDatabases()
        {
            Console.WriteLine("Starting database synchronization...");

            var primaryDb = _configuration.GetConnectionString("DefaultConnection");
            var backupDb = _configuration.GetConnectionString("BackupConnection");

            var serverProvider = new SqlSyncProvider(primaryDb);
            var clientProvider = new SqlSyncProvider(backupDb);

            // Define which tables to sync
            var setup = new SyncSetup(new string[] { "Students", "Courses", "Enrollments", "Grades" });

            // Sync agent
            var agent = new SyncAgent(clientProvider, serverProvider);

            // Execute sync
            var result = await agent.SynchronizeAsync(setup);
            Console.WriteLine($"Sync completed: {result.TotalChangesUploadedToServer} uploaded, {result.TotalChangesDownloadedFromServer} downloaded.");
        }
    }
}
