
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


using FisherInsuranceApi.Models;
using FisherInsuranceApi.Data;



// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860
namespace FisherInsuranceApi.Controllers
{
    [Route("api/customer/claims")]

    public class ClaimsController : Controller
    {

        private readonly FisherContext db;

        public ClaimsController(FisherContext context)
        {
            db = context;
        }

        [HttpGet]
        public IActionResult GetClaims()

        { return Ok(db.Claims); }

        // GET: /<controller>/

        [HttpPost]
        // GET: /<controller>/
        public IActionResult Post([FromBody]Claim claim)
        {
            var newClaim = db.Claims.Add(claim);

            db.SaveChanges();

            return CreatedAtRoute("GetClaim", new { id = claim.Id }, claim);        }

        [HttpGet("{id}", Name ="GetClaim")]
        public IActionResult Get(int id)
        {
            return Ok(db.Claims.Find(id));        }
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]Claim claim)
        {
            var newClaim = db.Claims.Find(id);
            if (newClaim == null)
            {
                return NotFound();
            }
            newClaim = claim;
            db.SaveChanges();
            return Ok(newClaim);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var claimToDelete = db.Claims.Find(id);

            if (claimToDelete == null)
            {
                return NotFound();
            }

            db.Claims.Remove(claimToDelete);

            db.SaveChangesAsync();

            return NoContent();
        }
    }
}