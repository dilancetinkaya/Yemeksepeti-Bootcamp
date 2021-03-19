using Microsoft.EntityFrameworkCore;
using Odev2.Data.Entity.Abstract;
using Odev2.Data.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Odev2.Data
{
    public class DatabaseContext : DbContext
    {

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }
        public DbSet<CarAd> Cars { get; set; }
        public DbSet<HouseAd> Houses { get; set; }
    }

}