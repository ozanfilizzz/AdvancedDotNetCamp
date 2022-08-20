using rentACar.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace rentACar.WebAPI.Extensions
{
    public static class MigrationManager
    {
        public static IHost MigrateDatabase(this IHost host)
        {
            using (var scope = host.Services.CreateScope())
            {
                try
                {
                    var baseContext = scope.ServiceProvider.GetRequiredService<BaseDbContext>();
                    if (baseContext.Database.ProviderName != "Microsoft.EntityFrameworkCore.InMemory")
                    {
                        baseContext.Database.Migrate();
                    }

                    BaseDbContextSeed.SeedAsync(baseContext).Wait();
                }
                catch (Exception)
                {
                    throw;
                }
            }

            return host;
        }
    }
}
