using FANTASYPRUEBAJZ.shared.Entities;
using Microsoft.EntityFrameworkCore;

namespace FANTASYPRUEBAJZ.backend.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }

    public DbSet<Country> Countries { get; set; }
    public DbSet<Team> Teams { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Country>().HasIndex(x => x.Name).IsUnique();
        //PARA QUE HAGA UNA VALIDACIÓNM UNICA INTERNA, EJEMPLO: PAÍS HONDURAS NO PUEDE TENER DOS EQUIPOS LLAMADOS MOTAGUA
        modelBuilder.Entity<Team>().HasIndex(x => new { x.CountryId, x.Name }).IsUnique();
        DisableCascadingDelete(modelBuilder);
    }

    //PARA EVITAR EL BORRADO EN CASCADA
    private void DisableCascadingDelete(ModelBuilder modelBuilder)
    {
        var relationships = modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys());
        foreach (var relationship in relationships)
        {
            relationship.DeleteBehavior = DeleteBehavior.Restrict;
        }
    }
}