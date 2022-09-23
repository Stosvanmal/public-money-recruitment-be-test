using System;
namespace VacationRental.Api.Business.Models
{
    public class BookingModel
    {
        public int Id { get; set; }
        public int RentalId { get; private set; }
        public RentalModel RentalDto { get; private set; }
        public DateTime Start { get; private set; }
        public int Nights { get; private set; }
    }
}
