using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Labb1MVC_V4.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }

        [Required]
        [StringLength(25, MinimumLength = 2, ErrorMessage = "First Name must be between 2 and 25 characters")]
        public string CustomerFName { get; set; }

        [Required]
        [StringLength(25, MinimumLength = 2, ErrorMessage = "Last Name must be between 2 and 25 characters")]
        public string CustomerLName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        
        public string CustomerEmail { get; set; }

        public ICollection<LoanedBook> LoanedBook { get; set; }

    }
}
