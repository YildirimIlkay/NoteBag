// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NoteBag.Data;

#nullable disable

namespace NoteBag.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220908075757_First")]
    partial class First
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("NoteBag.Data.Note", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Notes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Content = "Lorem Lorem Lorem Lorem Lorem",
                            Title = "Lorem Ipsum"
                        },
                        new
                        {
                            Id = 2,
                            Content = "Lorem Lorem Lorem Lorem Lorem",
                            Title = "Dolor Sit"
                        },
                        new
                        {
                            Id = 3,
                            Content = "Lorem Lorem Lorem Lorem Lorem",
                            Title = "Amet "
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
