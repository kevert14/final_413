using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace final_413.Models
{
    public class Quote 
    {
        [Key]
        [Required]
        public int QuoteId { get; set; }

        [Required]
        public string Quote_body { get; set; }

        [Required]
        public string Author { get; set; }

        public string Date { get; set; }
        public string Subject { get; set; }
        public string Citation { get; set; }

    }
}
