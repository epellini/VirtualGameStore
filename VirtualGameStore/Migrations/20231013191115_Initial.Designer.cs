﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VirtualGameStore.DataAccess;

#nullable disable

namespace VirtualGameStore.Migrations
{
    [DbContext(typeof(GameStoreDbContext))]
    [Migration("20231013191115_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.22")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("VirtualGameStore.Entities.FavouriteGenre", b =>
                {
                    b.Property<int>("FavouriteGenreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FavouriteGenreId"), 1L, 1);

                    b.Property<int?>("GenreId")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("FavouriteGenreId");

                    b.HasIndex("GenreId");

                    b.HasIndex("UserId");

                    b.ToTable("FavouriteGenres");
                });

            modelBuilder.Entity("VirtualGameStore.Entities.FavouritePlatform", b =>
                {
                    b.Property<int>("FavouritePlatformId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FavouritePlatformId"), 1L, 1);

                    b.Property<int?>("PlatformId")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("FavouritePlatformId");

                    b.HasIndex("PlatformId");

                    b.HasIndex("UserId");

                    b.ToTable("FavouritePlatforms");
                });

            modelBuilder.Entity("VirtualGameStore.Entities.Game", b =>
                {
                    b.Property<int>("GameId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GameId"), 1L, 1);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Developer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.Property<double?>("RetailPrice")
                        .HasColumnType("float");

                    b.HasKey("GameId");

                    b.ToTable("Games");

                    b.HasData(
                        new
                        {
                            GameId = 1,
                            Description = "You’re a marine—one of Earth’s best—recently assigned to the Union Aerospace Corporation (UAC) research facility on Mars. When an experiment malfunctions and creates a portal to Hell, the base is overrun by blood-thirsty demons. You must shoot your way out to survive.",
                            Developer = "id Software",
                            Name = "Doom",
                            ReleaseDate = new DateTime(1993, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RetailPrice = 4.9900000000000002
                        },
                        new
                        {
                            GameId = 2,
                            Description = "Explore an ever changing and evolving living world where new challenges, skills, and quests await. Featuring unprecedented player freedom, you choose how to play, adventure, and grow.",
                            Developer = "Jagex",
                            Name = "RuneScape",
                            ReleaseDate = new DateTime(2001, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RetailPrice = 0.0
                        },
                        new
                        {
                            GameId = 3,
                            Description = "Explore randomly generated worlds and build amazing things from the simplest of homes to the grandest of castles. Play in creative mode with unlimited resources or mine deep into the world in survival mode, crafting weapons and armor to fend off the dangerous mobs.",
                            Developer = "Mojang Studios",
                            Name = "Minecraft",
                            ReleaseDate = new DateTime(2011, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RetailPrice = 29.989999999999998
                        },
                        new
                        {
                            GameId = 4,
                            Description = "Create the ultimate theme park using a variety of coaster types with giant loops and barrel rolls and in-park attractions like suspended monorails and water-soaked plume rides.",
                            Developer = "Chris Sawyer",
                            Name = "RollerCoaster Tycoon",
                            ReleaseDate = new DateTime(1999, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RetailPrice = 5.9900000000000002
                        });
                });

            modelBuilder.Entity("VirtualGameStore.Entities.GameGenre", b =>
                {
                    b.Property<int>("GameGenreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GameGenreId"), 1L, 1);

                    b.Property<int?>("GameId")
                        .HasColumnType("int");

                    b.Property<int?>("GenreId")
                        .HasColumnType("int");

                    b.HasKey("GameGenreId");

                    b.HasIndex("GameId");

                    b.HasIndex("GenreId");

                    b.ToTable("GameGenres");

                    b.HasData(
                        new
                        {
                            GameGenreId = 1,
                            GameId = 1,
                            GenreId = 1
                        },
                        new
                        {
                            GameGenreId = 2,
                            GameId = 1,
                            GenreId = 5
                        },
                        new
                        {
                            GameGenreId = 3,
                            GameId = 2,
                            GenreId = 7
                        },
                        new
                        {
                            GameGenreId = 4,
                            GameId = 2,
                            GenreId = 10
                        },
                        new
                        {
                            GameGenreId = 5,
                            GameId = 3,
                            GenreId = 2
                        },
                        new
                        {
                            GameGenreId = 6,
                            GameId = 4,
                            GenreId = 11
                        });
                });

            modelBuilder.Entity("VirtualGameStore.Entities.GameLanguage", b =>
                {
                    b.Property<int>("GameLanguageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GameLanguageId"), 1L, 1);

                    b.Property<int?>("GameId")
                        .HasColumnType("int");

                    b.Property<string>("LanguageId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("GameLanguageId");

                    b.HasIndex("GameId");

                    b.HasIndex("LanguageId");

                    b.ToTable("GameLanguages");

                    b.HasData(
                        new
                        {
                            GameLanguageId = 1,
                            GameId = 1,
                            LanguageId = "en"
                        },
                        new
                        {
                            GameLanguageId = 2,
                            GameId = 1,
                            LanguageId = "es"
                        },
                        new
                        {
                            GameLanguageId = 3,
                            GameId = 2,
                            LanguageId = "en"
                        },
                        new
                        {
                            GameLanguageId = 4,
                            GameId = 2,
                            LanguageId = "fr"
                        },
                        new
                        {
                            GameLanguageId = 5,
                            GameId = 3,
                            LanguageId = "en"
                        },
                        new
                        {
                            GameLanguageId = 6,
                            GameId = 3,
                            LanguageId = "es"
                        },
                        new
                        {
                            GameLanguageId = 7,
                            GameId = 3,
                            LanguageId = "fr"
                        },
                        new
                        {
                            GameLanguageId = 8,
                            GameId = 4,
                            LanguageId = "en"
                        });
                });

            modelBuilder.Entity("VirtualGameStore.Entities.GamePlatform", b =>
                {
                    b.Property<int?>("GameId")
                        .HasColumnType("int");

                    b.Property<int?>("PlatformId")
                        .HasColumnType("int");

                    b.HasKey("GameId", "PlatformId");

                    b.HasIndex("PlatformId");

                    b.ToTable("GamePlatform");

                    b.HasData(
                        new
                        {
                            GameId = 1,
                            PlatformId = 4
                        },
                        new
                        {
                            GameId = 2,
                            PlatformId = 1
                        },
                        new
                        {
                            GameId = 3,
                            PlatformId = 1
                        },
                        new
                        {
                            GameId = 3,
                            PlatformId = 2
                        },
                        new
                        {
                            GameId = 3,
                            PlatformId = 3
                        },
                        new
                        {
                            GameId = 4,
                            PlatformId = 1
                        });
                });

            modelBuilder.Entity("VirtualGameStore.Entities.Genre", b =>
                {
                    b.Property<int>("GenreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GenreId"), 1L, 1);

                    b.Property<string>("GenreName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GenreId");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            GenreId = 1,
                            GenreName = "Action"
                        },
                        new
                        {
                            GenreId = 2,
                            GenreName = "Adventure"
                        },
                        new
                        {
                            GenreId = 3,
                            GenreName = "Arcade"
                        },
                        new
                        {
                            GenreId = 4,
                            GenreName = "Co-op"
                        },
                        new
                        {
                            GenreId = 5,
                            GenreName = "FPS"
                        },
                        new
                        {
                            GenreId = 6,
                            GenreName = "Horror"
                        },
                        new
                        {
                            GenreId = 7,
                            GenreName = "MMO"
                        },
                        new
                        {
                            GenreId = 8,
                            GenreName = "Puzzle"
                        },
                        new
                        {
                            GenreId = 9,
                            GenreName = "Racing"
                        },
                        new
                        {
                            GenreId = 10,
                            GenreName = "RPG"
                        },
                        new
                        {
                            GenreId = 11,
                            GenreName = "Simulation"
                        },
                        new
                        {
                            GenreId = 12,
                            GenreName = "Sports"
                        },
                        new
                        {
                            GenreId = 13,
                            GenreName = "Strategy"
                        },
                        new
                        {
                            GenreId = 14,
                            GenreName = "Survival"
                        },
                        new
                        {
                            GenreId = 15,
                            GenreName = "VR"
                        });
                });

            modelBuilder.Entity("VirtualGameStore.Entities.Language", b =>
                {
                    b.Property<string>("LanguageId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LanguageName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LanguageId");

                    b.ToTable("Languages");

                    b.HasData(
                        new
                        {
                            LanguageId = "en",
                            LanguageName = "English"
                        },
                        new
                        {
                            LanguageId = "fr",
                            LanguageName = "French"
                        },
                        new
                        {
                            LanguageId = "es",
                            LanguageName = "Spanish"
                        });
                });

            modelBuilder.Entity("VirtualGameStore.Entities.Picture", b =>
                {
                    b.Property<int>("PictureId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PictureId"), 1L, 1);

                    b.Property<string>("AltText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("GameId")
                        .HasColumnType("int");

                    b.Property<byte[]>("Image")
                        .HasColumnType("varbinary(max)");

                    b.Property<bool?>("IsCoverArt")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PictureId");

                    b.HasIndex("GameId");

                    b.ToTable("Pictures");
                });

            modelBuilder.Entity("VirtualGameStore.Entities.Platform", b =>
                {
                    b.Property<int>("PlatformId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PlatformId"), 1L, 1);

                    b.Property<string>("PlatformName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PlatformId");

                    b.ToTable("Platforms");

                    b.HasData(
                        new
                        {
                            PlatformId = 1,
                            PlatformName = "Windows"
                        },
                        new
                        {
                            PlatformId = 2,
                            PlatformName = "Mac"
                        },
                        new
                        {
                            PlatformId = 3,
                            PlatformName = "Linux"
                        },
                        new
                        {
                            PlatformId = 4,
                            PlatformName = "MS-DOS"
                        });
                });

            modelBuilder.Entity("VirtualGameStore.Entities.PreferredLanguage", b =>
                {
                    b.Property<int>("PreferredLanguageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PreferredLanguageId"), 1L, 1);

                    b.Property<string>("LanguageId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("PreferredLanguageId");

                    b.HasIndex("LanguageId");

                    b.HasIndex("UserId");

                    b.ToTable("PreferredLanguages");
                });

            modelBuilder.Entity("VirtualGameStore.Entities.Profile", b =>
                {
                    b.Property<int>("ProfileId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProfileId"), 1L, 1);

                    b.Property<DateTime?>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("PromoRegistered")
                        .HasColumnType("bit");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ProfileId");

                    b.HasIndex("UserId")
                        .IsUnique()
                        .HasFilter("[UserId] IS NOT NULL");

                    b.ToTable("Profiles");
                });

            modelBuilder.Entity("VirtualGameStore.Entities.ShippingAddress", b =>
                {
                    b.Property<int>("ShippingAddressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ShippingAddressId"), 1L, 1);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Address2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeliveryInstructions")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Province")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ShippingAddressId");

                    b.HasIndex("UserId");

                    b.ToTable("ShippingAddresses");
                });

            modelBuilder.Entity("VirtualGameStore.Entities.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("VirtualGameStore.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("VirtualGameStore.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VirtualGameStore.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("VirtualGameStore.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("VirtualGameStore.Entities.FavouriteGenre", b =>
                {
                    b.HasOne("VirtualGameStore.Entities.Genre", "Genre")
                        .WithMany("Users")
                        .HasForeignKey("GenreId");

                    b.HasOne("VirtualGameStore.Entities.User", "User")
                        .WithMany("Genres")
                        .HasForeignKey("UserId");

                    b.Navigation("Genre");

                    b.Navigation("User");
                });

            modelBuilder.Entity("VirtualGameStore.Entities.FavouritePlatform", b =>
                {
                    b.HasOne("VirtualGameStore.Entities.Platform", "Platform")
                        .WithMany("Users")
                        .HasForeignKey("PlatformId");

                    b.HasOne("VirtualGameStore.Entities.User", "User")
                        .WithMany("Platforms")
                        .HasForeignKey("UserId");

                    b.Navigation("Platform");

                    b.Navigation("User");
                });

            modelBuilder.Entity("VirtualGameStore.Entities.GameGenre", b =>
                {
                    b.HasOne("VirtualGameStore.Entities.Game", "Game")
                        .WithMany("Genres")
                        .HasForeignKey("GameId");

                    b.HasOne("VirtualGameStore.Entities.Genre", "Genre")
                        .WithMany("Games")
                        .HasForeignKey("GenreId");

                    b.Navigation("Game");

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("VirtualGameStore.Entities.GameLanguage", b =>
                {
                    b.HasOne("VirtualGameStore.Entities.Game", "Game")
                        .WithMany("Languages")
                        .HasForeignKey("GameId");

                    b.HasOne("VirtualGameStore.Entities.Language", "Language")
                        .WithMany("Games")
                        .HasForeignKey("LanguageId");

                    b.Navigation("Game");

                    b.Navigation("Language");
                });

            modelBuilder.Entity("VirtualGameStore.Entities.GamePlatform", b =>
                {
                    b.HasOne("VirtualGameStore.Entities.Game", "Game")
                        .WithMany("Platforms")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VirtualGameStore.Entities.Platform", "Platform")
                        .WithMany("Games")
                        .HasForeignKey("PlatformId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Game");

                    b.Navigation("Platform");
                });

            modelBuilder.Entity("VirtualGameStore.Entities.Picture", b =>
                {
                    b.HasOne("VirtualGameStore.Entities.Game", "Game")
                        .WithMany("Pictures")
                        .HasForeignKey("GameId");

                    b.Navigation("Game");
                });

            modelBuilder.Entity("VirtualGameStore.Entities.PreferredLanguage", b =>
                {
                    b.HasOne("VirtualGameStore.Entities.Language", "Language")
                        .WithMany("Users")
                        .HasForeignKey("LanguageId");

                    b.HasOne("VirtualGameStore.Entities.User", "User")
                        .WithMany("Languages")
                        .HasForeignKey("UserId");

                    b.Navigation("Language");

                    b.Navigation("User");
                });

            modelBuilder.Entity("VirtualGameStore.Entities.Profile", b =>
                {
                    b.HasOne("VirtualGameStore.Entities.User", "User")
                        .WithOne("Profile")
                        .HasForeignKey("VirtualGameStore.Entities.Profile", "UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("VirtualGameStore.Entities.ShippingAddress", b =>
                {
                    b.HasOne("VirtualGameStore.Entities.User", "User")
                        .WithMany("ShippingAddresses")
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("VirtualGameStore.Entities.Game", b =>
                {
                    b.Navigation("Genres");

                    b.Navigation("Languages");

                    b.Navigation("Pictures");

                    b.Navigation("Platforms");
                });

            modelBuilder.Entity("VirtualGameStore.Entities.Genre", b =>
                {
                    b.Navigation("Games");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("VirtualGameStore.Entities.Language", b =>
                {
                    b.Navigation("Games");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("VirtualGameStore.Entities.Platform", b =>
                {
                    b.Navigation("Games");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("VirtualGameStore.Entities.User", b =>
                {
                    b.Navigation("Genres");

                    b.Navigation("Languages");

                    b.Navigation("Platforms");

                    b.Navigation("Profile");

                    b.Navigation("ShippingAddresses");
                });
#pragma warning restore 612, 618
        }
    }
}
