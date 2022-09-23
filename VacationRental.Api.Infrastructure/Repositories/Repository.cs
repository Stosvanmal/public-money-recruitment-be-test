using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using VacationRental.Api.Business.Entities;
using VacationRental.Api.Business.Interfaces;
using VacationRental.Api.Infrastructure.Interfaces;

namespace VacationRental.Api.Infrastructure.Repositories
{
    public class Repository: ICalendarRepositoryApp, IRentalRepository
    {
        public Repository()
        {
            //injected context
        }
        public async Task<IList<Booking>> GetCalendar(int rentalId, DateTime start, int nights)
        {
            //mapper to Booking
            return new List<Booking>();
        }
        public async Task<int> CreateRental(IRentalModel rental)
        {
            //mapper to rentalDAO using automapper 
            return 1;
        }

    }
}
