using FANTASYPRUEBAJZ.backend.Repositories.Interfaces;
using FANTASYPRUEBAJZ.backend.UnitofWork.Interfaces;
using FANTASYPRUEBAJZ.shared.Entities;
using FANTASYPRUEBAJZ.shared.Responses;

namespace FANTASYPRUEBAJZ.backend.UnitofWork.Implementations;

public class CountriesUnitOfWork : GenericUnitofWork<Country>, ICountriesUnitOfWork
{
    private readonly ICountriesRepository _countriesRepository;

    public CountriesUnitOfWork(IGenericRepository<Country> repository, ICountriesRepository countriesRepository) : base(repository)
    {
        _countriesRepository = countriesRepository;
    }

    public override async Task<ActionResponse<IEnumerable<Country>>> GetAsync() => await _countriesRepository.GetAsync();

    public override async Task<ActionResponse<Country>> GetAsync(int id) => await _countriesRepository.GetAsync(id);

    public async Task<IEnumerable<Country>> GetComboAsync() => await _countriesRepository.GetComboAsync();
}