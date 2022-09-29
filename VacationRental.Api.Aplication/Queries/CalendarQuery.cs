using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using VacationRental.Api.Aplication.Dtos;

namespace VacationRental.Api.Aplication.Queries
{
    public class CalendarQuery:IRequest<CalendarAppDto>
    {
        public CalendarQuery(int rentalId, DateTime start, int nights)
        {
            RentalId = rentalId;
            Start = start;
            Nights = nights;
        }

        public int RentalId { get; }
        public DateTime Start { get; }
        public int Nights { get; }
    }
}
