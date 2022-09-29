using Moq;
using System.Threading;
using VacationRental.Api.Aplication.Commands;
using VacationRental.Api.Business.Dtos;
using VacationRental.Api.Business.Entities;
using VacationRental.Api.Business.Interfaces;
using VacationRental.Api.Business.Interfaces.Entities;
using VacationRental.Api.Infrastructure.Interfaces;
using Xunit;

namespace VacationRental.Api.Tests.Aplication.Commands
{
    public class CreateRentalCommandHandlerTest
    {
        private readonly Mock<IRentalRepository> rentalRepositoryMock;
        private readonly Mock<IUnitOfWork> unitOfWorkMock;
        private readonly Mock<IRentalFactory> rentalFactoryMock;
        private readonly CreateRentalCommandHandler command;
        public CreateRentalCommandHandlerTest()
        {
            this.rentalRepositoryMock = new Mock<IRentalRepository>();
            this.unitOfWorkMock = new Mock<IUnitOfWork>();
            this.rentalFactoryMock = new Mock<IRentalFactory>();
            this.command = new CreateRentalCommandHandler(rentalRepositoryMock.Object, rentalFactoryMock.Object, unitOfWorkMock.Object);
        }
        [Fact]
        public async void CreateRental_OK()
        {
            int resultId = 35;
            int units = 5;
            int preparation = 8;
            CreateRentalCommand cmd = new CreateRentalCommand(units, preparation);
            IRental rental = new Rental(0, units, preparation);
            RentalDto rentalDto = new RentalDto { Id = 0, Units = units, PreparationTimeInDays = preparation };
            rentalFactoryMock.Setup(x=> x.CreateRental(It.IsAny<RentalDto>())).Returns(rental);
            rentalRepositoryMock.Setup(x => x.AddRental(It.IsAny<IRental>())).ReturnsAsync(resultId);

            var res = await command.Handle(cmd, CancellationToken.None);

            rentalFactoryMock.Verify(x => x.CreateRental(It.Is<RentalDto>(r=> r.Id == rentalDto.Id 
                                                            && r.Units == rentalDto.Units 
                                                            && r.PreparationTimeInDays == rentalDto.PreparationTimeInDays)), Times.Once);
            rentalRepositoryMock.Verify(x => x.AddRental(
                It.Is<IRental>(m=> m.Id == rental.Id 
                                    && m.Units == rental.Units 
                                    && m.PreparationTimeInDays == rental.PreparationTimeInDays)), Times.Once);
            unitOfWorkMock.Verify(x => x.SaveChanges(), Times.Once);
            Assert.NotNull(res);
            Assert.Equal(resultId, res.Id);

        }
    }
}
