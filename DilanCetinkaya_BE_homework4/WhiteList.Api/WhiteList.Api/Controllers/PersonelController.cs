
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
    public class PersonelController : ControllerBase
    {
        private DataContext _context;

        public PersonelController(DataContext context)
        {
            _context = context;
        }

        [HttpGet(Name = nameof(GetPersonel))]
        public IActionResult GetPersonel()
        {

            List<Personel> songs = _context.Personels.ToList();
            return Ok(songs);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Personel personel = _context.Personels.FirstOrDefault(personel => personel.Id == id);
            return Ok(personel);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Personel personel)
        {
            _context.Add(personel);
            return Ok();
        }
    }
}

