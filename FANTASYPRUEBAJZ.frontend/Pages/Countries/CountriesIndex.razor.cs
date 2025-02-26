using FANTASYPRUEBAJZ.frontend.Repositories;
using FANTASYPRUEBAJZ.shared.Entities;
using FANTASYPRUEBAJZ.shared.Resources;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;

namespace FANTASYPRUEBAJZ.frontend.Pages.Countries;

public partial class CountriesIndex
{
    [Inject] private IRepository Repository { get; set; } = null!;
    [Inject] private IStringLocalizer<Literals> Localizer { get; set; } = null!;
    private List<Country>? Countries { get; set; }

    protected override async Task OnInitializedAsync()
    {
        var responseHttp = await Repository.GetAsync<List<Country>>("api/Countries");
        Countries = responseHttp.Response;
    }
}