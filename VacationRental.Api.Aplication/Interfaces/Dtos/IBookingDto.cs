using System;

namespace VacationRental.Api.Aplication.Interfaces.Dtos
{
    public interface IBookingDto
    {
        int Id { get; set; }
        int RentalId { get; set; }
        IRentalDto RentalDto { get; set; }
        DateTime Start { get; set; }
        int Nights { get; set; }
    }
}
