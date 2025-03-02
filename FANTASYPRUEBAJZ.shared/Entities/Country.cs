using System.ComponentModel.DataAnnotations;

namespace FANTASYPRUEBAJZ.shared.Entities;

public class Country
{
    public int Id { get; set; }

    [MaxLength(100)]
    [Required]
    public string Name { get; set; } = null!;

    public ICollection<Team>? Teams { get; set; }

    //EN VEZ DE QUE LA BASE DE DATOS ME DEVUELVA NULL ME TIENE QUE DEVOLVER 0
    public int TeamsCount => Teams == null ? 0 : Teams.Count;
}