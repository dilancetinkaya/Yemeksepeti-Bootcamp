using Hotel.Apı.Model.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel.Apı.Model.Derived
{
    public class Room : Resource
    {
        public string Name { get; set; }
        public int Rate { get; set; }
    }
}
