using System;
using System.Collections.Generic;
using System.Text;
using VacationRental.Api.Business.Entities;

namespace VacationRental.Api.Business.Interfaces.Entities
{
    public interface IBooking
    {
        int Id { get; set; }
        int RentalId { get; }
        Rental Rental { get; }
        DateTime Start { get; }
        int Nights { get; }
    }
}
