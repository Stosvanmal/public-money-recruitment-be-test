using VacationRental.Api.Business.Entities;
using VacationRental.Api.Business.Interfaces.Entities;
using Xunit;

namespace VacationRental.Api.Tests.Business
{
    public class RentalTest
    {
        private readonly IRental rental;
        public RentalTest()
        {
            rental = new Rental(2,2,2);
        }
        [Fact]  
        public void SetPreparationTimeInDaysTest_OK()
        {
            int preparationTimeInDays = 50;        
            rental.SetPreparationTimeInDays(preparationTimeInDays);
            Assert.Equal(preparationTimeInDays, rental.PreparationTimeInDays);
        }
    }
}
