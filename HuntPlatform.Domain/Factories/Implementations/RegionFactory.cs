using HuntPlatform.Domain.Aggregates.Vacancies;

namespace HuntPlatform.Domain.Factories.Implementations;

internal class RegionFactory : IRegionFactory
{
    public Task<Region> Create(string regionName) => Task.FromResult(new Region(regionName));
}
