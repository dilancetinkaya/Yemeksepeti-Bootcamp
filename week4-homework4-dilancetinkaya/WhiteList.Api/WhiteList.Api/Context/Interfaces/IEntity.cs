using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WhiteList.Api.Context.Interfaces
{
    public interface IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
