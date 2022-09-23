using System;
using System.Collections.Generic;

namespace VacationRental.Api.Aplication.Interfaces.Dtos
{
    public interface ICalendarDateDto
    {
         DateTime Date { get; set; }
         List<ICalendarBookingDto> Bookings { get; set; }
         List<IPreparationTimesDto> PreparationTimes { get; set; }
    }
}
