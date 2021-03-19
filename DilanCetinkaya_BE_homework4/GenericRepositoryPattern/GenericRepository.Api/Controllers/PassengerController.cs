using GenericRepository.Data.Context;
using GenericRepository.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenericRepository.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PassengerController : ControllerBase
    {
        private TripContext _context;
        public PassengerController(TripContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Get()
        {
            List<Passenger> datas = _context.Passengers.ToList();


            return Ok(datas);
        }
        [HttpGet("{id}")]
        public Passenger Get(int id)
        {
            var data = _context.Passengers.FirstOrDefault(c => c.Id == id);
            return data;
        }
        [HttpPut("{id}")]
        public Passenger Put([FromBody] Passenger passenger)
        {


            var editpassenger = _context.Passengers.FirstOrDefault(x => x.Id == passenger.Id);
            editpassenger.FirstName = passenger.FirstName;
            editpassenger.Gender = passenger.Gender;
            editpassenger.LastName = passenger.LastName;
            editpassenger.PhoneNumber = passenger.PhoneNumber;
            return editpassenger;



        }

        [HttpPost]
        public void Post([FromBody] Passenger passenger)
        {
            _context.Passengers.Add(passenger);

        }
        [HttpDelete]
        public void Delete(int id)
        {
            var deletePassenger = _context.Passengers.FirstOrDefault(x => x.Id == id);
            _context.Passengers.Remove(deletePassenger);
        }
    }
}


