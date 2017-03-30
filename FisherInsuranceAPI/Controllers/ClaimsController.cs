using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FisherInsuranceAPI.Models;
using FisherInsuranceAPI.Data;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860


    [Route("api/customer/claims")]
    public class ClaimsController : Controller
    {
        private readonly FisherContext db;
        public ClaimsController(FisherContext Context)
        {
            db = Context;
        }
        [HttpGet]
        public IActionResult GetClaims()
        {
            return Ok(db.Claims);
        }

        [HttpGet("{id}", Name = "GetClaim")]
        public IActionResult Get(int id)
        {
            return Ok(db.Claims.Find(id));
        }
        [HttpPost]
        public IActionResult Post([FromBody] Claim claim)
        {
        try
        {
            var newClaim = db.Claims.Add(claim);
            db.SaveChanges();
        }
        catch (Exception e) { e.ToString(); }

            return CreatedAtRoute("GetClaim", new { id = claim.Id }, claim);
        }
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Claim claim)
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
            { return NotFound(); }
            db.Claims.Remove(claimToDelete);
            db.SaveChangesAsync();
            return NoContent();
        }


    }

