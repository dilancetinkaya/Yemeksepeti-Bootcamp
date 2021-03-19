using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Odev2.Data.Entity.Abstract
{
    public abstract class Advertisement

    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public int Price { get; set; }


    }

}
