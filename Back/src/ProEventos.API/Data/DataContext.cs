using Microsoft.EntityFrameworkCore;
using ProEventos.API.Models;

namespace ProEventos.API.Data
{
    public class DataContext : DbContext
    {
        
        public DataContext(DbContextOptions<DataContext>Opition) : base(Opition) {}
        public DbSet<Evento> Eventos { get; set; }
    }
}