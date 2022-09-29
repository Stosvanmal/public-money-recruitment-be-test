using System;
using VacationRental.Api.Business.Interfaces;

namespace VacationRental.Api.Business.Dtos
{
    public class BookingDto
    {
        public int Id { get; set; }
        public int RentalId { get; set; }
        public RentalDto Rental { get; set; }
        public DateTime Start { get; set; }
        public int Nights { get; set; }
    }
}
