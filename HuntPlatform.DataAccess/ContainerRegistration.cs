using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Npgsql;

namespace HuntPlatform.DataAccess;

public static class ContainerRegistration
{
    public static IServiceCollection AddDataAccessLayer(this IServiceCollection services, string connectionString)
    {
        services.AddDbContext<DataContext>(
            (serviceProvider, options) =>
            {
                options
                    .UseNpgsql(new NpgsqlConnection(connectionString))
                    .UseSnakeCaseNamingConvention();
            });

        return services;
    }

    public static void DatabaseMigrate(this IServiceProvider serviceProvider)
    {
        using var scope = serviceProvider.CreateScope();
        var db = scope.ServiceProvider.GetRequiredService<DataContext>();

        if (db.Database.IsRelational())
            db.Database.Migrate();
    }
}

