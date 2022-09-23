using VacationRental.Api.Business.Dtos;
using VacationRental.Api.Business.Interfaces.Entities;

namespace VacationRental.Api.Business.Interfaces
{
    public interface IRentalFactory
    {
        IRental CreateRental(RentalDto rentalDto);
    }
}
