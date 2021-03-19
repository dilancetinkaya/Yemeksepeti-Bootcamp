using GenericRepository.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericRepository.Domain.Entities
{
    public class Passenger : IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PhoneNumber { get; set; }
        public string Gender { get; set; }
    }
}