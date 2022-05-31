using Microsoft.EntityFrameworkCore;

namespace GroceryBackend {
    public class GroceryContext : DbContext{
        public GroceryContext(DbContextOptions<GroceryContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
        }

        public DbSet<GroceryItem> GroceryItems { get; set; } = null!;
    }
}
