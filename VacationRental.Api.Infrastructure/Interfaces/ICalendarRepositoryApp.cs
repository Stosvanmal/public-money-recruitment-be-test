using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using VacationRental.Api.Business.Entities;

namespace VacationRental.Api.Infrastructure.Interfaces
{
    public interface ICalendarRepositoryApp
    {
        Task<IList<Booking>> GetCalendar(int rentalId, DateTime start, int nights);
    }
}
