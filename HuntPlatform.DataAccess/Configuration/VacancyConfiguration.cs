using HuntPlatform.Domain.Aggregates.Vacancies;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HuntPlatform.DataAccess.Configuration;

internal sealed class VacancyConfiguration : IEntityTypeConfiguration<Vacancy>
{
    public void Configure(EntityTypeBuilder<Vacancy> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Name)
            .IsRequired();

        builder.Property(x => x.Salary)
            .IsRequired();

        builder.Property(x => x.WorkExperience)
            .IsRequired();

        builder
            .OwnsOne(x => x.WorkFormat)
            .Property(workFormat => workFormat.Id)
            .HasColumnName("work_format")
            .IsRequired();

        builder.Property(x => x.Description)
            .IsRequired();

        builder.Property(x => x.DateOfCreation);

        builder.Property(x => x.EditedDate);

        builder.OwnsOne(x => x.Region)
            .Property(x => x.RegionName);
    }
}

