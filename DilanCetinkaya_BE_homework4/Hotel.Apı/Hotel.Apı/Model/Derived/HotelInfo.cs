using Hotel.Apı.Model.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel.Apı.Model.Derived
{
   
        public class HotelInfo : Resource
        {
            public string Title { get; set; }
            public string Email { get; set; }
            public string WebSite { get; set; }
            public HotelAddress Location { get; set; }
        }
    }

