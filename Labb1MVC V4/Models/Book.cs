using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Labb1MVC_V4.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }

        public string BookName { get; set; }

        public string BookAuthor { get; set; }

        public string Description { get; set; }

        public int NumberOfBooksInStock { get; set; }
        

        public ICollection<LoanedBook> LoanedBook { get; set; }

    }
}
