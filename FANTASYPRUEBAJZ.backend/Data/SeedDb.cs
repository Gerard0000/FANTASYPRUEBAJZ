using FANTASYPRUEBAJZ.shared.Entities;
using Microsoft.EntityFrameworkCore;

namespace FANTASYPRUEBAJZ.backend.Data;

public class SeedDb
{
    private readonly DataContext _context;

    public SeedDb(DataContext context)
    {
        _context = context;
    }

    public async Task SeedAsync()
    {
        await _context.Database.EnsureCreatedAsync();
        await CheckCountriesAsync();
        await CheckTeamsAsync();
    }

    private async Task CheckCountriesAsync()
    {
        if (!_context.Countries.Any())
        {
            //PARA LEER EL ARCHIVO SQL
            var countriesSQLScript = File.ReadAllText("Data\\Countries.sql");
            await _context.Database.ExecuteSqlRawAsync(countriesSQLScript);
        }
    }

    private async Task CheckTeamsAsync()
    {
        if (!_context.Teams.Any())
        {
            foreach (var country in _context.Countries)
            {
                _context.Teams.Add(new Team { Name = country.Name, Country = country! });
                if (country.Name == "Honduras")
                {
                    _context.Teams.Add(new Team { Name = "Genesis", Country = country! });
                    _context.Teams.Add(new Team { Name = "Jutigalpa", Country = country! });
                    _context.Teams.Add(new Team { Name = "Lobos UPNFM", Country = country! });
                    _context.Teams.Add(new Team { Name = "Marathon", Country = country! });
                    _context.Teams.Add(new Team { Name = "Motagua", Country = country! });
                    _context.Teams.Add(new Team { Name = "Olancho", Country = country! });
                    _context.Teams.Add(new Team { Name = "Olimpia", Country = country! });
                    _context.Teams.Add(new Team { Name = "Real España", Country = country! });
                    _context.Teams.Add(new Team { Name = "Real Sociedad", Country = country! });
                    _context.Teams.Add(new Team { Name = "Victoria", Country = country! });
                }
            }

            await _context.SaveChangesAsync();
        }
    }
}