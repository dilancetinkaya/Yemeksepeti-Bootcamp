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
    public class BookController : ControllerBase
    {
        private LibraryDbContext _context;
        public BookController(LibraryDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Get()
        {
            List<BooksInfo> datas = _context.Books.ToList();


            return Ok(datas);
        }
        [HttpGet("{id}")]
        public BooksInfo Get(int id)
        {
            var data = _context.Books.FirstOrDefault(c => c.Id == id);
            return data;
        }
        [HttpPut("{id}")]
        public BooksInfo Put([FromBody] BooksInfo books)
        {
            var editbooks = _context.Books.FirstOrDefault(x => x.Id == books.Id);
            editbooks.Name = books.Name;
            editbooks.Page = books.Page;
            editbooks.Writer = books.Writer;


            return books;
        }

        [HttpPost]
        public void Post([FromBody] BooksInfo books)
        {
            _context.Books.Add(books);

        }
        [HttpDelete]
        public void Delete(int id)
        {
            var deleteProduct = _context.Books.FirstOrDefault(x => x.Id == id);
            _context.Books.Remove(deleteProduct);
        }
    }
}

