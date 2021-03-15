using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Odev2.Data;
using Odev2.Data.Entities;
using Odev2.Data.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Odev2.Generator
{
    public class DataGenerator
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new DatabaseContext(
                serviceProvider.GetRequiredService<DbContextOptions<DatabaseContext>>()))
            {
                if (context.Cars.Any() && context.Houses.Any())
                {
                    return;
                }
                Random rand = new Random();
                Type type = typeof(FuelType);
                Array values = type.GetEnumValues();
                for (int i = 1; i <= 10; i++)
                {

                    context.Cars.Add(
                        new CarAd
                        {
                            Id = i,
                            CreateDate = new DateTime(2019, 2, 1 + i),
                            Price = 500 + 10 * i,
                            Brand = "Marka" + i,
                            Model = "A" + i,
                            Year = 2000 + i,
                            Fuel = (FuelType)values.GetValue(rand.Next(1, 4))

                        }) ;
                }
                for (int i = 1; i <= 10; i++)
                {
                    context.Houses.Add(
                        new HouseAd
                        {
                            Id = 1 + i,
                            CreateDate = new DateTime(2019, 2, 1 + i),
                            Price = 500 + i * 10,
                            NumberRooms = i,
                            FloorNumber = 2 + i,
                            BuildingAge = 1 + i,
                            Area = 95 + i

                        });
                }
                context.SaveChanges();

            }
        }

    }
}
