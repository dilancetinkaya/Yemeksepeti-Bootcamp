using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WhiteList.Api.Context.Data;
using WhiteList.Api.Context.Entities;
using WhiteList.Api.Filters;

namespace WhiteList.Api.Controllers
{
    [Route("api/[controller]")]
    [ServiceFilter(typeof(IpControlAttribute))]
    [ApiController]
    public class CustomerController: ControllerBase
    {
        private DataContext _context;
        public CustomerController(DataContext context)
        {
            _context = context;
        }

        [HttpGet(Name = nameof(GetCustomer))]
        public IActionResult GetCustomer()
        {

            List<Customer> albums = _context.Customers.ToList();
            return Ok(albums);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Customer customer = _context.Customers.FirstOrDefault(customer => customer.Id == id);
            return Ok(customer);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Customer customer)
        {
            _context.Add(customer);
            return Ok();
        }

    }
}

