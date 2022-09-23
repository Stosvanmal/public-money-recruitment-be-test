using System.Collections.Generic;
using VacationRental.Api.Aplication.Interfaces.Dtos;

namespace VacationRental.Api.Aplication.Dtos
{
    public class CalendarDto:ICalendarDto
    {
        public int RentalId { get; set; }
        public List<ICalendarDateDto> Dates { get; set; } = new List<ICalendarDateDto>();
    }
}
