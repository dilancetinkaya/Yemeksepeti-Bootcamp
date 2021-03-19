using Odev2.Data.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Odev2.Data.Entity.Concrete
{
    public class HouseAd : Advertisement
    {
        public int NumberRooms { get; set; }
        public int FloorNumber { get; set; }
        public int BuildingAge { get; set; }
        public double Area { get; set; }
       
    }
}
