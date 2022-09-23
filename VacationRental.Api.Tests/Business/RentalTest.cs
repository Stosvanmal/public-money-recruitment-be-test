using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using VacationRental.Api.Business.Interfaces;
using VacationRental.Api.Business.Models;
using Xunit;

namespace VacationRental.Api.Tests.Business
{
    public class RentalTest
    {
        private readonly IRentalModel rental;
        public RentalTest()
        {
           // rental = new Rental();
        }
        [Fact]  
        public void SetPreparationTimeInDaysTest()
        {
            int preparationTimeInDays = 50;
            



        }
    }
}
