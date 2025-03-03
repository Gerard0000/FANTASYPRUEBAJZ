using FANTASYPRUEBAJZ.backend.Data;
using FANTASYPRUEBAJZ.backend.UnitofWork.Interfaces;
using FANTASYPRUEBAJZ.shared.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FANTASYPRUEBAJZ.backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CountriesController : GenericController<Country>
    {
        public CountriesController(IGenericUnitOfWork<Country> unitOfWork) : base(unitOfWork)
        {
        }
    }
}