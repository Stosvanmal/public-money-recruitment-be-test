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
        private readonly IDictionary<int, RentalAppDto> _rentals;
        private readonly IMediator mediator;

        public RentalsController(IDictionary<int, RentalAppDto> rentals,IMediator mediator)
        {
            _rentals = rentals;
            this.mediator = mediator;
        }

        [HttpGet]
        [Route("{rentalId:int}")]
        public RentalAppDto Get(int rentalId)
        {
            if (!_rentals.ContainsKey(rentalId))
                throw new ApplicationException("Rental not found");

            return _rentals[rentalId];
        }

        [HttpPost]
        public async Task<ResourceIdAppDto> Post(CreateRentalCommand cmd)
        {
            var result = await mediator.Send(cmd);

            return result;
        }
    }
}
