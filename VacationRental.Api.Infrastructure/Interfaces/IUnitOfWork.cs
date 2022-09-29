using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace VacationRental.Api.Infrastructure.Interfaces
{
    public interface IUnitOfWork
    {
        Task SaveChanges();
    }
}
