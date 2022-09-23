using System;
using VacationRental.Api.Aplication.Interfaces.Dtos;

namespace VacationRental.Api.Aplication.Dtos
{
    public class BookingAppDto: IBookingAppDto
    {
        public int Id { get; set; }
        public int RentalId { get; set; }
        public IRentalAppDto RentalDto { get; set; }
        public DateTime Start { get; set; }
        public int Nights { get; set; }
    }
}
