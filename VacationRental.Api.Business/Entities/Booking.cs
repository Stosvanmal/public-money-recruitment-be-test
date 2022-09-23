using System;
using VacationRental.Api.Business.Interfaces;

namespace VacationRental.Api.Business.Entities
{
    public class Booking: IEntities
    {
        public int Id { get; set; }
        public int RentalId { get; set; }
        public Rental Rental { get; set; }
        public DateTime Start { get; set; }
        public int Nights { get; set; }
    }
}
