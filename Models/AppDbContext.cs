using Microsoft.EntityFrameworkCore;

namespace mfdev_backend_2023.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}
        public DbSet<Veiculo> Veiculos { get; set; }
    }
}
