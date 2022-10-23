﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        public string BookName { get; set; }

        [Display(Name = "Is Available?")]
        public bool BookAvailability { get; set; }

        public Book(int autoId, string bookId, string bookName, bool bookAvailability)
        {
            AutoId = autoId;
            BookId = bookId;
            BookName = bookName;
            BookAvailability = bookAvailability;
        }
    }
}