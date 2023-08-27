using Microsoft.EntityFrameworkCore;
using UchKardesh.Domain.Entities;

namespace UchKardesh.DAL.Constexts;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    { }

    DbSet<User> Users { get; set; }
    DbSet<Product> Products { get; set; }
    DbSet<Category> Categories { get; set; }
    DbSet<Attachment> Attachments { get; set; }
    DbSet<Session> Sessions { get; set; }
}