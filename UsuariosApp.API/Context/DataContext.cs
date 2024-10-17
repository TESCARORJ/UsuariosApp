using Microsoft.EntityFrameworkCore;
using UsuariosApp.API.Entities;

namespace UsuariosApp.API.Contexts
{
    public class DataContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("DBUsuarios");
        }
    }
}

