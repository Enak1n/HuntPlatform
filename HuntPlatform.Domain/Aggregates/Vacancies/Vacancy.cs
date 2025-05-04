using CSharpFunctionalExtensions;
using HuntPlatform.Domain.Aggregates.Vacancies.Exceptions;

namespace HuntPlatform.Domain.Aggregates.Vacancies;

public sealed class Vacancy : Entity<Guid>
{
    public string Name { get; private set; }

    public decimal Salary { get; private set; }

    public byte WorkExperience { get; private set; }

    public WorkFormat WorkFormat { get; private set; }

    public string Description { get; private set; }

    public DateTime DateOfCreation { get; private set; }

    public DateTime EditedDate { get; private set; }

    public Region Region { get; private set; }

    /// <summary>
    /// For DbContext migrations
    /// </summary>
    private Vacancy() { }

    private Vacancy(
        Guid id,
        string name,
        decimal salary,
        byte workExperience,
        WorkFormat workFormat,
        string description,
        DateTime dateOfCreation,
        Region region)
        : base(id)
    {
        Name = name;
        Salary = salary;
        WorkExperience = workExperience;
        WorkFormat = workFormat;
        Description = description;
        DateOfCreation = dateOfCreation;
        EditedDate = dateOfCreation;
        Region = region;
    }

    public static Vacancy Create(Guid id,
        string name,
        decimal salary,
        byte workExperience,
        WorkFormat workFormat,
        string description,
        DateTime dateOfCreation,
        Region region)
    {
        if (string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(name))
            throw new VallidationVacancyException("Vacancy name can not be empty!");

        if (salary < 0)
            throw new VallidationVacancyException("Salary must be greater than zero");

        return new Vacancy(id, name, salary, workExperience, workFormat, description, dateOfCreation, region);
    }
}

