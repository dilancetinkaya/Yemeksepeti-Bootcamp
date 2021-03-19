using GenericRepository.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepository.Domain.Repositories
{
    public interface IRepository : IRepositoryBase<Passenger>
    {
        Task<Passenger> GetByPassengerIdAsync(int passengerId);
    }
}
