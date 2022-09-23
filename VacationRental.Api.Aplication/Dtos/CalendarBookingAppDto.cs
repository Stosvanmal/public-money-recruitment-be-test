using VacationRental.Api.Aplication.Interfaces.Dtos;

namespace VacationRental.Api.Aplication.Dtos
{
    public class CalendarBookingAppDto: ICalendarBookingAppDto
    {
        public int Id { get; set; }
        public int Unit { get; set; }
    }
}
