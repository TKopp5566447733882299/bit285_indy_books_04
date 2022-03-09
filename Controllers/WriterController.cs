using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IndyBooks.Models;
using IndyBooks.ViewModels;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace IndyBooks.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WriterController : ControllerBase
    {
        private IndyBooksDataContext _dbc;
        public WriterController(IndyBooksDataContext db) { _dbc = db; }
        // GET: api/<WriterController>
        [HttpGet]
        public IActionResult Get()
        {
            


            return Ok(_dbc.Writers);
        }

        // GET api/<WriterController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id){
            return Ok(_dbc.Writers.Where(c => c.Id == id));
        }

        // POST api/<WriterController>
        [HttpPost]
        public IActionResult Post([FromBody] Writer ImputWriter)
        {

            _dbc.Add(ImputWriter);
            _dbc.SaveChanges();
            return Accepted();
        }

        // PUT api/<WriterController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value){

        }

        // DELETE api/<WriterController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
