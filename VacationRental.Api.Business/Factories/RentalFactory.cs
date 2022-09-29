using System;
using System.Collections.Generic;
using System.Text;
using VacationRental.Api.Business.Dtos;
using VacationRental.Api.Business.Entities;
using VacationRental.Api.Business.Interfaces;
using VacationRental.Api.Business.Interfaces.Entities;

namespace VacationRental.Api.Business.Factories
{
    internal class RentalFactory: IRentalFactory
    {
        public IRental CreateRental(RentalDto rentalDto)
        {
            return new Rental(rentalDto.Id, rentalDto.Units, rentalDto.PreparationTimeInDays);
        }
    }
}
