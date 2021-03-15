using LibrarySwagger.Context;
using LibrarySwagger.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibrarySwagger.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibraryController : ControllerBase
    {
        private LibraryDbContext _context;
        public LibraryController(LibraryDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Get()
        {
            List<LibraryInfo> datas = _context.Library.ToList();


            return Ok(datas);
        }
        [HttpGet("{id}")]
        public LibraryInfo Get(int id)
        {
            var data = _context.Library.FirstOrDefault(c => c.Id == id);
            return data;
        }
        [HttpPut("{id}")]
        public LibraryInfo Put([FromBody] LibraryInfo library)
        {
            var editlibrary = _context.Library.FirstOrDefault(x => x.Id == library.Id);
            editlibrary.Title = library.Title;
            editlibrary.Email = library.Email;
            editlibrary.WebSite = library.WebSite;
            return library;
        }

        [HttpPost]
        public void Post([FromBody] LibraryInfo library)
        {
            _context.Library.Add(library);

        }
    }
}


 
