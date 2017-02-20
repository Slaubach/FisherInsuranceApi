
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


    public class AutoController : Controller
    {


        private IMemoryStore db;

        public AutoController(IMemoryStore repo)
        
        {
            db = repo;
        }
    
        [HttpGet]
        public IActionResult GetQuotes()

        { return Ok(db.RetrieveAllQuotes); }

        [HttpPost]
        // GET: /<controller>/
        public IActionResult Post([FromBody] Quote quote)
        {
            return Ok(db.CreateQuote(quote));
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(db.RetrieveQuote(id));
        }
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]Quote quote)
        {
            return Ok(db.UpdateQuote(quote));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            db.DeleteQuote(id);
            return Ok();
        }
       
    }
}
