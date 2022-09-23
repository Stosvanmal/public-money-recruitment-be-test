using System.Collections.Generic;

namespace VacationRental.Api.Aplication.Interfaces.Dtos
{
    public interface ICalendarDto
    {
       int RentalId { get; set; }
       List<ICalendarDateDto> Dates { get; set; }
       
    }
}
