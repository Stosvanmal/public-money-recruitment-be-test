using Moq;
using System;
using System.Collections.Generic;
using System.Threading;
using VacationRental.Api.Aplication.Dtos;
using VacationRental.Api.Aplication.Interfaces.Dtos;
using VacationRental.Api.Aplication.Queries;
using VacationRental.Api.Business.Entities;
using VacationRental.Api.Infrastructure.Interfaces;
using Xunit;

namespace VacationRental.Api.Tests.Aplication.Queries
{
    public class CalendarQueryHandlerTest
    {
        private readonly Mock<ICalendarRepositoryApp> calendarRepositoryAppMock;
        private readonly CalendarQueryHandler query;
        public CalendarQueryHandlerTest()
        {
            calendarRepositoryAppMock = new Mock<ICalendarRepositoryApp>();
            query = new CalendarQueryHandler(calendarRepositoryAppMock.Object);
        }
        [Fact]
        public async void CalendarQuery_OK()
        {
            int rentalId = 1;
            DateTime start = new DateTime(2022, 11, 01);
            int nights = 5;
            CalendarQuery cmd = new CalendarQuery(rentalId, start, nights);

            IList<Booking> lstBookings = new List<Booking>
            {
                new Booking{ Id = 1, Nights = 3, Start = start.AddDays(2),  Rental  = new Rental{ Id = 1, Units= 2, PreparationTimeInDays= 1 } },
                new Booking{ Id = 2, Nights = 5, Start = start.AddDays(10), Rental  = new Rental{ Id = 2, Units= 2, PreparationTimeInDays= 1 } },
                new Booking{ Id = 3, Nights = 2, Start = start.AddDays(1), Rental  = new Rental { Id = 1, Units= 2, PreparationTimeInDays= 2 } },
            };

            calendarRepositoryAppMock.Setup(x => x.GetCalendar(It.IsAny<int>(), It.IsAny<DateTime>(), It.IsAny<int>())).ReturnsAsync(lstBookings);

            var result = await query.Handle(cmd, cancellationToken: CancellationToken.None);

            calendarRepositoryAppMock.Verify(x => x.GetCalendar(rentalId, start, nights + 1), Times.Once);

            Assert.NotNull(result);
            Assert.Equal(rentalId, result.RentalId);
            Assert.Equal(nights + 1, result.Dates.Count);
            Assert.Empty(result.Dates[0].Bookings);
            Assert.Empty(result.Dates[0].PreparationTimes);
            Assert.Single(result.Dates[1].Bookings);
            Assert.Empty(result.Dates[1].PreparationTimes);
            Assert.Equal(2, result.Dates[2].Bookings.Count);
            Assert.Empty(result.Dates[2].PreparationTimes);
            Assert.Equal(2, result.Dates[3].Bookings.Count);
            Assert.Single(result.Dates[3].PreparationTimes);
            Assert.Single(result.Dates[4].Bookings);
            Assert.Single(result.Dates[4].PreparationTimes);

        }
    }
}
