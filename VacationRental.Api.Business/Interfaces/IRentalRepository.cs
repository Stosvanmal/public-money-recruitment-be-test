using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using VacationRental.Api.Business.Models;

namespace VacationRental.Api.Business.Interfaces
{
    public interface IRentalRepository
    {
        Task<int> CreateRental(IRentalModel rental);
    }
}
