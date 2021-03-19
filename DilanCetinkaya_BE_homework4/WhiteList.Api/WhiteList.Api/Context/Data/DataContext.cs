using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WhiteList.Api.Context.Entities;

namespace WhiteList.Api.Context.Data
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }


        public DbSet<Personel> Personels { get; set; }
        public DbSet<Customer> Customers { get; set; }


    }
}