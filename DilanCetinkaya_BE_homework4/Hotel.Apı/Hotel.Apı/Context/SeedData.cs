
using Hotel.Apı.Model.Entities;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel.Apı.Context
{
    public static class SeedData
    {

        public static async Task InitializeAsync(IServiceProvider service)
        {
            await AddSampleData(service.GetRequiredService<HotelDbContext>());
        }

        public static async Task AddSampleData(HotelDbContext dbContext)
        {
            if (!dbContext.Rooms.Any())
            {
                dbContext.Rooms.Add(new RoomEntity
                {
                    Id = Guid.Parse("47103bcb-753a-48a3-ac74-2263977c85df"),
                    Name = "Standart Oda",
                    Rate = 34524,
                    IsMigrate = false
                });

                dbContext.Rooms.Add(new RoomEntity
                {
                    Id = Guid.Parse("a88cdd16-f627-4f95-95c3-783b7c0554aa"),
                    Name = "Suid Oda",
                    Rate = 34524,
                    IsMigrate = false
                });
            }

            if (!dbContext.Users.Any())
            {
                dbContext.Users.Add(new UserEntity
                {
                    Id = 1,
                    Name = "name",
                    SurName = "surname",
                    LoginName = "nms",
                    Password = "1234",
                    Phone = "0548133122"
                });
            }

            await dbContext.SaveChangesAsync();

        }

    }
}
