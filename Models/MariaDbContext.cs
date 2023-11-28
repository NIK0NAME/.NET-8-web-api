namespace WebApi.Models;

using Microsoft.EntityFrameworkCore;

public partial class MariaDbContext : DbContext
{
    public MariaDbContext(DbContextOptions<MariaDbContext> options): base(options)
    {
    }

    public virtual DbSet<UserModel> Users { get; set; }
}