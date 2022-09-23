using System;
using System.Collections.Generic;
using VacationRental.Api.Aplication.Interfaces.Dtos;

namespace VacationRental.Api.Aplication.Dtos
{
    public class CalendarDateAppDto: ICalendarDateAppDto
    {
        public DateTime Date { get; set; }
        public List<ICalendarBookingAppDto> Bookings { get; set; } = new List<ICalendarBookingAppDto>();
        public List<IPreparationTimesAppDto> PreparationTimes { get; set; } = new List<IPreparationTimesAppDto>();
    }
}
