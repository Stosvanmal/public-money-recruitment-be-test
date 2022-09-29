using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using VacationRental.Api.Aplication.Dtos;
using VacationRental.Api.Aplication.Interfaces.Dtos;
using VacationRental.Api.Business.Dtos;
using VacationRental.Api.Infrastructure.Interfaces;

namespace VacationRental.Api.Aplication.Queries
{
    public class CalendarQueryHandler : IRequestHandler<CalendarQuery, CalendarAppDto>
    {
        private readonly ICalendarRepositoryApp calendarRepositoryApp;

        public CalendarQueryHandler(ICalendarRepositoryApp calendarRepositoryApp)
        {
            this.calendarRepositoryApp = calendarRepositoryApp;
        }
        public async Task<CalendarAppDto> Handle(CalendarQuery request, CancellationToken cancellationToken)
        {
            int nights = request.Nights + 1;
            IList<BookingDto> bookings = await calendarRepositoryApp.GetCalendar(request.RentalId, request.Start, nights);
            ICalendarAppDto calendarDto = new CalendarAppDto();
            calendarDto.RentalId = request.RentalId;       
            DateTime date = request.Start;
            DateTime dateFinal = request.Start.AddDays(nights);
            while (date< dateFinal)
            {
                var bookingInDates = bookings.Where(x => date >= x.Start && date <= x.Start.AddDays(x.Nights))
                    .Select(x => new CalendarBookingAppDto { Id = x.Id, Unit = x.Rental.Units }).ToList<ICalendarBookingAppDto>();

                var preparationTimesInDates = bookings.Where(x => date >= x.Start.AddDays(x.Nights) && date <= x.Start.AddDays(x.Nights + x.Rental.PreparationTimeInDays))
                    .Select(x => new PreparationTimesAppDto { Unit = x.Rental.Units }).ToList<IPreparationTimesAppDto>();

                calendarDto.Dates.Add(new CalendarDateAppDto
                {
                    Date = date,
                    Bookings = bookingInDates,
                    PreparationTimes = preparationTimesInDates
                });
                date = date.AddDays(1);
            }            

            return (CalendarAppDto)calendarDto;
        }
    }
}
