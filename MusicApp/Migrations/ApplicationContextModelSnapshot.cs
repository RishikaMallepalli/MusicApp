// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MusicApp.Models;

namespace MusicApp.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MusicApp.Models.Album", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MusicianId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("ReleaseYear")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MusicianId");

                    b.ToTable("Albums");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            MusicianId = 1,
                            Name = "Plus",
                            ReleaseYear = 2011
                        },
                        new
                        {
                            Id = 2,
                            MusicianId = 1,
                            Name = "Multiply",
                            ReleaseYear = 2014
                        },
                        new
                        {
                            Id = 3,
                            MusicianId = 1,
                            Name = "Divide",
                            ReleaseYear = 2017
                        });
                });

            modelBuilder.Entity("MusicApp.Models.Musician", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int>("CareerStartYear")
                        .HasColumnType("int");

                    b.Property<string>("Genre")
                        .HasColumnType("nvarchar(15)")
                        .HasMaxLength(15);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.HasKey("Id");

                    b.ToTable("Musicians");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 27,
                            CareerStartYear = 2006,
                            Genre = "pop",
                            Name = "Edward Sheeran"
                        });
                });

            modelBuilder.Entity("MusicApp.Models.Track", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AlbumId")
                        .HasColumnType("int");

                    b.Property<string>("Duration")
                        .IsRequired()
                        .HasColumnType("nvarchar(5)")
                        .HasMaxLength(5);

                    b.Property<bool>("IsFavorite")
                        .HasColumnType("bit");

                    b.Property<bool>("IsListened")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AlbumId");

                    b.ToTable("Tracks");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AlbumId = 1,
                            Duration = "04:18",
                            IsFavorite = false,
                            IsListened = false,
                            Name = "The A Team",
                            Rating = 0
                        },
                        new
                        {
                            Id = 2,
                            AlbumId = 1,
                            Duration = "03:20",
                            IsFavorite = false,
                            IsListened = false,
                            Name = "Drunk",
                            Rating = 0
                        },
                        new
                        {
                            Id = 3,
                            AlbumId = 1,
                            Duration = "03:48",
                            IsFavorite = false,
                            IsListened = false,
                            Name = "U.N.I.",
                            Rating = 0
                        },
                        new
                        {
                            Id = 4,
                            AlbumId = 1,
                            Duration = "02:59",
                            IsFavorite = false,
                            IsListened = false,
                            Name = "Grade 8",
                            Rating = 0
                        },
                        new
                        {
                            Id = 5,
                            AlbumId = 2,
                            Duration = "04:13",
                            IsFavorite = false,
                            IsListened = false,
                            Name = "One",
                            Rating = 0
                        },
                        new
                        {
                            Id = 6,
                            AlbumId = 2,
                            Duration = "04:06",
                            IsFavorite = false,
                            IsListened = false,
                            Name = "I'm a Mess",
                            Rating = 0
                        },
                        new
                        {
                            Id = 7,
                            AlbumId = 2,
                            Duration = "03:43",
                            IsFavorite = false,
                            IsListened = false,
                            Name = "Nina",
                            Rating = 0
                        },
                        new
                        {
                            Id = 8,
                            AlbumId = 2,
                            Duration = "04:17",
                            IsFavorite = false,
                            IsListened = false,
                            Name = "Photograph",
                            Rating = 0
                        },
                        new
                        {
                            Id = 9,
                            AlbumId = 3,
                            Duration = "03:47",
                            IsFavorite = false,
                            IsListened = false,
                            Name = "Erazer",
                            Rating = 0
                        },
                        new
                        {
                            Id = 10,
                            AlbumId = 3,
                            Duration = "04:21",
                            IsFavorite = false,
                            IsListened = false,
                            Name = "Castle on the Hill",
                            Rating = 0
                        },
                        new
                        {
                            Id = 11,
                            AlbumId = 3,
                            Duration = "03:58",
                            IsFavorite = false,
                            IsListened = false,
                            Name = "Dive",
                            Rating = 0
                        },
                        new
                        {
                            Id = 12,
                            AlbumId = 3,
                            Duration = "03:53",
                            IsFavorite = false,
                            IsListened = false,
                            Name = "Shape of You",
                            Rating = 0
                        });
                });

            modelBuilder.Entity("MusicApp.Models.Album", b =>
                {
                    b.HasOne("MusicApp.Models.Musician", "Musician")
                        .WithMany("Albums")
                        .HasForeignKey("MusicianId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MusicApp.Models.Track", b =>
                {
                    b.HasOne("MusicApp.Models.Album", "Album")
                        .WithMany("Tracks")
                        .HasForeignKey("AlbumId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
