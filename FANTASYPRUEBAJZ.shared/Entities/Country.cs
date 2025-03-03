using FANTASYPRUEBAJZ.shared.Resources;
using System.ComponentModel.DataAnnotations;

namespace FANTASYPRUEBAJZ.shared.Entities;

public class Country
{
    public int Id { get; set; }

    [Display(Name = "Country", ResourceType = typeof(Literals))]
    [MaxLength(100, ErrorMessageResourceName = "MaxLength", ErrorMessageResourceType = typeof(Literals))]
    [Required(ErrorMessageResourceName = "RequiredField", ErrorMessageResourceType = typeof(Literals))]
    public string Name { get; set; } = null!;

    public ICollection<Team>? Teams { get; set; }

    //EN VEZ DE QUE LA BASE DE DATOS ME DEVUELVA NULL ME TIENE QUE DEVOLVER 0
    public int TeamsCount => Teams == null ? 0 : Teams.Count;
}