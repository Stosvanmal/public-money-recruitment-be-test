using System.Collections.Generic;
using VacationRental.Api.Aplication.Interfaces.Dtos;

namespace VacationRental.Api.Aplication.Dtos
{
    public class CalendarAppDto:ICalendarAppDto
    {
        public int RentalId { get; set; }
        public List<ICalendarDateAppDto> Dates { get; set; } = new List<ICalendarDateAppDto>();
    }
}
