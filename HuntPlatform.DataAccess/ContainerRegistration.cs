using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace HuntPlatform.DataAccess;

public static class ContainerRegistration
{
    public static void DatabaseMigrate(this IServiceProvider serviceProvider)
    {
        using var scope = serviceProvider.CreateScope();
        var db = scope.ServiceProvider.GetRequiredService<DataContext>();

        if (db.Database.IsRelational())
            db.Database.Migrate();
    }
}

