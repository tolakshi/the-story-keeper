using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace TheStoryKeeper.Models
{
    public class Book
    {
        [Key]
        public int AutoId { get; set; }

        [Required]
        [MaxLength(40)]
        [MinLength(36)]
        [Display(Name = "ISBN")]
        public string BookId { get; set; }

        [Required]
        [MaxLength(250)]
        [Display(Name = "Book Name")]
        public string BookName { get; set; }

        [Display(Name = "Is Reserved?")]
        public bool BookAvailability { get; set; }

        [AllowNull]
        [MaxLength(50)]
        [Display(Name = "Order Number")]
        public string OrderNumber { get; set; }

        public Book()
        {

        }
    }
}
