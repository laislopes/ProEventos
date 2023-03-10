using Microsoft.EntityFrameworkCore;

namespace ProEventos.API.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Models.Evento> Eventos { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options){}
    }
}