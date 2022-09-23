using VacationRental.Api.Aplication.Interfaces.Dtos;

namespace VacationRental.Api.Aplication.Dtos
{
    public class CalendarBookingDto: ICalendarBookingDto
    {
        public int Id { get; set; }
        public int Unit { get; set; }
    }
}
