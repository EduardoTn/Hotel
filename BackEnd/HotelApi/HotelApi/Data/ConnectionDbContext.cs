using HotelApi.Model;
using Microsoft.EntityFrameworkCore;

namespace HotelApi.Data
{
    public class ConnectionDbContext : DbContext
    {
        public ConnectionDbContext(DbContextOptions<ConnectionDbContext> opt) : base(opt)
        {

        }

        public DbSet<HotelPessoaJuridica> HotelPessoaJuridica { get; set; }
        public DbSet<Quarto> Quarto { get; set; }
    }
}
