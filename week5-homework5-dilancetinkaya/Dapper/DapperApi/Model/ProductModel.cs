using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DapperApi.Model
{
    public class ProductModel
    {
        public int ProductModelID { get; set; }
        public string Name { get; set; }
        public virtual List<Product> Products { get; set; }
    }
}
