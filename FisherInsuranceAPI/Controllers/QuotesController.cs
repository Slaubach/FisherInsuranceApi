using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FisherInsuranceAPI.Models;
using FisherInsuranceAPI.Data;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace FisherInsuranceAPI.Controllers
{
    [Route("api/[controller]")]
    public class QuotesController : Controller
    {
        private readonly FisherContext db;
        public QuotesController(FisherContext Context)
        {
            db = Context;
        }

        [HttpGet]
        public IActionResult GetQuotes()
        {
            return Ok(db.Quotes);
        }

        [HttpGet("{id}", Name = "GetQuote")]
        public IActionResult Get(int id)
        {
            return Ok(db.Quotes.Find(id));
        }
        [HttpPost]
        public IActionResult Post([FromBody] Quote quote)
        {
            try
            {
                var newQuote = db.Quotes.Add(quote);
                db.SaveChanges();
            }
            catch (Exception e) { e.ToString(); }

            return CreatedAtRoute("GetQuote", new { id = quote.Id }, quote);
        }
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Quote quote)
        {
            var newQuote = db.Quotes.Find(id);
            if (newQuote == null)
            {
                return NotFound();

            }
            newQuote = quote;
            db.SaveChanges();
            return Ok(newQuote);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var quoteToDelete = db.Quotes.Find(id);
            if (quoteToDelete == null)
            { return NotFound(); }
            db.Quotes.Remove(quoteToDelete);
            db.SaveChangesAsync();
            return NoContent();
        }
    }
}
