using System;
using System.Threading.Tasks;
using VacationRental.Api.Infrastructure.Interfaces;

namespace VacationRental.Api.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork()
        {
            //context injected
        }
        public async Task SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
