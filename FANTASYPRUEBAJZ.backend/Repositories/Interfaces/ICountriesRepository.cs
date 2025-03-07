using FANTASYPRUEBAJZ.shared.Entities;
using FANTASYPRUEBAJZ.shared.Responses;

namespace FANTASYPRUEBAJZ.backend.Repositories.Interfaces;

public interface ICountriesRepository
{
    Task<ActionResponse<Country>> GetAsync(int id);

    Task<ActionResponse<IEnumerable<Country>>> GetAsync();

    Task<IEnumerable<Country>> GetComboAsync();
}