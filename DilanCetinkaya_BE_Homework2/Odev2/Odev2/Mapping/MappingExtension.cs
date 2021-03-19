
using Odev2.Data.Entities;
using Odev2.Data.Entity.Concrete;
using Odev2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Odev2.Mapping
{
    public static class MappingExtension
    {

        public static List<CarDTO> CarMapping(this List<CarAd> cars)
        {
            List<CarDTO> result1 = new List<CarDTO>();

            for (int i = 0; i < cars.Count; i++)
            {
                result1.Add(new CarDTO
                {
                    Price = cars[i].Price,
                    Brand = cars[i].Brand,
                    Model = cars[i].Model,
                    Year = cars[i].Year,
                    Fuel = cars[i].Fuel.ToString()
                });
            }

            return result1;
        }
        public static List<HouseDTO> HouseMapping(this List<HouseAd> houses)
        {
            List<HouseDTO> result = new List<HouseDTO>();
            for (int i = 0; i < houses.Count; i++)
            {
                result.Add(new HouseDTO
                {
                    Price = houses[i].Price,
                    Area = houses[i].Area,
                    NumberRooms = houses[i].NumberRooms


                });
            }

            return result;
        }
    }
}