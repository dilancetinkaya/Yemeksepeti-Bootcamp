using Odev2.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Odev2.Model
{
    public class CarDTO
    {
        public int Price { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public string Fuel { get; set; }

    }
}
   

