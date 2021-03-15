using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Odev2.Attributes
{
    public class AdvertisementRequest
    {
        [Required(ErrorMessage = "Id boş geçilemez")]
        public int Id { get; set; }

        [PriceCheck(0, ErrorMessage = "Fiyat minimum 0 olabilir")]
        public int Price { get; set; }
    
        
    }
}
