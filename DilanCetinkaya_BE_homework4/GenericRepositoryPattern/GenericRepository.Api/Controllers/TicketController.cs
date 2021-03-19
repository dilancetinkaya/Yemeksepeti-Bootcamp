using GenericRepository.Data.Context;
using GenericRepository.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenericRepository.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TicketController : ControllerBase
    {
        private TripContext _context;
        public TicketController(TripContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Get()
        {
            List<Ticket> datas = _context.Tickets.ToList();


            return Ok(datas);
        }
        [HttpGet("{id}")]
        public Ticket Get(int id)
        {
            var data = _context.Tickets.FirstOrDefault(c => c.Id == id);
            return data;
        }
        [HttpPut("{id}")]
        public Ticket Put([FromBody] Ticket ticket)
        {


            var editticket = _context.Tickets.FirstOrDefault(x => x.Id == ticket.Id);
            editticket.Date = ticket.Date;
            editticket.Destination = ticket.Destination;
            editticket.Origin = ticket.Origin;
            editticket.Price = ticket.Price;

            return editticket;



        }

        [HttpPost]
        public void Post([FromBody] Ticket ticket)
        {
            _context.Tickets.Add(ticket);

        }
        [HttpDelete]
        public void Delete(int id)
        {
            var deleteTicket = _context.Tickets.FirstOrDefault(x => x.Id == id);
            _context.Tickets.Remove(deleteTicket);
        }
    }
}

