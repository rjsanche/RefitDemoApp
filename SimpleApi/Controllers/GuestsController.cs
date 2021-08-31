﻿using Microsoft.AspNetCore.Mvc;
using SimpleApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SimpleApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GuestsController : ControllerBase
    {
        private static List<GuestModel> _guests = new List<GuestModel>()
        {
            new GuestModel {Id = 1, FirstName = "Raul", LastName ="Jimenez"},
            new GuestModel {Id = 2, FirstName = "Pilar", LastName ="Lera"},
            new GuestModel {Id = 3, FirstName = "Gonzalo", LastName ="Jimenez"},
            new GuestModel {Id = 4, FirstName = "Candela", LastName ="Jimenez"},
            new GuestModel {Id = 5, FirstName = "Berta", LastName ="Jimenez"},
        };

        // GET: api/<GuessController>
        [HttpGet]
        public List<GuestModel> Get()
        {
            return _guests;
        }

        // GET api/<GuessController>/5
        [HttpGet(template: "{id}")]
        public GuestModel Get(int id)
        {
            return _guests.Where(x => x.Id == id).FirstOrDefault();
        }

        // POST api/<GuessController>
        [HttpPost]
        public void Post([FromBody] GuestModel value)
        {
            _guests.Add(value);
        }

        // PUT api/<GuessController>/5
        [HttpPut(template: "{id}")]
        public void Put(int id, [FromBody] GuestModel value)
        {
            _guests.Remove(_guests.Where(x=> x.Id == id).FirstOrDefault());
            _guests.Add(value);
        }

        // DELETE api/<GuessController>/5
        [HttpDelete(template: "{id}")]
        public void Delete(int id)
        {
            _guests.Remove(_guests.Where(x => x.Id == id).FirstOrDefault());            
        }
    }
}
