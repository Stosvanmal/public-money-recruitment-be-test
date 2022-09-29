using System.Collections.Generic;

namespace VacationRental.Api.Aplication.Interfaces.Dtos
{
    public interface ICalendarAppDto
    {
       int RentalId { get; set; }
       List<ICalendarDateAppDto> Dates { get; set; }
       
    }
}
