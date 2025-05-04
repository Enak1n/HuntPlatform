using HuntPlatform.Domain.Aggregates.Vacancies;

namespace HuntPlatform.Domain.Factories;

public interface IRegionFactory
{
    Task<Region> Create(string regionName);
}
