﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MigrationManyToMany.Data;

#nullable disable

namespace MigrationManyToMany.Migrations
{
    [DbContext(typeof(MyDbContext))]
    partial class MyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MigrationManyToMany.Models.Child", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Children");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Child 1"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Child 2"
                        });
                });

            modelBuilder.Entity("MigrationManyToMany.Models.Parent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Parents");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Parent 1"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Parent 2"
                        });
                });

            modelBuilder.Entity("MigrationManyToMany.Models.ParentChild", b =>
                {
                    b.Property<int>("ParentId")
                        .HasColumnType("int");

                    b.Property<int>("ChildId")
                        .HasColumnType("int");

                    b.HasKey("ParentId", "ChildId");

                    b.HasIndex("ChildId");

                    b.ToTable("ParentsChildren");

                    b.HasData(
                        new
                        {
                            ParentId = 1,
                            ChildId = 1
                        },
                        new
                        {
                            ParentId = 1,
                            ChildId = 2
                        },
                        new
                        {
                            ParentId = 2,
                            ChildId = 1
                        });
                });

            modelBuilder.Entity("MigrationManyToMany.Models.ParentChild", b =>
                {
                    b.HasOne("MigrationManyToMany.Models.Child", "Child")
                        .WithMany("ParentsChildren")
                        .HasForeignKey("ChildId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MigrationManyToMany.Models.Parent", "Parent")
                        .WithMany("ParentsChildren")
                        .HasForeignKey("ParentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Child");

                    b.Navigation("Parent");
                });

            modelBuilder.Entity("MigrationManyToMany.Models.Child", b =>
                {
                    b.Navigation("ParentsChildren");
                });

            modelBuilder.Entity("MigrationManyToMany.Models.Parent", b =>
                {
                    b.Navigation("ParentsChildren");
                });
#pragma warning restore 612, 618
        }
    }
}