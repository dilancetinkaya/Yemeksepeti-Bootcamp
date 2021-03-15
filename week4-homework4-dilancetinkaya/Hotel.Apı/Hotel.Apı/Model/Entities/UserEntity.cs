using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel.Apı.Model.Entities
{
    public class UserEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string LoginName { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
    }
}
