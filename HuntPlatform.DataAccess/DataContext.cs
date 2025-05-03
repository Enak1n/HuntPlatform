using HuntPlatform.DataAccess.Configuration;
using HuntPlatform.Domain.Aggregates.Vacancies;
using Microsoft.EntityFrameworkCore;

namespace HuntPlatform.DataAccess;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {

    }

    public DataContext()
    {

    }

    public DbSet<Vacancy> Vacancies => Set<Vacancy>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new VacancyConfiguration());
    }
}

