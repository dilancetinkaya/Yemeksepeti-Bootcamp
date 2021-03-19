using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel.Apı.Model
{
    public class TokenRequest
    {
        public string LoginUser { get; set; }
        public string LoginPassword { get; set; }
    }
}
