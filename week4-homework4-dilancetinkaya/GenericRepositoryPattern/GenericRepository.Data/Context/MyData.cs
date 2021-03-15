using GenericRepository.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericRepository.Data.Context
{
    public class MyData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new TripContext(
                serviceProvider.GetRequiredService<DbContextOptions<TripContext>>()))
            {
                if (context.Tickets.Any() && context.Passengers.Any())
                {
                    return;
                }

                context.Tickets.Add(new Ticket
                {
                    Price = 50,
                    Id = 1,
                    Destination = "Antalya",
                    Origin = "İstanbul"

                });
                context.Passengers.Add(new Passenger
                {
                    LastName = "cetinkaya",
                    FirstName = "dilan",
                    Id = 2,
                    Gender = "female",
                    PhoneNumber = 051514155


                });
                context.SaveChanges();
            }

        }
    }
}

