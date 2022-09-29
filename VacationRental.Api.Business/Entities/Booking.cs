using System;
using VacationRental.Api.Business.Interfaces.Entities;

namespace VacationRental.Api.Business.Entities
{
    public class Booking: IEntities, IBooking
    {
        public int Id { get; set; }
        public int RentalId { get; private set; }
        public Rental Rental { get; private set; }
        public DateTime Start { get; private set; }
        public int Nights { get; private set; }
        public Booking(int id, int rentalId, Rental rental, DateTime start, int nights)
        {
            Id = id;
            RentalId = rentalId;
            Rental = rental;
            Start = start;
            Nights = nights;
        }
    }
}
