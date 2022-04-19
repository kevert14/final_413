using final_413.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace final_413.Controllers
{
    public class HomeController : Controller
    {
        private QuoteContext _QuoteContext { get; set; }

        // constructor
        public HomeController(QuoteContext temp)
        {

            _QuoteContext = temp;
        }

        // Constructor for displaying quotes 
        public IActionResult Index()
        {
            var quote = _QuoteContext.Quotes
                .OrderBy(x => x.Author)
                .ToList();
            return View(quote);
        }

        // get and post constructors for Inputting Quotes 
        [HttpGet]
        public IActionResult InputQuotes()
        {
            ViewBag.Quotes = _QuoteContext.Quotes.ToList();

            return View();
        }


        [HttpPost]
        public IActionResult InputQuotes(Quote quote)
        {
            if (ModelState.IsValid)
            {
                _QuoteContext.Add(quote);
                _QuoteContext.SaveChanges();
                return View(quote);
            }
            else
            {
                ViewBag.Quotes = _QuoteContext.Quotes.ToList();
                return View();
            }



        }


        // get and post constructors for editing quotes
        [HttpGet]
        public IActionResult Edit(int quoteid)
        {
            ViewBag.Quotes = _QuoteContext.Quotes.ToList();

            var quote = _QuoteContext.Quotes.Single(x => x.QuoteId == quoteid);

            return View("InputQuotes", quote);
        }

        [HttpPost]
        public IActionResult Edit(Quote quote)
        {
            _QuoteContext.Update(quote);
            _QuoteContext.SaveChanges();

            return RedirectToAction("index");
        }

        // get and post constructors for deleting movies
        [HttpGet]
        public IActionResult Delete(int quoteid)
        {
            var quote = _QuoteContext.Quotes.Single(x => x.QuoteId == quoteid);

            return View(quote);
        }

        [HttpPost]
        public IActionResult Delete(Quote quote)
        {
            _QuoteContext.Quotes.Remove(quote);
            _QuoteContext.SaveChanges();

            return RedirectToAction("index");
        }


    }

}

