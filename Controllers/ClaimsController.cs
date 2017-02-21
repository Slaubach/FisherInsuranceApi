
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
        private IMemoryStore db;

        public ClaimsController(IMemoryStore repo)

        {
            db = repo;
        }

        [HttpGet]
        public IActionResult GetClaims()

        { return Ok(db.RetrieveAllClaims); }

        // GET: /<controller>/

        [HttpPost]
        // GET: /<controller>/
        public IActionResult Post([FromBody]Claim claim)
        {
            return Ok(db.CreateClaim(claim));
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(db.RetrieveClaim(id));
        }
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]Claim claim)
        {
            return Ok(db.UpdateClaim(claim));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            db.DeleteClaim(id);
            return Ok();
        }
    }
}