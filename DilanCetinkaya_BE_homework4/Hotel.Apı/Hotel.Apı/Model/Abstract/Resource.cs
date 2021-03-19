using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel.Apı.Model.Abstract
{
    public class Resource
    {
        [JsonProperty(Order = -1)]
        public string Href { get; set; }
    }
}
