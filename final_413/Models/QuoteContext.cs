using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace final_413.Models
{
    public class QuoteContext : DbContext
    {
        //Constructor
        public QuoteContext(DbContextOptions<QuoteContext> options) : base(options)
        {

        }

        public DbSet<Quote> Quotes { get; set; }

        // seeding for database
        protected override void OnModelCreating(ModelBuilder mb)
        {

            mb.Entity<Quote>().HasData(

                new Quote
                {
                    QuoteId = 1,
                    Quote_body = "Before you marry a person, you should first make them use a computer with slow Internet to see who they really are.",
                    Author = "Will Ferrell",
                    Date = null,
                    Subject = null,
                    Citation = null,

                },
                new Quote
                {
                    QuoteId = 2,
                    Quote_body = "We are what we repeatedly do. Excellence, then, is not an act, but a habit.",
                    Author = "Will Durant",
                    Date = "1926",
                    Subject = "Philosophy",
                    Citation = null,

                },
                new Quote
                {
                    QuoteId = 3,
                    Quote_body = "It’s not bragging if it’s true.",
                    Author = "Harvey Specter",
                    Date = "2015",
                    Subject = null,
                    Citation = null,

                }


                );
        }
    }
}
