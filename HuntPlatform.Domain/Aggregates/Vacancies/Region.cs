using CSharpFunctionalExtensions;

namespace HuntPlatform.Domain.Aggregates.Vacancies;

public sealed class Region : ValueObject
{
    public string RegionName { get; set; }

    internal Region(string regionName)
    {
        RegionName = regionName;
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return RegionName;
    }
}
