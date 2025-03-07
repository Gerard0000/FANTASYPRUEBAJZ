using FANTASYPRUEBAJZ.shared.Entities;
using FANTASYPRUEBAJZ.shared.Responses;

namespace FANTASYPRUEBAJZ.backend.UnitofWork.Interfaces;

public interface ICountriesUnitOfWork
{
    Task<ActionResponse<Country>> GetAsync(int id);

    Task<ActionResponse<IEnumerable<Country>>> GetAsync();

    Task<IEnumerable<Country>> GetComboAsync();
}