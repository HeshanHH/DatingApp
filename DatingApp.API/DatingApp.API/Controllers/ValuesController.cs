using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatingApp.API.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly DataContext _context;

        public ValuesController(DataContext context)
        {
            _context = context;
            //intecting our data to this class.
            // give the name to the DataContext
            // initialize field from the parameter.
            //then u can use it to acces dabcontext in this class
        }
        // GET: api/Values
        [HttpGet]
        public async Task<IActionResult> GetaValue()
        {
            //IActionResult can return some hhtp request like ok. 
            var values = await _context.Values.ToListAsync();
            //you can access EF database  functions and various functions..
            return Ok(values);
            //make this as a asynchonouse adding async await and TolistAsync

        }

        // GET: api/Values/5
        [HttpGet("{id}", Name = "Get")]
        public async Task<IActionResult> GetValue(int id)
        {
            var value = await _context.Values.FirstOrDefaultAsync(x => x.Id == id);
            return Ok(value);
        }

        // POST: api/Values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
