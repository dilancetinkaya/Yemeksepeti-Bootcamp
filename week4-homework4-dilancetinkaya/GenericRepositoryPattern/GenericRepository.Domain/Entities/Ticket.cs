using GenericRepository.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericRepository.Domain.Entities
{
    public class Ticket : IEntity
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int Price { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }

    }
}