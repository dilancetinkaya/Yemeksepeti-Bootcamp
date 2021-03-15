using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WhiteList.Api.Context.Interfaces;

namespace WhiteList.Api.Context.Entities
{
    public class Personel : IEntity
    {
        public int Id { get; set; }
        public string Name { get ; set ; }
        public int Salary { get; set; }
    }
}
