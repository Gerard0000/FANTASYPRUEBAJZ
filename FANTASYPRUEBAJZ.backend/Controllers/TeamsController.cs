using FANTASYPRUEBAJZ.backend.UnitofWork.Interfaces;
using FANTASYPRUEBAJZ.shared.Entities;
using Microsoft.AspNetCore.Mvc;

namespace FANTASYPRUEBAJZ.backend.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TeamsController : GenericController<Team>
{
    public TeamsController(IGenericUnitOfWork<Team> unitOfWork) : base(unitOfWork)
    {
    }
}