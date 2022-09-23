using System;
using System.Collections.Generic;
using System.Text;

namespace VacationRental.Api.Infrastructure.Models
{
    internal class BookingDAO
    {
        public int Id { get;set; }
        public int RentalId { get; set; }
        public RentalDAO Rental { get; set; }
        public DateTime Start { get; set; }
        public int Nights { get; set; }


    }
}
