using System.Threading.Tasks;
using VacationRental.Api.Business.Interfaces.Entities;

namespace VacationRental.Api.Business.Interfaces
{
    public interface IRentalRepository
    {
        Task<int> AddRental(IRental rental);
    }
}
