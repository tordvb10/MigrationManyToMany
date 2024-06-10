using Microsoft.EntityFrameworkCore;
using MigrationManyToMany.Models;

namespace MigrationManyToMany.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }
        public DbSet<Child> Children { get; set; }
        public DbSet<Parent> Parents { get; set; }
        public DbSet<ParentChild> ParentsChildren { get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ParentChild>()
                .HasKey(pc => new { pc.ParentId, pc.ChildId });

            modelBuilder.Entity<ParentChild>()
                .HasOne(pc => pc.Parent)
                .WithMany(p => p.ParentsChildren)
                .HasForeignKey(pc => pc.ParentId);

            modelBuilder.Entity<ParentChild>()
                .HasOne(pc => pc.Child)
                .WithMany(c => c.ParentsChildren)
                .HasForeignKey(pc => pc.ChildId);

            modelBuilder.SeedData();

            base.OnModelCreating(modelBuilder);
        }
    }
}
