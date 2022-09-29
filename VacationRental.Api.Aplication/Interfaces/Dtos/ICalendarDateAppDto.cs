using System;
using System.Collections.Generic;

namespace VacationRental.Api.Aplication.Interfaces.Dtos
{
    public interface ICalendarDateAppDto
    {
         DateTime Date { get; set; }
         List<ICalendarBookingAppDto> Bookings { get; set; }
         List<IPreparationTimesAppDto> PreparationTimes { get; set; }
    }
}
