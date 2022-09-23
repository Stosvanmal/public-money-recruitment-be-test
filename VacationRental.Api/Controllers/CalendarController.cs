using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using VacationRental.Api.Aplication.Dtos;
using VacationRental.Api.Aplication.Queries;

namespace VacationRental.Api.Controllers
{
    [Route("api/v1/calendar")]
    [ApiController]
    public class CalendarController : ControllerBase
    {
        private readonly IMediator mediator;

        public CalendarController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        public async Task<CalendarDto> Get(int rentalId, DateTime start, int nights)
        {
            
            var result = await mediator.Send(new CalendarQuery(rentalId, start, nights));
            return result;


        }
    }
}
