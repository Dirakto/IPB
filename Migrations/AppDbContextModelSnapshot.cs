﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ipb.Models;

namespace ipb.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024");

            modelBuilder.Entity("ipb.Models.List", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CzyPowazny");

                    b.Property<string>("GraczName");

                    b.Property<int>("Kategoria");

                    b.Property<string>("Opis");

                    b.Property<int>("Stan");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("Listy");
                });
#pragma warning restore 612, 618
        }
    }
}
