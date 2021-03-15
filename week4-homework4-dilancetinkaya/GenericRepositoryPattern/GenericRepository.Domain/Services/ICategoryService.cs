using GenericRepository.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepository.Domain.Services
{
    public interface ICategoryService : IServiceBase<Passenger>
    {
        Task<Passenger> GetByPassengerIdAsync(int passengerId);
    }
}
