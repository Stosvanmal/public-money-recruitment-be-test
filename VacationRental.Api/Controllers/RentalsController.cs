using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using VacationRental.Api.Aplication.Commands;
using VacationRental.Api.Aplication.Dtos;

namespace VacationRental.Api.Controllers
{
    [Route("api/v1/rentals")]
    [ApiController]
    public class RentalsController : ControllerBase
    {
        private readonly IDictionary<int, RentalDto> _rentals;
        private readonly IMediator mediator;

        public RentalsController(IDictionary<int, RentalDto> rentals,IMediator mediator)
        {
            _rentals = rentals;
            this.mediator = mediator;
        }

        [HttpGet]
        [Route("{rentalId:int}")]
        public RentalDto Get(int rentalId)
        {
            if (!_rentals.ContainsKey(rentalId))
                throw new ApplicationException("Rental not found");

            return _rentals[rentalId];
        }

        [HttpPost]
        public async Task<ResourceIdDto> Post(CreateRentalCommand cmd)
        {
            var result = await mediator.Send(cmd);

            return result;
        }
    }
}
