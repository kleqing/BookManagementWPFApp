﻿// <auto-generated />
using System;
using BookManagement.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BookManagement.DataAccess.Migrations
{
    [DbContext(typeof(BookManagementDbContext))]
    partial class BookManagementDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BookManagement.BusinessObjects.Author", b =>
                {
                    b.Property<int>("AuthorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AuthorID"));

                    b.Property<DateTime?>("AuthorDOB")
                        .HasColumnType("datetime2");

                    b.Property<string>("AuthorEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AuthorImageURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AuthorName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AuthorID");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            AuthorID = 1,
                            AuthorEmail = "landa@gmail.com",
                            AuthorImageURL = "https://i.pinimg.com/736x/99/63/4f/99634f142c41939386fbabd411459929.jpg",
                            AuthorName = "Landa"
                        },
                        new
                        {
                            AuthorID = 2,
                            AuthorEmail = "alex@gmail.com",
                            AuthorImageURL = "https://i.pinimg.com/736x/99/63/4f/99634f142c41939386fbabd411459929.jpg",
                            AuthorName = "Alexandra"
                        });
                });

            modelBuilder.Entity("BookManagement.BusinessObjects.Book", b =>
                {
                    b.Property<int>("BookID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookID"));

                    b.Property<int>("AuthorID")
                        .HasColumnType("int");

                    b.Property<string>("BookImages")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BookPDFLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryID")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DiscountID")
                        .HasColumnType("int");

                    b.Property<string>("Language")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Pages")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<DateTime>("PublishDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BookID");

                    b.HasIndex("AuthorID");

                    b.HasIndex("CategoryID");

                    b.HasIndex("DiscountID");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            BookID = 3,
                            AuthorID = 1,
                            BookImages = "https://i.pinimg.com/736x/99/63/4f/99634f142c41939386fbabd411459929.jpg",
                            CategoryID = 1,
                            Description = "Winner of the 2024 Hawthornden Prize\nShortlisted for the 2024 Orwell Prize for Political Fiction\nShortlisted for the 2024 Ursula K. Le Guin Prize for Fiction\n\nA singular new novel from Betty Trask Prize-winner Samantha Harvey, Orbital is an eloquent meditation on space and life on our planet through the eyes of six astronauts circling the earth in 24 hours\n\n\"Ravishingly beautiful.\" — Joshua Ferris, New York Times\n\nA slender novel of epic power and the winner of the Booker Prize 2024, Orbital deftly snapshots one day in the lives of six women and men traveling through space. Selected for one of the last space station missions of its kind before the program is dismantled, these astronauts and cosmonauts—from America, Russia, Italy, Britain, and Japan—have left their lives behind to travel at a speed of over seventeen thousand miles an hour as the earth reels below. We glimpse moments of their earthly lives through brief communications with family, their photos and talismans; we watch them whip up dehydrated meals, float in gravity-free sleep, and exercise in regimented routines to prevent atrophying muscles; we witness them form bonds that will stand between them and utter solitude. Most of all, we are with them as they behold and record their silent blue planet. Their experiences of sixteen sunrises and sunsets and the bright, blinking constellations of the galaxy are at once breathtakingly awesome and surprisingly intimate.\n\nProfound and contemplative, Orbital is a moving elegy to our environment and planet.",
                            Language = "English",
                            Pages = 123,
                            Price = 12.4,
                            PublishDate = new DateTime(2024, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Quantity = 0,
                            Title = "Doraemon"
                        },
                        new
                        {
                            BookID = 4,
                            AuthorID = 1,
                            BookImages = "https://i.pinimg.com/736x/99/63/4f/99634f142c41939386fbabd411459929.jpg",
                            CategoryID = 1,
                            Description = "Alone in space, years from rescue, everyone she knows has vanished.\nOn a colonial mission into uncharted space, Dr. Beth Adler awakens to find her ship ravaged and abandoned. The last thing she recalls is an alarm repeating the same horrifying message. “Quarantine breach.”",
                            Language = "English",
                            Pages = 123,
                            Price = 12.4,
                            PublishDate = new DateTime(2024, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Quantity = 0,
                            Title = "Pikachu"
                        },
                        new
                        {
                            BookID = 1,
                            AuthorID = 1,
                            BookImages = "https://i.pinimg.com/736x/99/63/4f/99634f142c41939386fbabd411459929.jpg",
                            CategoryID = 1,
                            Description = "Winner of the 2024 Hawthornden Prize\nShortlisted for the 2024 Orwell Prize for Political Fiction\nShortlisted for the 2024 Ursula K. Le Guin Prize for Fiction\n\nA singular new novel from Betty Trask Prize-winner Samantha Harvey, Orbital is an eloquent meditation on space and life on our planet through the eyes of six astronauts circling the earth in 24 hours\n\n\"Ravishingly beautiful.\" — Joshua Ferris, New York Times\n\nA slender novel of epic power and the winner of the Booker Prize 2024, Orbital deftly snapshots one day in the lives of six women and men traveling through space. Selected for one of the last space station missions of its kind before the program is dismantled, these astronauts and cosmonauts—from America, Russia, Italy, Britain, and Japan—have left their lives behind to travel at a speed of over seventeen thousand miles an hour as the earth reels below. We glimpse moments of their earthly lives through brief communications with family, their photos and talismans; we watch them whip up dehydrated meals, float in gravity-free sleep, and exercise in regimented routines to prevent atrophying muscles; we witness them form bonds that will stand between them and utter solitude. Most of all, we are with them as they behold and record their silent blue planet. Their experiences of sixteen sunrises and sunsets and the bright, blinking constellations of the galaxy are at once breathtakingly awesome and surprisingly intimate.\n\nProfound and contemplative, Orbital is a moving elegy to our environment and planet.",
                            Language = "English",
                            Pages = 123,
                            Price = 12.4,
                            PublishDate = new DateTime(2024, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Quantity = 0,
                            Title = "7 vien ngoc rong"
                        },
                        new
                        {
                            BookID = 2,
                            AuthorID = 1,
                            BookImages = "https://i.pinimg.com/736x/99/63/4f/99634f142c41939386fbabd411459929.jpg",
                            CategoryID = 1,
                            Description = "Alone in space, years from rescue, everyone she knows has vanished.\nOn a colonial mission into uncharted space, Dr. Beth Adler awakens to find her ship ravaged and abandoned. The last thing she recalls is an alarm repeating the same horrifying message. “Quarantine breach.”",
                            Language = "English",
                            Pages = 123,
                            Price = 12.4,
                            PublishDate = new DateTime(2024, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Quantity = 0,
                            Title = "Batman"
                        });
                });

            modelBuilder.Entity("BookManagement.BusinessObjects.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryID"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryID");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryID = 1,
                            CategoryName = "Chidren books"
                        },
                        new
                        {
                            CategoryID = 2,
                            CategoryName = "Philosophy"
                        });
                });

            modelBuilder.Entity("BookManagement.BusinessObjects.Discount", b =>
                {
                    b.Property<int>("DiscountID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DiscountID"));

                    b.Property<string>("discountName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("discountValue")
                        .HasColumnType("float");

                    b.HasKey("DiscountID");

                    b.ToTable("Discounts");
                });

            modelBuilder.Entity("BookManagement.BusinessObjects.Loan", b =>
                {
                    b.Property<int>("LoanID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LoanID"));

                    b.Property<int>("BookID")
                        .HasColumnType("int");

                    b.Property<int>("Bookmark")
                        .HasColumnType("int");

                    b.Property<DateTime>("BorrowDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DueDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("FineAmount")
                        .HasColumnType("float");

                    b.Property<DateTime?>("ReturnDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("LoanID");

                    b.HasIndex("BookID");

                    b.HasIndex("UserID");

                    b.ToTable("Loans");

                    b.HasData(
                        new
                        {
                            LoanID = 1,
                            BookID = 1,
                            Bookmark = 0,
                            BorrowDate = new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DueDate = new DateTime(2024, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FineAmount = 0.0,
                            ReturnDate = new DateTime(2024, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = "Borrowed",
                            UserID = 2
                        },
                        new
                        {
                            LoanID = 2,
                            BookID = 2,
                            Bookmark = 0,
                            BorrowDate = new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DueDate = new DateTime(2024, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FineAmount = 0.0,
                            ReturnDate = new DateTime(2024, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = "Borrowed",
                            UserID = 2
                        });
                });

            modelBuilder.Entity("BookManagement.BusinessObjects.LoanExtension", b =>
                {
                    b.Property<int>("LoanItemID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LoanItemID"));

                    b.Property<DateTime>("ExtendedDueDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ExtensionDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("LoanID")
                        .HasColumnType("int");

                    b.HasKey("LoanItemID");

                    b.HasIndex("LoanID");

                    b.ToTable("LoanExtensions");
                });

            modelBuilder.Entity("BookManagement.BusinessObjects.Order", b =>
                {
                    b.Property<int>("OrderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderID"));

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ShippingMethod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("TotalPrice")
                        .HasColumnType("float");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("OrderID");

                    b.HasIndex("UserID");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            OrderID = 1,
                            OrderDate = new DateTime(2024, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ShippingMethod = "Express",
                            Status = "Completed",
                            TotalPrice = 0.0,
                            UserID = 2
                        },
                        new
                        {
                            OrderID = 2,
                            OrderDate = new DateTime(2024, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ShippingMethod = "Express",
                            Status = "Completed",
                            TotalPrice = 0.0,
                            UserID = 2
                        },
                        new
                        {
                            OrderID = 3,
                            OrderDate = new DateTime(2024, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ShippingMethod = "Express",
                            Status = "Processing",
                            TotalPrice = 0.0,
                            UserID = 2
                        });
                });

            modelBuilder.Entity("BookManagement.BusinessObjects.OrderItem", b =>
                {
                    b.Property<int>("OrderID")
                        .HasColumnType("int");

                    b.Property<int>("BookID")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("OrderID", "BookID");

                    b.HasIndex("BookID");

                    b.ToTable("OrderItems");

                    b.HasData(
                        new
                        {
                            OrderID = 1,
                            BookID = 1,
                            Price = 12.4,
                            Quantity = 2
                        },
                        new
                        {
                            OrderID = 1,
                            BookID = 2,
                            Price = 28.399999999999999,
                            Quantity = 2
                        },
                        new
                        {
                            OrderID = 2,
                            BookID = 3,
                            Price = 7.4000000000000004,
                            Quantity = 1
                        },
                        new
                        {
                            OrderID = 2,
                            BookID = 4,
                            Price = 36.399999999999999,
                            Quantity = 3
                        },
                        new
                        {
                            OrderID = 3,
                            BookID = 3,
                            Price = 22.399999999999999,
                            Quantity = 2
                        });
                });

            modelBuilder.Entity("BookManagement.BusinessObjects.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserID"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateOnly?>("Dob")
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserID");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserID = 1,
                            Email = "admin@admin.com",
                            Password = "123",
                            Role = "Admin",
                            UserStatus = "Active",
                            Username = "admin"
                        },
                        new
                        {
                            UserID = 2,
                            Email = "alex@admin.com",
                            Password = "123",
                            Role = "User",
                            UserStatus = "Active",
                            Username = "alexandra"
                        });
                });

            modelBuilder.Entity("BookManagement.BusinessObjects.Book", b =>
                {
                    b.HasOne("BookManagement.BusinessObjects.Author", "Author")
                        .WithMany("Books")
                        .HasForeignKey("AuthorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookManagement.BusinessObjects.Category", "Category")
                        .WithMany("Books")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookManagement.BusinessObjects.Discount", "Discount")
                        .WithMany("Books")
                        .HasForeignKey("DiscountID");

                    b.Navigation("Author");

                    b.Navigation("Category");

                    b.Navigation("Discount");
                });

            modelBuilder.Entity("BookManagement.BusinessObjects.Loan", b =>
                {
                    b.HasOne("BookManagement.BusinessObjects.Book", "Book")
                        .WithMany("Loans")
                        .HasForeignKey("BookID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookManagement.BusinessObjects.User", "User")
                        .WithMany("Loans")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BookManagement.BusinessObjects.LoanExtension", b =>
                {
                    b.HasOne("BookManagement.BusinessObjects.Loan", "Loan")
                        .WithMany("LoanExtensions")
                        .HasForeignKey("LoanID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Loan");
                });

            modelBuilder.Entity("BookManagement.BusinessObjects.Order", b =>
                {
                    b.HasOne("BookManagement.BusinessObjects.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("BookManagement.BusinessObjects.OrderItem", b =>
                {
                    b.HasOne("BookManagement.BusinessObjects.Book", "Book")
                        .WithMany("OrderItems")
                        .HasForeignKey("BookID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookManagement.BusinessObjects.Order", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("BookManagement.BusinessObjects.Author", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("BookManagement.BusinessObjects.Book", b =>
                {
                    b.Navigation("Loans");

                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("BookManagement.BusinessObjects.Category", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("BookManagement.BusinessObjects.Discount", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("BookManagement.BusinessObjects.Loan", b =>
                {
                    b.Navigation("LoanExtensions");
                });

            modelBuilder.Entity("BookManagement.BusinessObjects.Order", b =>
                {
                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("BookManagement.BusinessObjects.User", b =>
                {
                    b.Navigation("Loans");

                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
