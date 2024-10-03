using FANTASYPRUEBAJZ.frontend.Repositories;
using FANTASYPRUEBAJZ.shared.Entities;
using Microsoft.AspNetCore.Components;

namespace FANTASYPRUEBAJZ.frontend.Pages.Countries
{
    public partial class CountriesIndex
    {
        [Inject] private IRepository Repository { get; set; } = null!;
        private List<Country>? Countries { get; set; }

        protected override async Task OnInitializedAsync()
        {
            var responseHttp = await Repository.GetAsync<List<Country>>("api/Countries");
            Countries = responseHttp.Response;
        }
    }
}