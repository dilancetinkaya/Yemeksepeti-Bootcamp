using Odev2.Data.Entities;
using Odev2.Data.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Odev2.Data.Entity.Concrete
{
    public class CarAd : Advertisement
    {
       
        public string Brand { get; set; }
        public string Model { get; set; }
        
        public int Year { get; set; }
        public FuelType Fuel { get; set; }
       
    }

}

