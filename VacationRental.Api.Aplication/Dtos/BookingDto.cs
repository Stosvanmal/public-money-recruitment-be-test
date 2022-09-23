using System;
using VacationRental.Api.Aplication.Interfaces.Dtos;

namespace VacationRental.Api.Aplication.Dtos
{
    public class BookingDto: IBookingDto
    {
        public int Id { get; set; }
        public int RentalId { get; set; }
        public IRentalDto RentalDto { get; set; }
        public DateTime Start { get; set; }
        public int Nights { get; set; }
    }
}
