using CSharpFunctionalExtensions;
using HuntPlatform.Domain.Aggregates.Vacancies;

namespace HuntPlatform.Domain.Aggregates.Organizations;

public sealed class Organization : Entity<Guid>
{
    private readonly List<Vacancy> _vacancies = new();

    public string Name { get; private set; }

    public string Description { get; private set; }

    public double Rating { get; private set; }

    private Organization(
        Guid id,
        string name,
        string description,
        double rating)
        : base(id)
    {
        Name = name;
        Description = description;
        Rating = rating;
    }

    public IReadOnlyList<Vacancy> Vacancies => _vacancies;

    public static Organization Create(Guid id, string name, string description, double rating)
    {
        return new Organization(id, name, description, rating);
    }
}

