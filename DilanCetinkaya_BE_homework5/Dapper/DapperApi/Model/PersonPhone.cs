using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DapperApi.Model
{
    public class PersonPhone
    {
        public int BusinessEntityID { get; set; }
    public string PhoneNumber { get; set; }
    public int PhoneNumberTypeID { get; set; }
    public DateTime ModifiedDate { get; set; }
}
}
