using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DapperApi.Model
{
    public class OrderHeader
    {
        public int PurchaseOrderID { get; set; }
        public int EmployeeID { get; set; }
        public int Status { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
