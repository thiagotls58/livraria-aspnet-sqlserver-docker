using livraria.Models;
using Microsoft.EntityFrameworkCore;

namespace livraria.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Livro>? Livros { get; set; }
}