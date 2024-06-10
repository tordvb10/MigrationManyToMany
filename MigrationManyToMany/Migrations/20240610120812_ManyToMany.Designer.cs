﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MigrationManyToMany.Data;

#nullable disable

namespace MigrationManyToMany.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20240610120812_ManyToMany")]
    partial class ManyToMany
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
