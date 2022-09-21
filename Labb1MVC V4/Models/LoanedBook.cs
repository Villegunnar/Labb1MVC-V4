using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Labb1MVC_V4.Models
{
    public class LoanedBook
    {
        [Key]
        public int LoanedBookId { get; set; }

        public int BookId { get; set; }

        public Book Book { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public DateTime LoanDate { get; set; } = DateTime.Now;

        public DateTime ReturnDate { get; set; } = DateTime.Now.AddDays(30);
        
    }
}
