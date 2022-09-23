using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using VacationRental.Api.Aplication.Dtos;
using VacationRental.Api.Aplication.Interfaces.Dtos;
using VacationRental.Api.Business.Entities;
using VacationRental.Api.Infrastructure.Interfaces;

namespace VacationRental.Api.Aplication.Queries
{
    public class CalendarQueryHandler : IRequestHandler<CalendarQuery, CalendarDto>
    {
        private readonly ICalendarRepositoryApp calendarRepositoryApp;

        public CalendarQueryHandler(ICalendarRepositoryApp calendarRepositoryApp)
        {
            this.calendarRepositoryApp = calendarRepositoryApp;
        }
        public async Task<CalendarDto> Handle(CalendarQuery request, CancellationToken cancellationToken)
        {
            int nights = request.Nights + 1;
            IList<Booking> bookings = await calendarRepositoryApp.GetCalendar(request.RentalId, request.Start, nights);
            ICalendarDto calendarDto = new CalendarDto();
            calendarDto.RentalId = request.RentalId;       
            DateTime date = request.Start;
            DateTime dateFinal = request.Start.AddDays(nights);
            while (date< dateFinal)
            {
                var bookingInDates = bookings.Where(x => date >= x.Start && date <= x.Start.AddDays(x.Nights))
                    .Select(x => new CalendarBookingDto { Id = x.Id, Unit = x.Rental.Units }).ToList<ICalendarBookingDto>();

                var preparationTimesInDates = bookings.Where(x => date >= x.Start.AddDays(x.Nights) && date <= x.Start.AddDays(x.Nights + x.Rental.PreparationTimeInDays))
                    .Select(x => new PreparationTimesDto { Unit = x.Rental.Units }).ToList<IPreparationTimesDto>();

                calendarDto.Dates.Add(new CalendarDateDto
                {
                    Date = date,
                    Bookings = bookingInDates,
                    PreparationTimes = preparationTimesInDates
                });
                date = date.AddDays(1);
            }            

            return (CalendarDto)calendarDto;
        }
    }
}
