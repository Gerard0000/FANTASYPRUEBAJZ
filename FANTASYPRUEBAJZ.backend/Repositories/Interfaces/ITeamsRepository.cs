using FANTASYPRUEBAJZ.shared.DTOs;
using FANTASYPRUEBAJZ.shared.Entities;
using FANTASYPRUEBAJZ.shared.Responses;

namespace FANTASYPRUEBAJZ.backend.Repositories.Interfaces
{
    public interface ITeamsRepository
    {
        Task<IEnumerable<Team>> GetComboAsync(int countryId);

        Task<ActionResponse<Team>> AddAsync(TeamDTO teamDTO);

        Task<ActionResponse<Team>> UpdateAsync(TeamDTO teamDTO);

        Task<ActionResponse<Team>> GetAsync(int id);

        Task<ActionResponse<IEnumerable<Team>>> GetAsync();
    }
}