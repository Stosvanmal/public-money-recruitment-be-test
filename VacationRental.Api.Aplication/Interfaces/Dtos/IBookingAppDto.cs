using System;

namespace VacationRental.Api.Aplication.Interfaces.Dtos
{
    public interface IBookingAppDto
    {
        int Id { get; set; }
        int RentalId { get; set; }
        IRentalAppDto RentalDto { get; set; }
        DateTime Start { get; set; }
        int Nights { get; set; }
    }
}
