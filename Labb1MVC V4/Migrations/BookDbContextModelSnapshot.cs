﻿// <auto-generated />
using System;
using Labb1MVC_V4.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Labb1MVC_V4.Migrations
{
    [DbContext(typeof(BookDbContext))]
    partial class BookDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.28")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Labb1MVC_V4.Models.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BookAuthor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BookName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberOfBooksInStock")
                        .HasColumnType("int");

                    b.HasKey("BookId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            BookId = 1,
                            BookAuthor = "Jamir Ondricka",
                            BookName = "RAM reboot Refined Rubber Bacon",
                            Description = "Quasi ut in et. Amet sunt aut laborum dolorum eum eos. Sit minima ipsam rem perferendis vel veritatis. Sint est maxime sunt voluptas.",
                            NumberOfBooksInStock = 3
                        },
                        new
                        {
                            BookId = 2,
                            BookAuthor = "Jaiden Lebsack",
                            BookName = "Communications incubate homogeneous",
                            Description = "Consectetur repellendus voluptatem id. Corrupti a autem et quos. Corrupti asperiores et incidunt commodi. Voluptatem recusandae fugiat molestiae temporibus labore voluptatem velit magnam ab. Distinctio odit consequatur voluptatem assumenda ut qui.",
                            NumberOfBooksInStock = 3
                        },
                        new
                        {
                            BookId = 3,
                            BookAuthor = "Madilyn Cartwright",
                            BookName = "haptic",
                            Description = "Qui nam fugit commodi sint. Fugit sunt quis. Porro enim in. Aut voluptas aut odio qui dolores reprehenderit. Perferendis quisquam possimus eum velit error nisi dolores. Ipsa qui cupiditate repellendus atque exercitationem necessitatibus magni occaecati.",
                            NumberOfBooksInStock = 3
                        },
                        new
                        {
                            BookId = 4,
                            BookAuthor = "Tiffany Johnston",
                            BookName = "Jamaica green",
                            Description = "Facilis soluta reprehenderit est. Assumenda et qui id dicta quo omnis incidunt officiis. Tempore dolorem debitis possimus et. Quia nemo debitis. Eos dolore quo libero fugiat velit quo.",
                            NumberOfBooksInStock = 3
                        },
                        new
                        {
                            BookId = 5,
                            BookAuthor = "Aiden Sipes",
                            BookName = "Fresh Metal Borders",
                            Description = "Soluta doloribus ullam. Et vel omnis ut qui inventore amet. Autem sint inventore perferendis occaecati illum est. Cum consequuntur cum odit voluptatem qui voluptatem tempore tempora.",
                            NumberOfBooksInStock = 3
                        },
                        new
                        {
                            BookId = 6,
                            BookAuthor = "Keenan Parker",
                            BookName = "back-end compressing plum",
                            Description = "Accusamus voluptatibus illum. Voluptas possimus dolores iusto quidem dolores perferendis quia excepturi consequatur. Ipsam adipisci ut omnis ea dicta ipsam. Voluptatem illo nobis aut voluptatem blanditiis qui voluptas rerum iusto.",
                            NumberOfBooksInStock = 3
                        },
                        new
                        {
                            BookId = 7,
                            BookAuthor = "Shayne Feil",
                            BookName = "back-end GB Iceland Krona",
                            Description = "Tenetur quia saepe rerum quis commodi qui dolorem non. Iste doloribus omnis rerum rerum facilis vel reiciendis amet expedita. Id vel error velit.",
                            NumberOfBooksInStock = 3
                        },
                        new
                        {
                            BookId = 8,
                            BookAuthor = "Jazlyn Boyle",
                            BookName = "Tools, Health & Sports application",
                            Description = "Ipsum dicta cumque porro molestias porro magnam sequi. Veniam illo quod quasi aliquam. Qui est eius excepturi sit tempora.",
                            NumberOfBooksInStock = 3
                        },
                        new
                        {
                            BookId = 9,
                            BookAuthor = "David Bergstrom",
                            BookName = "B2C online Fresh",
                            Description = "Dolores consequatur aspernatur a velit incidunt. Ipsam aliquam ratione. Autem harum ea mollitia quia dolorem fugiat aut. Rerum qui laboriosam placeat ea molestiae ab qui quam.",
                            NumberOfBooksInStock = 3
                        },
                        new
                        {
                            BookId = 10,
                            BookAuthor = "Elmer Muller",
                            BookName = "Networked copy Division",
                            Description = "Sit aut est deserunt et neque. Sed molestias quasi. Et et perspiciatis soluta. Ut omnis corrupti dolor excepturi saepe. Et magnam voluptatem voluptatem laudantium. Sit perspiciatis mollitia saepe.",
                            NumberOfBooksInStock = 3
                        });
                });

            modelBuilder.Entity("Labb1MVC_V4.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CustomerEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerFName")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)")
                        .HasMaxLength(25);

                    b.Property<string>("CustomerLName")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)")
                        .HasMaxLength(25);

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            CustomerId = 1,
                            CustomerEmail = "Carmel_Turner4@yahoo.com",
                            CustomerFName = "Sandrine",
                            CustomerLName = "Kshlerin"
                        },
                        new
                        {
                            CustomerId = 2,
                            CustomerEmail = "Ladarius.Hayes97@gmail.com",
                            CustomerFName = "Tamia",
                            CustomerLName = "Stanton"
                        },
                        new
                        {
                            CustomerId = 3,
                            CustomerEmail = "Rafaela63@hotmail.com",
                            CustomerFName = "Vern",
                            CustomerLName = "Bernier"
                        },
                        new
                        {
                            CustomerId = 4,
                            CustomerEmail = "Ronny.McKenzie@yahoo.com",
                            CustomerFName = "Ottis",
                            CustomerLName = "Heaney"
                        },
                        new
                        {
                            CustomerId = 5,
                            CustomerEmail = "Zoey82@gmail.com",
                            CustomerFName = "Julien",
                            CustomerLName = "Nienow"
                        },
                        new
                        {
                            CustomerId = 6,
                            CustomerEmail = "Christop.Koepp89@hotmail.com",
                            CustomerFName = "Clark",
                            CustomerLName = "O'Connell"
                        },
                        new
                        {
                            CustomerId = 7,
                            CustomerEmail = "Cordia47@yahoo.com",
                            CustomerFName = "Major",
                            CustomerLName = "Paucek"
                        },
                        new
                        {
                            CustomerId = 8,
                            CustomerEmail = "Nathanial_Sporer42@yahoo.com",
                            CustomerFName = "Rosalee",
                            CustomerLName = "Boehm"
                        },
                        new
                        {
                            CustomerId = 9,
                            CustomerEmail = "Helene_Hammes@yahoo.com",
                            CustomerFName = "Thelma",
                            CustomerLName = "Jaskolski"
                        },
                        new
                        {
                            CustomerId = 10,
                            CustomerEmail = "Carmel.Runolfsson@gmail.com",
                            CustomerFName = "Evan",
                            CustomerLName = "Botsford"
                        });
                });

            modelBuilder.Entity("Labb1MVC_V4.Models.LoanedBook", b =>
                {
                    b.Property<int>("LoanedBookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("LoanDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ReturnDate")
                        .HasColumnType("datetime2");

                    b.HasKey("LoanedBookId");

                    b.HasIndex("BookId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Loan");

                    b.HasData(
                        new
                        {
                            LoanedBookId = 1,
                            BookId = 4,
                            CustomerId = 2,
                            LoanDate = new DateTime(2022, 9, 21, 15, 58, 35, 678, DateTimeKind.Local).AddTicks(3998),
                            ReturnDate = new DateTime(2022, 10, 21, 15, 58, 35, 680, DateTimeKind.Local).AddTicks(2259)
                        },
                        new
                        {
                            LoanedBookId = 2,
                            BookId = 2,
                            CustomerId = 8,
                            LoanDate = new DateTime(2022, 9, 21, 15, 58, 35, 680, DateTimeKind.Local).AddTicks(5758),
                            ReturnDate = new DateTime(2022, 10, 21, 15, 58, 35, 680, DateTimeKind.Local).AddTicks(5779)
                        },
                        new
                        {
                            LoanedBookId = 3,
                            BookId = 7,
                            CustomerId = 8,
                            LoanDate = new DateTime(2022, 9, 21, 15, 58, 35, 680, DateTimeKind.Local).AddTicks(5914),
                            ReturnDate = new DateTime(2022, 10, 21, 15, 58, 35, 680, DateTimeKind.Local).AddTicks(5918)
                        },
                        new
                        {
                            LoanedBookId = 4,
                            BookId = 3,
                            CustomerId = 4,
                            LoanDate = new DateTime(2022, 9, 21, 15, 58, 35, 680, DateTimeKind.Local).AddTicks(5928),
                            ReturnDate = new DateTime(2022, 10, 21, 15, 58, 35, 680, DateTimeKind.Local).AddTicks(5930)
                        },
                        new
                        {
                            LoanedBookId = 5,
                            BookId = 2,
                            CustomerId = 4,
                            LoanDate = new DateTime(2022, 9, 21, 15, 58, 35, 680, DateTimeKind.Local).AddTicks(5938),
                            ReturnDate = new DateTime(2022, 10, 21, 15, 58, 35, 680, DateTimeKind.Local).AddTicks(5940)
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

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
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Labb1MVC_V4.Models.LoanedBook", b =>
                {
                    b.HasOne("Labb1MVC_V4.Models.Book", "Book")
                        .WithMany("LoanedBook")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Labb1MVC_V4.Models.Customer", "Customer")
                        .WithMany("LoanedBook")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
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
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
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

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
