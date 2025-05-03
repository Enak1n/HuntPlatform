using HuntPlatform.Domain.Aggregates.Vacancies;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HuntPlatform.DataAccess.Configuration;

internal sealed class VacancyConfiguration : IEntityTypeConfiguration<Vacancy>
{
    public void Configure(EntityTypeBuilder<Vacancy> builder)
    {
        builder.HasKey(x => x.Id);
    }
}

