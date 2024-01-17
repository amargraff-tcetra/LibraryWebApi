﻿using Dapper;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LibraryWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        // GET: api/<BooksController>
        [HttpGet]
        public List<string> Get()
        {
            var db = new SqlConnection("Data Source=127.0.0.1,1433;Initial Catalog=master;Persist Security Info=True;User ID=sa;Password=SQLserver123!;Trust Server Certificate=True");

            return new List<string> 
            { 
                "The Hobbit",
                "Dune",
                "Harry Potter and the Sourecer's Stone",
                "The Lion, Witch and the Wordrobe",
                "The Lord of the Rings"
            };
        }

        // GET api/<BooksController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<BooksController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<BooksController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<BooksController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}