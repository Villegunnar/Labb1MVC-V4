using Bogus;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Labb1MVC_V4.Models
{
    public class BookDbContext : IdentityDbContext<IdentityUser>
    {


        public BookDbContext(DbContextOptions<BookDbContext> options) : base(options)
        {

        }


        public DbSet<Book> Books { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<LoanedBook> Loan { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var BookIds = 1;
            var bookStock = new Faker<Book>()
                .RuleFor(m => m.BookId, f => BookIds++)
                .RuleFor(m => m.BookName, f => f.Name.Random.Words())
                .RuleFor(m => m.BookAuthor, f => f.Name.FullName())
                .RuleFor(m => m.NumberOfBooksInStock, f => f.Random.Number(3, 3))
                .RuleFor(m => m.Description, f => f.Lorem.Paragraph());

  
                
                


            var custonerIds = 1;
            var customerStock = new Faker<Customer>()
                .RuleFor(m => m.CustomerId, f => custonerIds++)
                .RuleFor(m => m.CustomerFName, f => f.Name.FirstName())
                .RuleFor(m => m.CustomerLName, f => f.Name.LastName())
                .RuleFor(m => m.CustomerEmail, f => f.Internet.Email());

            var loanIds = 1;
            var LoanedBookStock = new Faker<LoanedBook>()
              .RuleFor(m => m.LoanedBookId, f => loanIds++)
              .RuleFor(m => m.BookId, f => f.Random.Number(1, 9))
              .RuleFor(m => m.CustomerId, f => f.Random.Number(1, 9));



            modelBuilder
                .Entity<Book>()
                .HasData(bookStock.GenerateBetween(10, 10));

            modelBuilder
                .Entity<Customer>()
                .HasData(customerStock.GenerateBetween(10, 10));

            modelBuilder
                .Entity<LoanedBook>()
                .HasData(LoanedBookStock.GenerateBetween(5, 5));









        }
    }
}
