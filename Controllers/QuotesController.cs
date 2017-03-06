
using Microsoft.AspNetCore.Mvc;
using FisherInsuranceApi.Data;
using FisherInsuranceApi.Models;
using System.Linq;
using System.Collections.Generic;
using System;
using System.Threading.Tasks;
// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860
namespace FisherInsurance.Controllers
{

    [Route("api/auto/quotes")]


    public class QuotesController : Controller
    {
        private readonly FisherContext db;

        public QuotesController(FisherContext context)
        {
            db = context;
        }



        [HttpGet]
        public IActionResult GetQuotes()

        { return Ok(db.Quotes); }

        [HttpPost]
        // GET: /<controller>/
        public IActionResult Post([FromBody] Quote quote)
        {
            var newClaim = db.Quotes.Add(Quotes);

            db.SaveChanges();

            return CreatedAtRoute("GetClaim", new { id = quote.Id }, quote);
        }

        [HttpGet("{id}", Name ="GetQuote")]
        public IActionResult Get(int id)
        {
            return Ok(db.Quotes.Find(id));        }
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]Quote quote)
        {
            var newClaim = db.Quotes.Find(id);

            if (newClaim == null)
            {
                return NotFound();
            }

            newClaim = Quotes;

            db.SaveChanges();

            return Ok(newClaim);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var claimToDelete = db.Quotes.Find(id);

            if (claimToDelete == null)
            {
                return NotFound();
            }

            db.Quotes.Remove(claimToDelete);

            db.SaveChangesAsync();

            return NoContent();
        }

    }
}
