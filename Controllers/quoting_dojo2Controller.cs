using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http; 
using quoting_dojo2.Models;
using quoting_dojo2.Factories;

namespace quoting_dojo2.Controllers
{
    public class quoting_dojo2Controller : Controller
    {
        private readonly QuoteFactory _quoteFactory;
        public quoting_dojo2Controller(){
            _quoteFactory = new QuoteFactory();
        }
        [HttpGet]
        [Route("")]
        public IActionResult Index(){
            return View();
        }
        [HttpGet]
        [RouteAttribute("quotes")]
        public IActionResult dash(){
            var allQuotes = _quoteFactory.FindAll();
            ViewBag.quotes = allQuotes;
            return View();
        }
        [HttpPost]
        [RouteAttribute("/quotes")]
        public IActionResult Create(Quote model){
            // Quote newQuote = new Quote{
            //     Name = Name,
            //     Content = Content,
            // };
            _quoteFactory.Add(model);
            return RedirectToAction("dash");
        }
    }
}
