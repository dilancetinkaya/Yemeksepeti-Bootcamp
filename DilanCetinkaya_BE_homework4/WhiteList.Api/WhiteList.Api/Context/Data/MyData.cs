using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WhiteList.Api.Context.Entities;

namespace WhiteList.Api.Context.Data
{
    public class MyData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new DataContext(
                serviceProvider.GetRequiredService<DbContextOptions<DataContext>>()))
            {
                if (context.Customers.Any() && context.Personels.Any())
                {
                    return;
                }

                context.Customers.Add(new Customer
                {
                    Id = 1,
                  Name="customer",
                  

                });
                context.Personels.Add(new Personel
                {
                    Id = 2,
                    Name = "personel",
                    Salary = 1000,


                }) ;
                context.SaveChanges();
            }

        }
    }
}
