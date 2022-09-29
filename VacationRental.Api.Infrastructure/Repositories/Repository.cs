using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using VacationRental.Api.Business.Dtos;
using VacationRental.Api.Business.Entities;
using VacationRental.Api.Business.Interfaces;
using VacationRental.Api.Business.Interfaces.Entities;
using VacationRental.Api.Infrastructure.Interfaces;

namespace VacationRental.Api.Infrastructure.Repositories
{
    public class Repository: ICalendarRepositoryApp, IRentalRepository
    {
        public Repository()
        {
            //injected context
        }
        public async Task<IList<BookingDto>> GetCalendar(int rentalId, DateTime start, int nights)
        {
            //mapper to BookingDto
            return new List<BookingDto>();
        }
        public async Task<int> AddRental(IRental rental)
        {
            //mapper to rentalDAO using automapper 
            return 1;
        }

    }
}
