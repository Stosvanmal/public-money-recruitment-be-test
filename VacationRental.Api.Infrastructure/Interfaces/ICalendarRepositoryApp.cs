using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using VacationRental.Api.Business.Dtos;

namespace VacationRental.Api.Infrastructure.Interfaces
{
    public interface ICalendarRepositoryApp
    {
        Task<IList<BookingDto>> GetCalendar(int rentalId, DateTime start, int nights);
    }
}
