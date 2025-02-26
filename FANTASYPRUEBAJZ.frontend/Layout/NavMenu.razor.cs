using FANTASYPRUEBAJZ.shared.Resources;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;

namespace FANTASYPRUEBAJZ.frontend.Layout;

public partial class NavMenu
{
    [Inject] private IStringLocalizer<Literals> Localizer { get; set; } = null!;
    private bool collapseNavMenu = true;

    private string? NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }
}