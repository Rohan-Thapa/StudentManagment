using StudentManagment.Domain.Interfaces;

namespace StudentManagment.Api.BackgroundSync
{
    public class DatabaseSyncService : BackgroundService
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly ILogger<DatabaseSyncService> _logger;

        public DatabaseSyncService(IServiceProvider serviceProvider, ILogger<DatabaseSyncService> logger)
        {
            _serviceProvider = serviceProvider;
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                var now = DateTime.Now;

                // Scheduled sync at exactly 7 AM or 7 PM.
                if ((now.Hour == 7 || now.Hour == 19) && now.Minute == 0)
                {
                    try
                    {
                        using (var scope = _serviceProvider.CreateScope())
                        {
                            var syncService = scope.ServiceProvider.GetRequiredService<IDataSyncService>();
                            await syncService.SyncDatabasesAsync();
                        }
                        _logger.LogInformation("Scheduled database sync executed at {time}", now);
                    }
                    catch (Exception ex)
                    {
                        _logger.LogError(ex, "Error during scheduled sync at {time}", now);
                    }

                    // Delay to avoid multiple triggers within the same minute.
                    await Task.Delay(TimeSpan.FromMinutes(1), stoppingToken);
                }
                else
                {
                    // Check every 30 seconds.
                    await Task.Delay(TimeSpan.FromSeconds(30), stoppingToken);
                }
            }
        }
    }

}
