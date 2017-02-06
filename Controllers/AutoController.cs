
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

[Route("api/auto/quotes")]
    

    public class AutoController : Controller
    {
    [HttpPost]
    // GET: /<controller>/
    public IActionResult Post([FromBody]string value)
    {
        return Created("", value);
    }

    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        return Ok("The id is: " + id);
    }
    [HttpPut("{id}")]
    public IActionResult Put(int id, [FromBody]string value)
    {
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        return Delete(id);
    }
}

