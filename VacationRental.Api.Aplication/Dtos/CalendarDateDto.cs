using System;
using System.Collections.Generic;
using VacationRental.Api.Aplication.Interfaces.Dtos;

namespace VacationRental.Api.Aplication.Dtos
{
    public class CalendarDateDto: ICalendarDateDto
    {
        public DateTime Date { get; set; }
        public List<ICalendarBookingDto> Bookings { get; set; } = new List<ICalendarBookingDto>();
        public List<IPreparationTimesDto> PreparationTimes { get; set; } = new List<IPreparationTimesDto>();
    }
}
