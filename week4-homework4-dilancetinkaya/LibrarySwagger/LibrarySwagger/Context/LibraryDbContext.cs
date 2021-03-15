using LibrarySwagger.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibrarySwagger.Context
{
    public class LibraryDbContext : DbContext
    {
        public LibraryDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<LibraryInfo> Library { get; set; }
        public DbSet<BooksInfo> Books { get; set; }


    }
}

