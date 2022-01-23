using Microsoft.EntityFrameworkCore;
using RentRoom.Models;

namespace RentRoom.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}
