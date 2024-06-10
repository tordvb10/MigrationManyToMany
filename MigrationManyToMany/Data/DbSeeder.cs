using Microsoft.EntityFrameworkCore;
using MigrationManyToMany.Models;

namespace MigrationManyToMany.Data
{
    public static class DbSeeder
    {
        public static void SeedData(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Parent>().HasData(
                new Parent { Id = 1, Name = "Parent 1" },
                new Parent { Id = 2, Name = "Parent 2" }
            );
            modelBuilder.Entity<Child>().HasData(
                new Child { Id = 1, Name = "Child 1" },
                new Child { Id = 2, Name = "Child 2" }
            );


            modelBuilder.Entity<ParentChild>().HasData(
                new ParentChild { ParentId = 1, ChildId = 1 },
                new ParentChild { ParentId = 1, ChildId = 2 },
                new ParentChild { ParentId = 2, ChildId = 1}
            );

        }
    }
}
