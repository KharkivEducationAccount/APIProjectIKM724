using Microsoft.EntityFrameworkCore;
using MyProject.Domain;

namespace MyProject.Infrastructure.Data;

public class AppDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }
}
