using Microsoft.EntityFrameworkCore;

namespace CurrencyExchangeCalculator.Data;

public class ApplicationDbContext : DbContext 
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
    public DbSet<CurrencyExchangeRate> Currencies { get; set; }
}
